using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_GrupoPermiso
    {
        public List<GrupoPermiso> ListarGrupoPermisos()
        {
            List<GrupoPermiso> listaGrupoPermisos = new List<GrupoPermiso>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Componente.IdComponente, Nombre, Estado,");
                    query.AppendLine("GrupoPermiso.IdGrupoPermiso ");
                    query.AppendLine("from Componente ");
                    query.AppendLine("inner join GrupoPermiso on Componente.IdComponente = GrupoPermiso.IdComponente");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        GrupoPermiso grupoPermiso = new GrupoPermiso();
                        grupoPermiso.IdGrupoPermiso = Convert.ToInt32(dr["IdGrupoPermiso"]);
                        grupoPermiso.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        grupoPermiso.Nombre = dr["Nombre"].ToString();
                        grupoPermiso.Estado = Convert.ToBoolean(dr["Estado"]);
                        grupoPermiso.NombreGrupo = dr["Nombre"].ToString();

                        listaGrupoPermisos.Add(grupoPermiso);
                    }
                }
                catch (Exception ex)
                {
                    listaGrupoPermisos = new List<GrupoPermiso>();
                }
            }
            CD_Conexion.CerrarConexion();
            return listaGrupoPermisos;
        }
        public List<Componente> ListarComponentes(int idGrupoPermiso)
        {
            List<Componente> listaComponentes = new List<Componente>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    if (idGrupoPermiso != 0)
                    {
                        query.AppendLine("select Nombre, TipoComponente, Estado, Componente.IdComponente ");
                        query.AppendLine("from GrupoPermisoComponente ");
                        query.AppendLine("inner join GrupoPermiso on GrupoPermisoComponente.IdGrupoPermiso = GrupoPermiso.IdGrupoPermiso ");
                        query.AppendLine("inner join Componente on GrupoPermisoComponente.IdComponente = Componente.IdComponente ");
                        query.AppendLine("where GrupoPermisoComponente.IdGrupoPermiso = @IdGrupoPermiso");

                    }
                    else
                    {
                        query.AppendLine("select IdComponente, Nombre, TipoComponente, Estado ");
                        query.AppendLine("from Componente");
                    }

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    if (idGrupoPermiso != 0)
                    {
                        cmd.Parameters.AddWithValue("@IdGrupoPermiso", idGrupoPermiso);
                    }
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Componente componente = new Componente();
                        componente.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        componente.Nombre = dr["Nombre"].ToString();
                        componente.Estado = Convert.ToBoolean(dr["Estado"]);
                        componente.TipoComponente = dr["TipoComponente"].ToString();

                        listaComponentes.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    listaComponentes = new List<Componente>();
                }
            }
            CD_Conexion.CerrarConexion();
            return listaComponentes;
        }
        public bool AgregarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarGrupoPermiso", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("NombreGrupo", oGrupoPermiso.NombreGrupo);
                    cmd.Parameters.AddWithValue("Estado", oGrupoPermiso.Estado);
                    cmd.Parameters.AddWithValue("Componentes", listaComponentes);

                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;

                    //EJECUTAR COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    //OBTENER PARAMETROS DE SALIDA
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            CD_Conexion.CerrarConexion();
            return resultado;
        }
        public bool EditarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarGrupoPermiso", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdGrupoPermiso", oGrupoPermiso.IdGrupoPermiso);
                    cmd.Parameters.AddWithValue("IdComponente", oGrupoPermiso.IdComponente);
                    cmd.Parameters.AddWithValue("NombreGrupo", oGrupoPermiso.NombreGrupo);
                    cmd.Parameters.AddWithValue("Estado", oGrupoPermiso.Estado);
                    cmd.Parameters.AddWithValue("Componentes", listaComponentes);

                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;

                    //EJECUTAR COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    //OBTENER PARAMETROS DE SALIDA
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            CD_Conexion.CerrarConexion();
            return resultado;
        }
        public bool EliminarGrupoPermiso(GrupoPermiso oGrupoPermiso, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarGrupoPermiso", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdGrupoPermiso", oGrupoPermiso.IdGrupoPermiso);
                    cmd.Parameters.AddWithValue("IdComponente", oGrupoPermiso.IdComponente);

                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;

                    //EJECUTAR COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                    //OBTENER PARAMETROS DE SALIDA
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    resultado = false;
                }
            }
            CD_Conexion.CerrarConexion();
            return resultado;
        }
    }
}
