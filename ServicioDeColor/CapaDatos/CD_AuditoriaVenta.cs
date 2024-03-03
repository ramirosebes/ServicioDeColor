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
    public class CD_AuditoriaVenta
    {
        public List<AuditoriaVenta> ListarAuditoriaVentas()
        {
            List<AuditoriaVenta> oListaAuditoriaVentas = new List<AuditoriaVenta>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select");
                    query.AppendLine("av.IdAuditoriaVenta,");
                    query.AppendLine("av.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],");
                    query.AppendLine("av.DescripcionAuditoria, av.FechaAuditoria,");
                    query.AppendLine("av.IdVenta,");
                    query.AppendLine("av.IdUsuario, uv.IdPersona[IdPersonaUsuarioVenta], pv.NombreCompleto[NombreCompletoUsuarioVenta], pv.Documento[DocumentoUsuarioVenta],");
                    query.AppendLine("av.IdCliente, pc.IdPersona[IdPersonaClienteVenta], pc.NombreCompleto[NombreCompletoClienteVenta], pc.Documento[DocumentoClienteVenta],");
                    query.AppendLine("TipoDocumento, NumeroDocumento, TipoDescuento, MontoDescuento, SubTotal, MontoPago, MontoCambio, MontoTotal, FechaRegistro");
                    query.AppendLine("from AuditoriaVenta av");
                    query.AppendLine("inner join Usuario ua on av.IdUsuarioAuditoria = ua.IdUsuario");
                    query.AppendLine("inner join Persona pa on ua.IdUsuario = pa.IdPersona");
                    query.AppendLine("inner join Usuario uv on av.IdUsuario = uv.IdUsuario");
                    query.AppendLine("inner join Persona pv on uv.IdPersona = pv.IdPersona");
                    query.AppendLine("inner join Cliente cv on av.IdCliente = cv.IdCliente");
                    query.AppendLine("inner join Persona pc on cv.IdPersona = pc.IdPersona");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AuditoriaVenta oAuditoriaVenta = new AuditoriaVenta();
                        oAuditoriaVenta.IdAuditoriaVenta = Convert.ToInt32(dr["IdAuditoriaVenta"]);
                        oAuditoriaVenta.oUsuarioAuditoria = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuarioAuditoria"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioAuditoria"]), NombreCompleto = dr["NombreCompletoUsuarioAuditoria"].ToString(), Documento = dr["DocumentoUsuarioAuditoria"].ToString() };
                        oAuditoriaVenta.DescripcionAuditoria = dr["DescripcionAuditoria"].ToString();
                        oAuditoriaVenta.FechaAuditoria = dr["FechaAuditoria"].ToString();
                        oAuditoriaVenta.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                        oAuditoriaVenta.oUsuarioVenta = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioVenta"]), NombreCompleto = dr["NombreCompletoUsuarioVenta"].ToString(), Documento = dr["DocumentoUsuarioVenta"].ToString() };
                        oAuditoriaVenta.oCliente = new Cliente { IdCliente = Convert.ToInt32(dr["IdCliente"]), IdPersona = Convert.ToInt32(dr["IdPersonaClienteVenta"]), NombreCompleto = dr["NombreCompletoClienteVenta"].ToString(), Documento = dr["DocumentoClienteVenta"].ToString() };
                        oAuditoriaVenta.TipoDocumento = dr["TipoDocumento"].ToString();
                        oAuditoriaVenta.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        oAuditoriaVenta.TipoDescuento = dr["TipoDescuento"].ToString();
                        oAuditoriaVenta.MontoDescuento = Convert.ToDecimal(dr["MontoDescuento"]);
                        oAuditoriaVenta.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
                        oAuditoriaVenta.MontoPago = Convert.ToDecimal(dr["MontoPago"]);
                        oAuditoriaVenta.MontoCambio = Convert.ToDecimal(dr["MontoCambio"]);
                        oAuditoriaVenta.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                        oAuditoriaVenta.FechaRegistro = dr["FechaRegistro"].ToString();

                        oListaAuditoriaVentas.Add(oAuditoriaVenta);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaAuditoriaVentas;
        }

        public AuditoriaVenta ObtenerAuditoriaVenta(int idAuditoriaVenta)
        {
            AuditoriaVenta oAuditoriaVenta = new AuditoriaVenta();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select");
                    query.AppendLine("av.IdAuditoriaVenta,");
                    query.AppendLine("av.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],");
                    query.AppendLine("av.DescripcionAuditoria, av.FechaAuditoria,");
                    query.AppendLine("av.IdVenta,");
                    query.AppendLine("av.IdUsuario, uv.IdPersona[IdPersonaUsuarioVenta], pv.NombreCompleto[NombreCompletoUsuarioVenta], pv.Documento[DocumentoUsuarioVenta],");
                    query.AppendLine("av.IdCliente, pc.IdPersona[IdPersonaClienteVenta], pc.NombreCompleto[NombreCompletoClienteVenta], pc.Documento[DocumentoClienteVenta],");
                    query.AppendLine("TipoDocumento, NumeroDocumento, TipoDescuento, MontoDescuento, SubTotal, MontoPago, MontoCambio, MontoTotal, FechaRegistro");
                    query.AppendLine("from AuditoriaVenta av");
                    query.AppendLine("inner join Usuario ua on av.IdUsuarioAuditoria = ua.IdUsuario");
                    query.AppendLine("inner join Persona pa on ua.IdUsuario = pa.IdPersona");
                    query.AppendLine("inner join Usuario uv on av.IdUsuario = uv.IdUsuario");
                    query.AppendLine("inner join Persona pv on uv.IdPersona = pv.IdPersona");
                    query.AppendLine("inner join Cliente cv on av.IdCliente = cv.IdCliente");
                    query.AppendLine("inner join Persona pc on cv.IdPersona = pc.IdPersona");
                    query.AppendLine("where av.IdAuditoriaVenta = @idAuditoriaVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idAuditoriaVenta", idAuditoriaVenta);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oAuditoriaVenta = new AuditoriaVenta()
                            {
                                IdAuditoriaVenta = Convert.ToInt32(dr["IdAuditoriaVenta"]),
                                oUsuarioAuditoria = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuarioAuditoria"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioAuditoria"]), NombreCompleto = dr["NombreCompletoUsuarioAuditoria"].ToString(), Documento = dr["DocumentoUsuarioAuditoria"].ToString() },
                                DescripcionAuditoria = dr["DescripcionAuditoria"].ToString(),
                                FechaAuditoria = dr["FechaAuditoria"].ToString(),
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                oUsuarioVenta = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioVenta"]), NombreCompleto = dr["NombreCompletoUsuarioVenta"].ToString(), Documento = dr["DocumentoUsuarioVenta"].ToString() },
                                oCliente = new Cliente { IdCliente = Convert.ToInt32(dr["IdCliente"]), IdPersona = Convert.ToInt32(dr["IdPersonaClienteVenta"]), NombreCompleto = dr["NombreCompletoClienteVenta"].ToString(), Documento = dr["DocumentoClienteVenta"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                TipoDescuento = dr["TipoDescuento"].ToString(),
                                MontoDescuento = Convert.ToDecimal(dr["MontoDescuento"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"]),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            CD_Conexion.CerrarConexion();
            return oAuditoriaVenta;
        }

        public List<AuditoriaDetalleVenta> ObtenerAuditoriaDetalleVenta(int idAuditoriaVenta)
        {
            List<AuditoriaDetalleVenta> oListaAuditoriaDetalleVenta = new List<AuditoriaDetalleVenta>();

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre,");
                    query.AppendLine("adv.DescripcionAuditoria, adv.FechaAuditoria,");
                    query.AppendLine("adv.PrecioVenta, adv.Cantidad, adv.SubTotal");
                    query.AppendLine("from AuditoriaDetalleVenta adv");
                    query.AppendLine("inner join Producto p on p.IdProducto = adv.IdProducto");
                    query.AppendLine("where adv.IdAuditoriaVenta = @idAuditoriaVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idAuditoriaVenta", idAuditoriaVenta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaAuditoriaDetalleVenta.Add(new AuditoriaDetalleVenta()
                            {
                                DescripcionAuditoria = dr["DescripcionAuditoria"].ToString(),
                                FechaAuditoria = dr["FechaAuditoria"].ToString(),
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            CD_Conexion.CerrarConexion();
            return oListaAuditoriaDetalleVenta;
        }
    }
}
