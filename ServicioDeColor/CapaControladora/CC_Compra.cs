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
            try
            {
                return oCD_Compra.ObtenerCorrelativo();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AgregarCompra(Compra oCompra, DataTable oDetalleCompra, out string Mensaje)
        {
            try
            {
                return oCD_Compra.AgregarCompra(oCompra, oDetalleCompra, out Mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Compra ObtenerCompra(string numero)
        {
            try
            {
                Compra oCompra = oCD_Compra.ObtenerCompra(numero);

                if (oCompra.IdCompra != 0)
                {
                    List<DetalleCompra> oDetalleCompra = oCD_Compra.ObtenerDetalleCompra(oCompra.IdCompra);
                    oCompra.oDetalleCompra = oDetalleCompra;
                }
                return oCompra;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarCompra(int idCompra, int idUsuario,out string mensaje)
        {
            try
            {
                return oCD_Compra.EliminarCompra(idCompra, idUsuario, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
