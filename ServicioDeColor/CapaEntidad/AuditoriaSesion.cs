using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AuditoriaSesion
    {
        #region Variables Privadas
        private int idAuditoriaSesionl;
        private Usuario usuario;
        private string descripcionAuditoria;
        private string fechaAuditoria;
        #endregion

        #region Propiedades
        public int IdAuditoriaSesion { get { return idAuditoriaSesionl; } set { idAuditoriaSesionl = value; } }
        public Usuario oUsuario { get { return usuario; } set { usuario = value; } }
        public string DescripcionAuditoria { get { return descripcionAuditoria; } set { descripcionAuditoria = value; } }
        public string FechaAuditoria { get { return fechaAuditoria; } set { fechaAuditoria = value; } }
        #endregion
    }
}
