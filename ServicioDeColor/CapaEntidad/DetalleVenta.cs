using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        #region Variables Privadas
        private int idDetalleVenta;
        //private Venta venta;
        private Producto producto;
        private decimal precioVenta;
        private int cantidad;
        private decimal subTotal;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdDetalleVenta { get { return idDetalleVenta; } set { idDetalleVenta = value; } }
        //public Venta oVenta { get { return venta; } set { venta = value; } }
        public Producto oProducto { get { return producto; } set { producto = value; } }
        public decimal PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public decimal SubTotal { get { return subTotal; } set { subTotal = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
