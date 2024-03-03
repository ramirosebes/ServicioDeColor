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
    public class CD_AuditoriaSesion
    {
        public List<AuditoriaSesion> ListarAuditoriaSesiones()
        {
            List<AuditoriaSesion> oListaAuditoriaSesiones =  new List<AuditoriaSesion>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select");
                    query.AppendLine("sa.IdAuditoriaSesion,");
                    query.AppendLine("sa.IdUsuario, u.Estado, p.IdPersona, p.NombreCompleto, p.Documento, p.Correo,");
                    query.AppendLine("sa.DescripcionAuditoria, sa.FechaAuditoria");
                    query.AppendLine("from AuditoriaSesion sa");
                    query.AppendLine("inner join Usuario u on sa.IdUsuario = u.IdUsuario");
                    query.AppendLine("inner join Persona p on u.IdPersona = p.IdPersona");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AuditoriaSesion oAuditoriaSesion = new AuditoriaSesion();
                        oAuditoriaSesion.IdAuditoriaSesion = Convert.ToInt32(dr["IdAuditoriaSesion"]);
                        oAuditoriaSesion.oUsuario = new Usuario { IdUsuario = Convert.ToInt32(dr["IdUsuario"]), IdPersona = Convert.ToInt32(dr["IdPersona"]), NombreCompleto = dr["NombreCompleto"].ToString(), Documento = dr["Documento"].ToString(), Correo = dr["Correo"].ToString(), Estado = Convert.ToBoolean(dr["Estado"]) };
                        oAuditoriaSesion.DescripcionAuditoria = dr["DescripcionAuditoria"].ToString();
                        oAuditoriaSesion.FechaAuditoria = dr["FechaAuditoria"].ToString();

                        oListaAuditoriaSesiones.Add(oAuditoriaSesion);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return oListaAuditoriaSesiones;
        }

        public bool RegistrarAuditoriaSesion(AuditoriaSesion oAuditoriaSesion, out string mensaje)
        {
            bool auditoriaSesionRegistrada = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarSesion", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdUsuario", oAuditoriaSesion.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("DescripcionAuditoria", oAuditoriaSesion.DescripcionAuditoria);

                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    auditoriaSesionRegistrada = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    auditoriaSesionRegistrada = false;
                    mensaje = ex.Message;
                }
            }
            CD_Conexion.CerrarConexion();
            return auditoriaSesionRegistrada;
        }
    }
}
