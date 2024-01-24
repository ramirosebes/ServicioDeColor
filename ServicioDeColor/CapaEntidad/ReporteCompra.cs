using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteCompra
    {
        #region Variables Privadas
        private string fechaRegistro;
        private string tipoDocumento;
        private string numeroDocumento;
        private string montoTotal;
        private string usuarioRegistro;
        private string documentoProveedor;
        private string razonSocial;
        private string codigoProducto;
        private string nombreProducto;
        private string categoria;
        private string precioCompra;
        private string precioVenta;
        private string cantidad;
        private string subTotal;
        #endregion

        #region Propieades
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }
        public string MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public string UsuarioRegistro { get { return usuarioRegistro; } set { usuarioRegistro = value; } }
        public string DocumentoProveedor { get { return documentoProveedor; } set { documentoProveedor = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string CodigoProducto { get { return codigoProducto; } set { codigoProducto = value; } }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public string PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public string PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public string Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string SubTotal { get { return subTotal; } set { subTotal = value; } }
        #endregion
    }
}
