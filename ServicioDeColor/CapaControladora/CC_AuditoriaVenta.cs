using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_AuditoriaVenta
    {
        private CD_AuditoriaVenta oCD_AuditoriaVenta = new CD_AuditoriaVenta();

        public List<AuditoriaVenta> ListarAuditoriaVentas()
        {
            try
            {
                return oCD_AuditoriaVenta.ListarAuditoriaVentas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AuditoriaVenta ObtenerAuditoriaVenta(int idAuditoriaVenta)
        {
            try
            {
                AuditoriaVenta oAuditoriaVenta = oCD_AuditoriaVenta.ObtenerAuditoriaVenta(idAuditoriaVenta);

                if (oAuditoriaVenta.IdAuditoriaVenta != 0)
                {
                    List<AuditoriaDetalleVenta> oAuditoriaDetalleVenta = oCD_AuditoriaVenta.ObtenerAuditoriaDetalleVenta(oAuditoriaVenta.IdAuditoriaVenta);
                    oAuditoriaVenta.oAuditoriaDetalleVenta = oAuditoriaDetalleVenta;
                }
                return oAuditoriaVenta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
