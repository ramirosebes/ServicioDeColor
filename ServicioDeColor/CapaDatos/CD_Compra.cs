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
    public class CD_Compra
    {
        #region ListarCompras
        public List<Compra> ListarCompras()
        {
            List<Compra> oListaCompras = new List<Compra>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCompra, c.IdUsuario, u.IdPersona, ps.NombreCompleto, c.IdProveedor, p.RazonSocial,TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro FROM Compra c");
                    query.AppendLine("INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario");
                    query.AppendLine("INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor");
                    query.AppendLine("INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Compra oCompra = new Compra();
                        oCompra.IdCompra = Convert.ToInt32(dr["IdCompra"]);
                        oCompra.oUsuario = new Usuario() { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersona"]), NombreCompleto = dr["NombreCompleto"].ToString() };
                        //oCompra.oPersona = new Persona() { IdPersona = Convert.ToInt32(dr["IdPersona"]), NombreCompleto = dr["NombreCompleto"].ToString() };
                        oCompra.oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(dr["IdProveedor"]), RazonSocial = dr["RazonSocial"].ToString() };
                        oCompra.TipoDocumento = dr["TipoDocumento"].ToString();
                        oCompra.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        oCompra.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                        oCompra.FechaRegistro = dr["FechaRegistro"].ToString();

                        // Ahora obtenemos los detalles de la compra
                        //compra.oDetalleCompra = ListarDetallesCompras(conexion, compra.IdCompra);

                        oListaCompras.Add(oCompra);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaCompras;
        }

        public List<Compra> ListarComprasPorFechaYId(string fechaInicio, string fechaFin, int idProveedor)
        {
            List<Compra> oListaComprasPorFechaYId = new List<Compra>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("set dateformat dmy;");
                    query.AppendLine("SELECT c.IdCompra, ");
                    query.AppendLine("c.IdUsuario, u.IdPersona, ps.NombreCompleto, ");
                    query.AppendLine("c.IdProveedor, p.RazonSocial, p.CUIT,");
                    query.AppendLine("TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro ");
                    query.AppendLine("FROM Compra c");
                    query.AppendLine("INNER JOIN Usuario u ON c.IdUsuario = u.IdUsuario");
                    query.AppendLine("INNER JOIN Proveedor p ON c.IdProveedor = p.IdProveedor");
                    query.AppendLine("INNER JOIN Persona ps ON u.IdPersona = ps.IdPersona");
                    query.AppendLine("where convert(date, c.FechaRegistro, 103) between @fechaInicio and @fechaFin and c.IdProveedor = @idProveedor");
                    query.AppendLine("set dateformat mdy;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Compra oCompra = new Compra();
                        oCompra.IdCompra = Convert.ToInt32(dr["IdCompra"]);
                        oCompra.oUsuario = new Usuario() { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersona"]), NombreCompleto = dr["NombreCompleto"].ToString() };
                        oCompra.oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(dr["IdProveedor"]), RazonSocial = dr["RazonSocial"].ToString(), CUIT = dr["CUIT"].ToString() };
                        oCompra.TipoDocumento = dr["TipoDocumento"].ToString();
                        oCompra.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        oCompra.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                        oCompra.FechaRegistro = dr["FechaRegistro"].ToString();

                        oListaComprasPorFechaYId.Add(oCompra);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaComprasPorFechaYId;
        }

        private List<DetalleCompra> ListarDetallesCompras(SqlConnection conexion, int idCompra) //ObtenerDetalleCompra
        {
            List<DetalleCompra> detallesCompra = new List<DetalleCompra>();

            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT IdDetalleCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal, FechaRegistro");
                query.AppendLine("FROM DetalleCompra");
                query.AppendLine("WHERE IdCompra = @IdCompra");

                SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DetalleCompra detalle = new DetalleCompra();
                    detalle.IdDetalleCompra = Convert.ToInt32(dr["IdDetalleCompra"]);
                    detalle.oProducto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                    detalle.PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]);
                    detalle.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                    detalle.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    detalle.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                    detalle.FechaRegistro = dr["FechaRegistro"].ToString();

                    detallesCompra.Add(detalle);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return detallesCompra;
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
                    query.AppendLine("select count(*) + 1 from Compra");

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

        public bool AgregarCompra(Compra oCompra, DataTable oDetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCompra", conexion);

                    //PARAMETROS DE ENTRADA --> Revisar si hay que agregar la entidad Persona tambien
                    cmd.Parameters.AddWithValue("IdUsuario", oCompra.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", oCompra.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", oCompra.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", oCompra.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal", oCompra.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", oDetalleCompra);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; //SqlDbType.Int
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

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = new Compra();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdCompra,");
                    query.AppendLine("c.IdUsuario,");
                    query.AppendLine("ps.NombreCompleto,");
                    query.AppendLine("pr.CUIT, pr.RazonSocial,");
                    query.AppendLine("c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103)[FechaRegistro]");
                    query.AppendLine("from Compra c");
                    query.AppendLine("inner join Usuario u on u.IdUsuario = c.IdUsuario");
                    query.AppendLine("inner join Persona ps on ps.IdPersona = u.IdPersona");
                    query.AppendLine("inner join Proveedor pr on pr.IdProveedor = c.IdProveedor");
                    query.AppendLine("where c.NumeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oCompra = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario() { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), NombreCompleto = dr["NombreCompleto"].ToString() },
                                //oPersona = new Persona() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                oProveedor = new Proveedor() { CUIT = dr["CUIT"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }

                    }
                }
                catch (Exception ex)
                {
                    //oCompra = new Compra();
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oCompra;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> listaDetallesCompras = new List<DetalleCompra>();

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Nombre,");
                    query.AppendLine("dc.PrecioCompra, dc.Cantidad, dc.MontoTotal");
                    query.AppendLine("from DetalleCompra dc");
                    query.AppendLine("inner join Producto p on p.IdProducto = dc.IdProducto");
                    query.AppendLine("where dc.IdCompra = @IdCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaDetallesCompras.Add(new DetalleCompra()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString())
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //listaDetallesCompras = new List<DetalleCompra>();
                throw new Exception(ex.Message);
            }

            CD_Conexion.CerrarConexion();
            return listaDetallesCompras;
        }

        public bool EliminarCompra (int idCompra, int idUsuario,out string mensaje)
        {
            bool compraEliminada = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarCompra", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdCompra", idCompra);
                    cmd.Parameters.AddWithValue("IdUsuarioAuditoria", idUsuario);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", System.Data.SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", System.Data.SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    compraEliminada = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    compraEliminada = false;
                    mensaje = ex.Message;
                }
            }

            CD_Conexion.CerrarConexion();
            return compraEliminada;
        }
    }
}
