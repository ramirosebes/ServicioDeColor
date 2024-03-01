using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_AuditoriaCompra
    {
        public List<AuditoriaCompra> ListarAuditoriaCompras()
        {
            List<AuditoriaCompra> oListaAuditoriaCompras = new List<AuditoriaCompra>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select");
                    query.AppendLine("ac.IdAuditoriaCompra,");
                    query.AppendLine("ac.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],");
                    query.AppendLine("ac.IdProveedor, pv.RazonSocial, pv.CUIT, pv.Correo,");
                    query.AppendLine("DescripcionAuditoria, FechaAuditoria, IdCompra, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro,");
                    query.AppendLine("ac.IdUsuario, uc.IdPersona[IdPersonaUsuarioCompra], pc.NombreCompleto[NombreCompletoUsuarioCompra], pc.Documento[DocumentoUsuarioCompra]");
                    query.AppendLine("from AuditoriaCompra ac");
                    query.AppendLine("inner join Usuario ua on ac.IdUsuarioAuditoria = ua.IdUsuario");
                    query.AppendLine("inner join Persona pa on ua.IdUsuario = pa.IdPersona");
                    query.AppendLine("inner join Usuario uc on ac.IdUsuario = uc.IdUsuario");
                    query.AppendLine("inner join Persona pc on uc.IdPersona = pc.IdPersona");
                    query.AppendLine("inner join Proveedor pv on ac.IdProveedor = pv.IdProveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AuditoriaCompra oAuditoriaCompra = new AuditoriaCompra();
                        oAuditoriaCompra.IdAuditoriaCompra = Convert.ToInt32(dr["IdAuditoriaCompra"]);
                        oAuditoriaCompra.oUsuarioAuditoria = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuarioAuditoria"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioAuditoria"]), NombreCompleto = dr["NombreCompletoUsuarioAuditoria"].ToString(), Documento = dr["DocumentoUsuarioAuditoria"].ToString() };
                        oAuditoriaCompra.oProveedor = new Proveedor { IdProveedor = Convert.ToInt32(dr["IdProveedor"]), RazonSocial = dr["RazonSocial"].ToString(), CUIT = dr["CUIT"].ToString(), Correo = dr["Correo"].ToString() };
                        oAuditoriaCompra.DescripcionAuditoria = dr["DescripcionAuditoria"].ToString();
                        oAuditoriaCompra.FechaAuditoria = dr["FechaAuditoria"].ToString();
                        oAuditoriaCompra.IdCompra = Convert.ToInt32(dr["IdCompra"]);
                        oAuditoriaCompra.TipoDocumento = dr["TipoDocumento"].ToString();
                        oAuditoriaCompra.NumeroDocumento = dr["NumeroDocumento"].ToString();
                        oAuditoriaCompra.MontoTotal = Convert.ToDecimal(dr["MontoTotal"]);
                        oAuditoriaCompra.FechaRegistro = dr["FechaRegistro"].ToString();
                        oAuditoriaCompra.oUsuarioCompra = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioCompra"]), NombreCompleto = dr["NombreCompletoUsuarioCompra"].ToString(), Documento = dr["DocumentoUsuarioCompra"].ToString() };

                        oListaAuditoriaCompras.Add(oAuditoriaCompra);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaAuditoriaCompras;
        }

        public AuditoriaCompra ObtenerAuditoriaCompra (int idAuditoriaCompra)
        {
            AuditoriaCompra oAuditoriaCompra = new AuditoriaCompra();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select");
                    query.AppendLine("ac.IdAuditoriaCompra,");
                    query.AppendLine("ac.IdUsuarioAuditoria, ua.IdPersona[IdPersonaUsuarioAuditoria], pa.NombreCompleto[NombreCompletoUsuarioAuditoria], pa.Documento[DocumentoUsuarioAuditoria],");
                    query.AppendLine("ac.IdProveedor, pv.RazonSocial, pv.CUIT, pv.Correo,");
                    query.AppendLine("DescripcionAuditoria, FechaAuditoria, IdCompra, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro,");
                    query.AppendLine("ac.IdUsuario, uc.IdPersona[IdPersonaUsuarioCompra], pc.NombreCompleto[NombreCompletoUsuarioCompra], pc.Documento[DocumentoUsuarioCompra]");
                    query.AppendLine("from AuditoriaCompra ac");
                    query.AppendLine("inner join Usuario ua on ac.IdUsuarioAuditoria = ua.IdUsuario");
                    query.AppendLine("inner join Persona pa on ua.IdUsuario = pa.IdPersona");
                    query.AppendLine("inner join Usuario uc on ac.IdUsuario = uc.IdUsuario");
                    query.AppendLine("inner join Persona pc on uc.IdPersona = pc.IdPersona");
                    query.AppendLine("inner join Proveedor pv on ac.IdProveedor = pv.IdProveedor");
                    query.AppendLine("where ac.IdAuditoriaCompra = @idAuditoriaCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idAuditoriaCompra", idAuditoriaCompra);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oAuditoriaCompra = new AuditoriaCompra()
                            {
                                IdAuditoriaCompra = Convert.ToInt32(dr["IdAuditoriaCompra"]),
                                oUsuarioAuditoria = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuarioAuditoria"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioAuditoria"]), NombreCompleto = dr["NombreCompletoUsuarioAuditoria"].ToString(), Documento = dr["DocumentoUsuarioAuditoria"].ToString() },
                                oProveedor = new Proveedor { IdProveedor = Convert.ToInt32(dr["IdProveedor"]), RazonSocial = dr["RazonSocial"].ToString(), CUIT = dr["CUIT"].ToString(), Correo = dr["Correo"].ToString() },
                                DescripcionAuditoria = dr["DescripcionAuditoria"].ToString(),
                                FechaAuditoria = dr["FechaAuditoria"].ToString(),
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                oUsuarioCompra = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersonaUsuarioCompra"]), NombreCompleto = dr["NombreCompletoUsuarioCompra"].ToString(), Documento = dr["DocumentoUsuarioCompra"].ToString() },
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
            return oAuditoriaCompra;
        }

        public List<AuditoriaDetalleCompra> ObtenerAuditoriaDetalleCompra (int idAuditoriaCompra)
        {
            List<AuditoriaDetalleCompra> oListaAuditoriaDetalleCompra = new List<AuditoriaDetalleCompra>();

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    CD_Conexion.ObtenerConexion();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre,");
                    query.AppendLine("adc.DescripcionAuditoria, adc.FechaAuditoria,");
                    query.AppendLine("adc.PrecioCompra, adc.Cantidad, adc.MontoTotal");
                    query.AppendLine("from AuditoriaDetalleCompra adc");
                    query.AppendLine("inner join Producto p on p.IdProducto = adc.IdProducto");
                    query.AppendLine("where adc.IdAuditoriaCompra = @idAuditoriaCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idAuditoriaCompra", idAuditoriaCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaAuditoriaDetalleCompra.Add(new AuditoriaDetalleCompra()
                            {
                                DescripcionAuditoria = dr["DescripcionAuditoria"].ToString(),
                                FechaAuditoria = dr["FechaAuditoria"].ToString(),
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"])
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
            return oListaAuditoriaDetalleCompra;
        }
    }
}
