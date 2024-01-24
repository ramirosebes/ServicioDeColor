using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        #region Variables Privadas
        private int idDetalleCompra;
        //private Compra compra;
        private Producto producto;
        private decimal precioCompra;
        private decimal precioVenta;
        private int cantidad;
        private decimal montoTotal;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdDetalleCompra { get { return idDetalleCompra; } set { idDetalleCompra = value; } }
        //public Compra oCompra { get { return compra; } set { compra = value; } }
        public Producto oProducto { get { return producto; } set { producto = value; } }
        public decimal PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public decimal PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public decimal MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
