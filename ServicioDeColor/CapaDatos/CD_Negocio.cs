using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio negocio = new Negocio();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    string query = "select IdNegocio, Nombre, CUIT, Direccion, Correo, Clave from Negocio where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        negocio.IdNegocio = Convert.ToInt32(dr["IdNegocio"]);
                        negocio.Nombre = dr["Nombre"].ToString();
                        negocio.CUIT = dr["CUIT"].ToString();
                        negocio.Direccion = dr["Direccion"].ToString();
                        negocio.Correo = dr["Correo"].ToString();
                        negocio.Clave = dr["Clave"].ToString();
                    }   
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return negocio;
        }

        public bool GuardarDatos(Negocio oNegocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Negocio set Nombre = @Nombre,");
                    query.AppendLine("CUIT = @CUIT,");
                    query.AppendLine("Direccion = @Direccion,");
                    query.AppendLine("Correo = @Correo,");
                    query.AppendLine("Clave = @Clave");
                    query.AppendLine("where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre", oNegocio.Nombre);
                    cmd.Parameters.AddWithValue("@CUIT", oNegocio.CUIT);
                    cmd.Parameters.AddWithValue("@Direccion", oNegocio.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", oNegocio.Correo);
                    cmd.Parameters.AddWithValue("@Clave", oNegocio.Clave);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }
                }

                CD_Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    string query = "select Logo from Negocio where IdNegocio = 1;";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }
                }

                CD_Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }

            return LogoBytes;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Negocio set Logo = @Imagen");
                    query.AppendLine("where IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Imagen", image);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }

                CD_Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }

            return respuesta;
        }
    }
}
