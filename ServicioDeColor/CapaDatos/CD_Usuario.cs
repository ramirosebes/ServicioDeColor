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
    public class CD_Usuario
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdUsuario,Clave,Estado,");
                    query.AppendLine("Persona.IdPersona,Persona.NombreCompleto,Persona.Correo,Persona.Documento ");
                    query.AppendLine("from Usuario ");
                    query.AppendLine("inner join Persona on Usuario.IdPersona = Persona.IdPersona");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                        usuario.SetClave(dr["Clave"].ToString());
                        usuario.Estado = Convert.ToBoolean(dr["Estado"]);
                        usuario.IdPersona = Convert.ToInt32(dr["IdPersona"]);
                        usuario.NombreCompleto = dr["NombreCompleto"].ToString();
                        usuario.Correo = dr["Correo"].ToString();
                        usuario.Documento = dr["Documento"].ToString();

                        listaUsuarios.Add(usuario);
                    }
                }
                catch (Exception ex)
                {
                    listaUsuarios = new List<Usuario>();
                }
            }
            CD_Conexion.CerrarConexion();
            return listaUsuarios;
        }
        public int AgregarUsuario(Usuario oUsuario, string clave, out string mensaje)
        {
            int idUsuarioRegistrado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("NombreCompleto", oUsuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cmd.Parameters.AddWithValue("Documento", oUsuario.Documento);
                    cmd.Parameters.AddWithValue("Clave", clave);
                    cmd.Parameters.AddWithValue("Estado", oUsuario.Estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("IdUsuarioRegistrado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    idUsuarioRegistrado = Convert.ToInt32(cmd.Parameters["IdUsuarioRegistrado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    idUsuarioRegistrado = 0;
                    mensaje = ex.Message;
                }
            }
            CD_Conexion.CerrarConexion();
            return idUsuarioRegistrado;
        }
        public bool EditarUsuario(Usuario oUsuario, out string mensaje)
        {
            bool usuarioEditado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdPersona", oUsuario.IdPersona);
                    cmd.Parameters.AddWithValue("NombreCompleto", oUsuario.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cmd.Parameters.AddWithValue("Documento", oUsuario.Documento);
                    cmd.Parameters.AddWithValue("Estado", oUsuario.Estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    usuarioEditado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    usuarioEditado = false;
                    mensaje = ex.Message;
                }
            }
            CD_Conexion.CerrarConexion();
            return usuarioEditado;
        }
        public bool RestablecerClave(int idUsuario, string clave, out string mensaje)
        {
            bool claveRestablecida = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RestablecerClave", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("Clave", clave);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    claveRestablecida = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    claveRestablecida = false;
                    mensaje = ex.Message;
                }
            }
            CD_Conexion.CerrarConexion();
            return claveRestablecida;
        }
        public bool EliminarUsuario(int idUsuario, int idPersona, out string mensaje)
        {
            bool usuarioEliminado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("IdPersona", idPersona);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    usuarioEliminado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    usuarioEliminado = false;
                    mensaje = ex.Message;
                }
            }
            CD_Conexion.CerrarConexion();
            return usuarioEliminado;
        }
    }
}
