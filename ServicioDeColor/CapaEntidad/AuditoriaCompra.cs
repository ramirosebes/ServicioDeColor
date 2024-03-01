using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaCompra
    {
        #region Variables Privadas
        private int idAuditoriaCompra;
        private Usuario usuarioAuditoria;
        private string descripcionAuditoria;
        private string fechaAuditoria;
        private int idCompra;
        private Usuario usuarioCompra;
        private Proveedor proveedor;
        private string tipoDocumento;
        private string numeroDocumento;
        private decimal montoTotal;
        private List<AuditoriaDetalleCompra> auditoriaDetalleCompra;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdAuditoriaCompra { get { return idAuditoriaCompra; } set { idAuditoriaCompra = value; } }
        public Usuario oUsuarioAuditoria { get { return usuarioAuditoria; } set { usuarioAuditoria = value; } }
        public string DescripcionAuditoria { get { return descripcionAuditoria; } set { descripcionAuditoria = value; } }
        public string FechaAuditoria { get { return fechaAuditoria; } set { fechaAuditoria = value; } }
        public int IdCompra { get { return idCompra; } set { idCompra = value; } }
        public Usuario oUsuarioCompra { get { return usuarioCompra; } set { usuarioCompra = value; } }
        public Proveedor oProveedor { get { return proveedor; } set { proveedor = value; } }
        public string TipoDocumento { get { return tipoDocumento; } set { tipoDocumento = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }
        public decimal MontoTotal { get { return montoTotal; } set { montoTotal = value; } }
        public List<AuditoriaDetalleCompra> oAuditoriaDetalleCompra { get { return auditoriaDetalleCompra; } set { auditoriaDetalleCompra = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
