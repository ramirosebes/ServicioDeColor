using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_AuditoriaCompra
    {
        private CD_AuditoriaCompra oCD_AuditoriaCompra = new CD_AuditoriaCompra();

        public List<AuditoriaCompra> ListarAuditoriaCompras()
        {
            try
            {
                return oCD_AuditoriaCompra.ListarAuditoriaCompras();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AuditoriaCompra ObtenerAuditoriaCompra(int idAuditoriaCompra)
        {
            try
            {
                AuditoriaCompra oAuditoriaCompra = oCD_AuditoriaCompra.ObtenerAuditoriaCompra(idAuditoriaCompra);

                if (oAuditoriaCompra.IdAuditoriaCompra != 0)
                {
                    List<AuditoriaDetalleCompra> oAuditoriaDetalleCompra = oCD_AuditoriaCompra.ObtenerAuditoriaDetalleCompra(oAuditoriaCompra.IdAuditoriaCompra);
                    oAuditoriaCompra.oAuditoriaDetalleCompra = oAuditoriaDetalleCompra;
                }
                return oAuditoriaCompra;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
