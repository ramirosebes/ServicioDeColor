using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_UsuarioPermiso
    {
        public List<Componente> ListarComponentesPorId(int idUsuario)
        {
            List<Componente> listaComponentes = new List<Componente>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Nombre, TipoComponente, Estado, Componente.IdComponente ");
                    query.AppendLine("from UsuarioComponente ");
                    query.AppendLine("inner join Componente on UsuarioComponente.IdComponente = Componente.IdComponente ");
                    query.AppendLine("where UsuarioComponente.IdUsuario = @IdUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

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
        public bool EditarUsuarioPermiso(int idUsuario, DataTable listaComponentes, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuarioPermiso", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("Componentes", listaComponentes);

                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

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
