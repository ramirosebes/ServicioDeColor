using CapaControladora;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleAuditoriaSesion : Form
    {
        public int _idAuditoriaSesion;
        private CC_AuditoriaSesion oCC_AuditoriaSesion = new CC_AuditoriaSesion();

        public mdDetalleAuditoriaSesion(int idAuditoriaSesion)
        {
            _idAuditoriaSesion = idAuditoriaSesion;
            InitializeComponent();
        }

        private void mdDetalleAuditoriaSesion_Load(object sender, EventArgs e)
        {
            AuditoriaSesion oAuditoriaSesion = oCC_AuditoriaSesion.ListarAuditoriaSesiones().Where(a => a.IdAuditoriaSesion == _idAuditoriaSesion).FirstOrDefault();

            if (oAuditoriaSesion != null)
            {
                textBoxDescripcionAuditoria.Text = oAuditoriaSesion.DescripcionAuditoria;
                textBoxFechaAuditoria.Text = oAuditoriaSesion.FechaAuditoria;
                textBoxIdUsuario.Text = oAuditoriaSesion.oUsuario.IdUsuario.ToString();
                textBoxIdPersona.Text = oAuditoriaSesion.oUsuario.IdPersona.ToString();
                textBoxNombreCompleto.Text = oAuditoriaSesion.oUsuario.NombreCompleto;
                textBoxDocumento.Text = oAuditoriaSesion.oUsuario.Documento;
                textBoxCorreo.Text = oAuditoriaSesion.oUsuario.Correo;
                textBoxEstado.Text = oAuditoriaSesion.oUsuario.Estado.ToString();
            }
            else
            {
                MessageBox.Show("No se encontro el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
