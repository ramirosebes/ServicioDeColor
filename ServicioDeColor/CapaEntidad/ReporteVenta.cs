using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {
        #region Variables Privadas.
        private string fechaRegistro;
        private string tipoDocumento;
        private string numeroDocumento;
        private string montoTotal;
        private string usuarioRegistro;
        private string documentoCliente;
        private string nombreCliente;
        private string codigoProducto;
        private string nombreProducto;
        private string categoria;
        private string precioVenta;
        private string cantidad;
        private string subTotal;
        private string tipoDescuento;
        private string montoDescuento;
        #endregion

        #region Propiedades
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }
        public string MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public string UsuarioRegistro { get { return usuarioRegistro; } set { usuarioRegistro = value; } }
        public string DocumentoCliente { get { return documentoCliente; } set { documentoCliente = value; } }
        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public string CodigoProducto { get { return codigoProducto; } set { codigoProducto = value; } }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public string Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string SubTotal { get { return subTotal; } set { subTotal = value; } }
        public string TipoDescuento { get { return tipoDescuento; } set { tipoDescuento = value; } }
        public string MontoDescuento { get { return montoDescuento; } set { montoDescuento = value; } }
        #endregion
    }
}
