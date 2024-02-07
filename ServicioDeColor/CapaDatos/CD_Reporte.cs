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
    public class CD_Reporte
    {
        public List<ReporteCompra> ListarReporteCompras(string fechaInicio, string fechaFin, int idProveedor)
        {
            List<ReporteCompra> oListaReporteCompras = new List<ReporteCompra>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_ReporteCompras", conexion);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaReporteCompras.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["NombreCompletoUsuario"].ToString(),
                                CUITProveedor = dr["CUIT"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    //oListaReporteCompras = new List<ReporteCompra>();
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaReporteCompras;
        }

        public List<ReporteVenta> ListarReporteVentas(string fechaInicio, string fechaFin, int idCliente)
        {
            List<ReporteVenta> oListaReporteVentas = new List<ReporteVenta>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_REPORTEVENTAS", conexion);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaReporteVentas.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["NombreCompletoUsuario"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCompletoCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    //oListaReporteVentas = new List<ReporteVenta>();
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaReporteVentas;
        }
    }
}
