using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_AuditoriaSesion
    {
        private CD_AuditoriaSesion oCD_AuditoriaSesion = new CD_AuditoriaSesion();

        public List<AuditoriaSesion> ListarAuditoriaSesiones()
        {
            try
            {
                return oCD_AuditoriaSesion.ListarAuditoriaSesiones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RegistrarAuditoriaSesion(AuditoriaSesion oAuditoriaSesion, out string mensaje)
        {
            try
            {
                return oCD_AuditoriaSesion.RegistrarAuditoriaSesion(oAuditoriaSesion, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
