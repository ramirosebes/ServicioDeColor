using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Venta
    {
        private CD_Venta oCD_Venta = new CD_Venta();

        public List<Venta> ListarVentas()
        {
            try
            {
                return oCD_Venta.ListarVentas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int ObtenerCorrelativo()
        {
            try
            {
                return oCD_Venta.ObtenerCorrelativo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RestarStock(int idProducto, int cantidad)
        {
            try
            {
                return oCD_Venta.RestarStock(idProducto, cantidad);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            try
            {
                return oCD_Venta.SumarStock(idProducto, cantidad);
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarVenta(Venta oVenta, DataTable oDetalleVenta, out string mensaje)
        {
            try
            {
                return oCD_Venta.AgregarVenta(oVenta, oDetalleVenta, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Venta ObtenerVenta(string numero)
        {
            try
            {
                Venta oVenta = oCD_Venta.ObtenerVenta(numero);

                if (oVenta.IdVenta != 0)
                {
                    List<DetalleVenta> oDetalleVenta = oCD_Venta.ObtenerDetalleVenta(oVenta.IdVenta);
                    oVenta.oDetalleVenta = oDetalleVenta;
                }
                return oVenta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarVenta(int idVenta, out string mensaje)
        {
            try
            {
                return oCD_Venta.EliminarVenta(idVenta, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }    
}
