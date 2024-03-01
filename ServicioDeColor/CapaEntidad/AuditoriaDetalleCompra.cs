using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaDetalleCompra
    {
        #region Variables Privadas
        private int idAuditoriaDetalleCompra;
        //private int idAuditoriaCompra;
        private string descripcionAuditoria;
        private string fechaAuditoria;
        private Producto Producto;
        private decimal precioCompra;
        private decimal precioVenta;
        private int cantidad;
        private decimal montoTotal;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdAuditoriaDetalleCompra { get { return idAuditoriaDetalleCompra; } set { idAuditoriaDetalleCompra = value; } }
        //public int IdAuditoriaCompra { get { return idAuditoriaCompra; } set { idAuditoriaCompra = value; } }
        public string DescripcionAuditoria { get { return descripcionAuditoria; } set { descripcionAuditoria = value; } }
        public string FechaAuditoria { get { return fechaAuditoria; } set { fechaAuditoria = value; } }
        public Producto oProducto { get { return Producto; } set { Producto = value; } }
        public decimal PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public decimal PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public decimal MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
