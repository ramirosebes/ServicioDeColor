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
    public class CD_Venta
    {
        #region Listar ventas
        public List<Venta> ListarVentas()
        {
            List<Venta> oListaVentas = new List<Venta>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.IdVenta,");
                    query.AppendLine("u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario], pu.IdPersona[IdPersonaUsuario],");
                    query.AppendLine("c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente], pc.IdPersona[IdPersonaCliente],");
                    query.AppendLine("v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.SubTotal, v.MontoTotal, v.TipoDescuento, v.MontoDescuento, convert(char(10),v.FechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from Venta v");
                    query.AppendLine("inner join Usuario u on u.IdUsuario = v.IdUsuario");
                    query.AppendLine("inner join Persona pu on pu.IdPersona = u.IdPersona");
                    query.AppendLine("inner join Cliente c on c.IdCliente = v.IdCliente");
                    query.AppendLine("inner join Persona pc on pc.IdPersona = c.IdPersona");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Venta oVenta = new Venta();
                        oVenta.IdVenta = int.Parse(dr["IdVenta"].ToString());
                        oVenta.oUsuario = new Usuario() { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), NombreCompleto = dr["NombreCompletoUsuario"].ToString(), IdPersona = Convert.ToInt32(dr["IdPersonaUsuario"]), Documento = dr["DocumentoUsuario"].ToString() };
                        oVenta.oCliente = new Cliente() { IdCliente = Convert.ToInt32(dr["IdCliente"]), NombreCompleto = dr["NombreCompletoCliente"].ToString(), IdPersona = Convert.ToInt32(dr["IdPersonaCliente"]), Documento = dr["DocumentoCliente"].ToString() };
                        oVenta.TipoDocumento = dr["TipoDocumento"].ToString();
                        oVenta.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        oVenta.MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString());
                        oVenta.MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString());
                        oVenta.SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString());
                        oVenta.MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString());
                        oVenta.TipoDescuento = dr["TipoDescuento"].ToString();
                        oVenta.MontoDescuento = Convert.ToDecimal(dr["MontoDescuento"].ToString());
                        oVenta.FechaRegistro = dr["FechaRegistro"].ToString();
                        oListaVentas.Add(oVenta);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                CD_Conexion.CerrarConexion();
                return oListaVentas;
            }
        }
        #endregion

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;
            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }

            CD_Conexion.CerrarConexion();
            return idCorrelativo;
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update Producto set Stock = Stock - @cantidad where IdProducto = @idProducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            CD_Conexion.CerrarConexion();
            return respuesta;
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update Producto set Stock = Stock + @cantidad where IdProducto = @idProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.CommandType = CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            CD_Conexion.CerrarConexion();
            return respuesta;
        }

        public bool AgregarVenta(Venta oVenta, DataTable oDetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarVenta", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", oVenta.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdCliente", oVenta.oCliente.IdCliente);
                    cmd.Parameters.AddWithValue("TipoDocumento", oVenta.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", oVenta.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoPago", oVenta.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", oVenta.MontoCambio);
                    cmd.Parameters.AddWithValue("SubTotal", oVenta.SubTotal);
                    cmd.Parameters.AddWithValue("MontoTotal", oVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("TipoDescuento", oVenta.TipoDescuento);
                    cmd.Parameters.AddWithValue("MontoDescuento", oVenta.MontoDescuento);
                    cmd.Parameters.AddWithValue("DetalleVenta", oDetalleVenta);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return Respuesta;
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta oVenta = new Venta();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.IdVenta,");
                    query.AppendLine("u.IdUsuario, pu.NombreCompleto[NombreCompletoUsuario], pu.Documento[DocumentoUsuario], pu.IdPersona[IdPersonaUsuario],");
                    query.AppendLine("c.IdCliente, pc.NombreCompleto[NombreCompletoCliente], pc.Documento[DocumentoCliente], pc.IdPersona[IdPersonaCliente],");
                    query.AppendLine("v.TipoDocumento, v.NumeroDocumento, v.MontoPago, v.MontoCambio, v.SubTotal, v.MontoTotal, v.TipoDescuento, v.MontoDescuento, convert(char(10),v.FechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from Venta v");
                    query.AppendLine("inner join Usuario u on u.IdUsuario = v.IdUsuario");
                    query.AppendLine("inner join Persona pu on pu.IdPersona = u.IdPersona");
                    query.AppendLine("inner join Cliente c on c.IdCliente = v.IdCliente");
                    query.AppendLine("inner join Persona pc on pc.IdPersona = c.IdPersona");
                    query.AppendLine("where v.NumeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oVenta = new Venta()
                            {
                                IdVenta = int.Parse(dr["IdVenta"].ToString()),
                                oUsuario = new Usuario() { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), NombreCompleto = dr["NombreCompletoUsuario"].ToString(), IdPersona = Convert.ToInt32(dr["IdPersonaUsuario"]), Documento = dr["DocumentoUsuario"].ToString() },
                                oCliente = new Cliente() { IdCliente = Convert.ToInt32(dr["IdCliente"]), NombreCompleto = dr["NombreCompletoCliente"].ToString(), IdPersona = Convert.ToInt32(dr["IdPersonaCliente"]), Documento = dr["DocumentoCliente"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                TipoDescuento = dr["TipoDescuento"].ToString(),
                                MontoDescuento = Convert.ToDecimal(dr["MontoDescuento"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                    //oVenta = new Venta();
                }
            }
            
            CD_Conexion.CerrarConexion();
            return oVenta;
        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> oListaDetalleVenta = new List<DetalleVenta>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal from DetalleVenta dv");
                    query.AppendLine("inner join Producto p on p.IdProducto = dv.IdProducto");
                    query.AppendLine("where dv.IdVenta = @idVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaDetalleVenta.Add(new DetalleVenta()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                    //oListaDetalleVenta = new List<DetalleVenta>();
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaDetalleVenta;
        }

        public bool EliminarVenta(int idVenta, out string mensaje)
        {
            bool ventaEliminada = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarVenta", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdVenta", idVenta);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 400).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    ventaEliminada = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    ventaEliminada = false;
                    mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return ventaEliminada;
        }
    }
}
