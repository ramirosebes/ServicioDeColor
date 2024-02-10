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
    public class CD_Proveedor
    {
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProveedor, CUIT, RazonSocial, Correo, Telefono, Estado from Proveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listaProveedores.Add(new Proveedor()
                        {
                            IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                            CUIT = dr["CUIT"].ToString(),
                            RazonSocial = dr["RazonSocial"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"]),
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return listaProveedores;
        }

        public int AgregarProveedor(Proveedor oProveedor, out string mensaje)
        {
            int proveedorRegistrado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("CUIT", oProveedor.CUIT);
                    cmd.Parameters.AddWithValue("RazonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", oProveedor.Correo);
                    cmd.Parameters.AddWithValue("Telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("Estado", oProveedor.Estado);
                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    proveedorRegistrado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                 catch (Exception ex)
                {
                    proveedorRegistrado = 0;
                    mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return proveedorRegistrado;
        }

        public bool EditarProveedor(Proveedor oProveedor, out string mensaje)
        {
            bool proveedorEditado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProveedor", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdProveedor", oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("CUIT", oProveedor.CUIT);
                    cmd.Parameters.AddWithValue("RazonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", oProveedor.Correo);
                    cmd.Parameters.AddWithValue("Telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("Estado", oProveedor.Estado);
                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    proveedorEditado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    proveedorEditado = false;
                    mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return proveedorEditado;
        }

        public bool EliminarProveedor(int idProveedor, out string mensaje)
        {
            bool proveedorEliminado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdProveedor", idProveedor);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    proveedorEliminado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    proveedorEliminado = false;
                    mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return proveedorEliminado;
        }
    }
}
