using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaDetalleVenta
    {
        #region Variables Privadas
        private int idAuditoriaDetalleVenta;
        //private int idAuditoriaVenta;
        private string descripcionAuditoria;
        private string fechaAuditoria;
        private Producto producto;
        private decimal precioVenta;
        private int cantidad;
        private decimal subTotal;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdAuditoriaDetalleVenta { get { return idAuditoriaDetalleVenta; } set { idAuditoriaDetalleVenta = value; } }
        //public int IdAuditoriaVenta { get { return idAuditoriaVenta; } set { idAuditoriaVenta = value; } }
        public string DescripcionAuditoria { get { return descripcionAuditoria; } set { descripcionAuditoria = value; } }
        public string FechaAuditoria { get { return fechaAuditoria; } set { fechaAuditoria = value; } }
        public Producto oProducto { get { return producto; } set { producto = value; } }
        public decimal PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public decimal SubTotal { get { return subTotal; } set { subTotal = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
