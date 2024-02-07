using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Reporte
    {
        private CD_Reporte oCD_Reporte = new CD_Reporte();

        public List<ReporteCompra> ListarReporteCompras(string fechaInicio, string fechaFin, int idProveedor)
        {
            try
            {
                return oCD_Reporte.ListarReporteCompras(fechaInicio, fechaFin, idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReporteVenta> ListarReporteVentas(string fechaInicio, string fechaFin, int idCliente)
        {
            try
            {
                return oCD_Reporte.ListarReporteVentas(fechaInicio, fechaFin, idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
