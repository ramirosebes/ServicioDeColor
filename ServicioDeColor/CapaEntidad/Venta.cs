using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        #region Variables Privadas
        private int idVenta;
        private Usuario usuario;
        private Cliente cliente;
        private string tipoDocumento;
        private string numeroDocumento;
        private decimal montoPago;
        private decimal montoCambio;
        private decimal montoTotal;
        private List<DetalleVenta> detalleVenta;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdVenta { get { return idVenta; } set { idVenta = value; } }
        public Usuario oUsuario { get { return usuario; } set { usuario = value; } }
        public Cliente oCliente { get { return cliente; } set { cliente = value; } }
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }
        public decimal MontoPago { get { return montoPago; } set { montoPago = value; } }
        public decimal MontoCambio { get { return montoCambio; } set { montoCambio = value; } }
        public decimal MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public List<DetalleVenta> oDetalleVenta { get { return detalleVenta; } set { detalleVenta = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
