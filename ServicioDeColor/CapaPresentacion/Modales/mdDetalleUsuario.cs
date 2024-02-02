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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleUsuario : Form
    {
        private readonly string _tipoModal;
        private int _idUsuario;
        private Usuario oUsuario;
        private CC_Usuario oCC_Usuario = new CC_Usuario();

        public mdDetalleUsuario(string tipoModal, int idUsuario)
        {
            _idUsuario = idUsuario;
            _tipoModal = tipoModal;
            oUsuario = oCC_Usuario.ListarUsuarios().Where(u => u.IdUsuario == _idUsuario).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarModal();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (_tipoModal != "RestablacerClave")
            {
                if (!Validaciones.ValidarCamposVacios(panelContenedor.Controls))
                {
                    MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (panelClave.Visible == true)
            {
                if (!Validaciones.ValidarClaves(textBoxClave.Text, textBoxConfirmarClave.Text))
                {
                    return;
                }
            }
            switch (_tipoModal)
            {
                case "Agregar":
                    AgregarUsuario();
                    break;
                case "Editar":
                    EditarUsuario();
                    break;
                case "RestablacerClave":
                    RestablecerClave();
                    break;
            }
        }

        private void AgregarUsuario()
        {
            string claveHash = Usuario.GenerarClaveHash(textBoxClave.Text);

            int idUsuarioRegistrado = oCC_Usuario.AgregarUsuario(new Usuario()
            {
                NombreCompleto = textBoxNombreCompleto.Text,
                Documento = textBoxDocumento.Text,
                Correo = textBoxCorreo.Text,
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, claveHash, out string mensaje);

            if (idUsuarioRegistrado > 0)
            {
                MessageBox.Show("Usuario registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarUsuario()
        {
            bool usuarioEditado = oCC_Usuario.EditarUsuario(new Usuario()
            {
                IdUsuario = _idUsuario,
                IdPersona = oUsuario.IdPersona,
                NombreCompleto = textBoxNombreCompleto.Text,
                Documento = textBoxDocumento.Text,
                Correo = textBoxCorreo.Text,
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, out string mensaje);

            if (usuarioEditado)
            {
                MessageBox.Show("Usuario editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestablecerClave()
        {
            string claveHash = Usuario.GenerarClaveHash(textBoxClave.Text);
            bool claveRestablecida = oCC_Usuario.RestablecerClave(_idUsuario, claveHash, out string mensaje);

            if (claveRestablecida)
            {
                MessageBox.Show("Clave restablecida correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarModal()
        {
            comboBoxEstado.Items.Add(new OpcionCombo(1, "Activo"));
            comboBoxEstado.Items.Add(new OpcionCombo(0, "Inactivo"));
            comboBoxEstado.SelectedIndex = 0;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            switch (_tipoModal)
            {
                case "VerDetalle":
                    ConfigurarVerDetalle();
                    break;
                case "Agregar":
                    ConfigurarAgregar();
                    break;
                case "Editar":
                    ConfigurarEditar();
                    break;
                case "RestablacerClave":
                    ConfigurarRestablecerClave();
                    break;
            }
        }

        private void ConfigurarVerDetalle()
        {
            this.Text = "Ver Detalle";
            textBoxNombreCompleto.Enabled = false;
            textBoxDocumento.Enabled = false;
            textBoxCorreo.Enabled = false;
            comboBoxEstado.Enabled = false;
            buttonConfirmar.Visible = false;

            textBoxNombreCompleto.Text = oUsuario.NombreCompleto.ToString();
            textBoxDocumento.Text = oUsuario.Documento.ToString();
            textBoxCorreo.Text = oUsuario.Correo.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (oUsuario.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }
        private void ConfigurarAgregar()
        {
            this.Text = "Agregar Usuario";
            labelSubTitulo.Text = "Agregar Usuario";
            panelClave.Visible = true;
            buttonConfirmar.Text = "Agregar";
        }
        private void ConfigurarEditar()
        {
            this.Text = "Editar Usuario";
            labelSubTitulo.Text = "Editar Usuario";
            buttonConfirmar.Text = "Editar";

            textBoxNombreCompleto.Text = oUsuario.NombreCompleto.ToString();
            textBoxDocumento.Text = oUsuario.Documento.ToString();
            textBoxCorreo.Text = oUsuario.Correo.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (oUsuario.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }
        private void ConfigurarRestablecerClave()
        {
            this.Text = "Restablecer Clave";
            labelSubTitulo.Text = "Restablecer Clave";

            panelClave.Visible = true;
            buttonConfirmar.Text = "Restablecer Clave";
            panelClave.BringToFront();
            panelClave.Location = new Point(13, 160);
            buttonConfirmar.BringToFront();

            textBoxNombreCompleto.Visible = false;
            textBoxCorreo.Visible = false;
            textBoxDocumento.Visible = false;
            comboBoxEstado.Visible = false;
            labelNombreCompleto.Visible = false;
            labelDocumento.Visible = false;
            labelCorreo.Visible = false;
            labelEstado.Visible = false;

            buttonConfirmar.Text = "Restablecer Contraseña";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonVerClave_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxClave.PasswordChar = '\0';
            textBoxConfirmarClave.PasswordChar = '\0';
        }

        private void buttonVerClave_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxClave.PasswordChar = '*';
            textBoxConfirmarClave.PasswordChar = '*';
        }

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
