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
    public class CC_Compra
    {
        private CD_Compra oCD_Compra = new CD_Compra();

        public List<Compra> ListarCompras()
        {
            try
            {
                return oCD_Compra.ListarCompras();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerCorrelativo()
        {
            return oCD_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra oCompra, DataTable oDetalleCompra, out string Mensaje)
        {
            return oCD_Compra.AgregarCompra(oCompra, oDetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra oCompra = oCD_Compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<DetalleCompra> oDetalleCompra = oCD_Compra.ObtenerDetalleCompra(oCompra.IdCompra);
                oCompra.oDetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }

        public bool EliminarCompra(int idCompra, out string mensaje)
        {
            try
            {
                return oCD_Compra.EliminarCompra(idCompra, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
