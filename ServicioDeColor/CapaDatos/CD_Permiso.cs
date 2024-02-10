using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> ListarPermisosPorId(int idUsuario)
        {
            List<Componente> listaComponentes = new List<Componente>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Componente.IdComponente, Nombre, TipoComponente, Estado ");
                    query.AppendLine("from UsuarioComponente ");
                    query.AppendLine("inner join Componente on UsuarioComponente.IdComponente = Componente.IdComponente ");
                    query.AppendLine("where UsuarioComponente.IdUsuario = @IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Componente componente = new Componente();
                        componente.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        componente.Nombre = dr["Nombre"].ToString();
                        componente.TipoComponente = dr["TipoComponente"].ToString();
                        componente.Estado = Convert.ToBoolean(dr["Estado"]);

                        listaComponentes.Add(componente);
                    }
                }
                catch (Exception ex)
                {
                    List<Permiso> listaPermisos = new List<Permiso>();
                    CD_Conexion.CerrarConexion();
                    return listaPermisos;
                }
            }
            CD_Conexion.CerrarConexion();
            return DiferenciarComponentes(listaComponentes);
        }
        private List<Permiso> DiferenciarComponentes(List<Componente> listaComponentes)
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            List<Componente> listaPermisoComponente = new List<Componente>();
            List<Componente> listaGrupoPermisoComponente = new List<Componente>();

            do
            {
                foreach (Componente componente in listaComponentes)
                {
                    if (componente.Estado)
                    {
                        if (componente.TipoComponente == "Permiso")
                        {
                            listaPermisoComponente.Add(componente);
                        }
                        else if (componente.TipoComponente == "GrupoPermiso")
                        {
                            listaGrupoPermisoComponente.Add(componente);
                        }
                    }
                }

                listaComponentes.Clear();

                foreach (Componente componentePermiso in listaPermisoComponente)
                {
                    using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                    {
                        CD_Conexion.ObtenerConexion();
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select IdPermiso, NombreMenu ");
                            query.AppendLine("from Permiso ");
                            query.AppendLine("inner join Componente on Permiso.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where Permiso.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                            cmd.Parameters.AddWithValue("IdComponente", componentePermiso.IdComponente);

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Permiso permiso = new Permiso()
                                {
                                    IdComponente = componentePermiso.IdComponente,
                                    Nombre = componentePermiso.Nombre,
                                    TipoComponente = componentePermiso.TipoComponente,
                                    Estado = componentePermiso.Estado,
                                    IdPermiso = Convert.ToInt32(dr["IdPermiso"]),
                                    NombreMenu = dr["NombreMenu"].ToString()
                                };
                                listaPermisos.Add(permiso);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                        CD_Conexion.CerrarConexion();
                    }
                }

                foreach (Componente componenteGrupoPermiso in listaGrupoPermisoComponente)
                {
                    string idGrupoPermiso = "";
                    using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                    {
                        CD_Conexion.ObtenerConexion();
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select GrupoPermiso.IdGrupoPermiso, Nombre ");
                            query.AppendLine("from GrupoPermiso ");
                            query.AppendLine("inner join Componente on GrupoPermiso.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where GrupoPermiso.IdComponente = @IdComponente");

                            SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                            cmd.Parameters.AddWithValue("IdComponente", componenteGrupoPermiso.IdComponente);

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                idGrupoPermiso = dr["IdGrupoPermiso"].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                        CD_Conexion.CerrarConexion();
                    }
                    using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                    {
                        CD_Conexion.ObtenerConexion();
                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select Componente.IdComponente, Nombre, TipoComponente, Estado ");
                            query.AppendLine("from Componente ");
                            query.AppendLine("inner join GrupoPermisoComponente on GrupoPermisoComponente.IdComponente = Componente.IdComponente ");
                            query.AppendLine("where GrupoPermisoComponente.IdGrupoPermiso = @IdGrupoPermiso ");

                            SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                            cmd.Parameters.AddWithValue("IdGrupoPermiso", idGrupoPermiso);

                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                Componente componenteDiferenciado = new Componente()
                                {
                                    IdComponente = Convert.ToInt32(dr["IdComponente"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    TipoComponente = dr["TipoComponente"].ToString(),
                                    Estado = Convert.ToBoolean(dr["Estado"])
                                };
                                listaComponentes.Add(componenteDiferenciado);
                            }
                            CD_Conexion.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Hay un error en la base de datos " + ex.Message);
                        }
                        CD_Conexion.CerrarConexion();
                    }
                }

                listaPermisoComponente.Clear();
                listaGrupoPermisoComponente.Clear();

            }
            while (listaComponentes.Count != 0);

            return listaPermisos;
        }
        public List<Permiso> ListarPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Componente.IdComponente, Nombre, Estado, ");
                    query.AppendLine("Permiso.IdPermiso, Permiso.NombreMenu");
                    query.AppendLine("from Componente ");
                    query.AppendLine("inner join Permiso on Componente.IdComponente = Permiso.IdComponente ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Permiso permiso = new Permiso();
                        permiso.IdComponente = Convert.ToInt32(dr["IdComponente"]);
                        permiso.Nombre = dr["Nombre"].ToString();
                        permiso.TipoComponente = "Permiso";
                        permiso.Estado = Convert.ToBoolean(dr["Estado"]);
                        permiso.IdPermiso = Convert.ToInt32(dr["IdPermiso"]);
                        permiso.NombreMenu = dr["NombreMenu"].ToString();

                        listaPermisos.Add(permiso);
                    }
                }
                catch (Exception ex)
                {
                    listaPermisos = new List<Permiso>();
                }
            }
            CD_Conexion.CerrarConexion();
            return listaPermisos;
        }
        public bool EditarEstado(int idComponente, bool estado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarEstadoPermiso", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdComponente", idComponente);
                    cmd.Parameters.AddWithValue("Estado", estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    resultado = false;
                }
            }
            CD_Conexion.CerrarConexion();
            return resultado;
        }
    }
}
