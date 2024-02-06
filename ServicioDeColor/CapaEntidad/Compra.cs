using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        #region Variables Privadas
        private int idCompra;
        private Usuario usuario;
        //private Persona persona;
        private Proveedor proveedor;
        private string tipoDocumento;
        private string numeroDocumento;
        private decimal montoTotal;
        private List<DetalleCompra> detalleCompra;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdCompra { get { return idCompra; } set { idCompra = value; } }
        public Usuario oUsuario { get { return usuario; } set { usuario = value; } }
        //public Persona oPersona { get { return persona; } set { persona = value; } }
        public Proveedor oProveedor { get { return proveedor; } set { proveedor = value; } }
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }
        public decimal MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public List<DetalleCompra> oDetalleCompra { get { return detalleCompra; } set { detalleCompra = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
