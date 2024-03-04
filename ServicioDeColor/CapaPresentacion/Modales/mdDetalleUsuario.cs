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
using System.Text.RegularExpressions;

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
            if (!Validaciones.ValidarCamposVacios(panelClave.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            panelButtons.Size = new Size(460, 54);
            panelButtons.Location = new Point(12, 259);
            buttonVolver.Location = new Point(190, 13);
            this.Size = new Size(500, 360);
            this.MinimumSize = new Size(500, 360);
            this.MaximumSize = new Size(500, 360);
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

            this.Size = new Size(500, 400);
            this.MinimumSize = new Size(500, 400);
            this.MaximumSize = new Size(500, 400);
            panelButtons.Location = new Point(12, 259);
        }
        private void ConfigurarRestablecerClave()
        {
            this.Text = "Restablecer Clave";
            labelSubTitulo.Text = "Restablecer Clave";

            panelClave.Visible = true;
            buttonConfirmar.Text = "Restablecer Clave";
            panelContenedor.Visible = false;

            //panelClave.BringToFront();
            //panelClave.Location = new Point(13, 160);
            //buttonConfirmar.BringToFront();

            //textBoxNombreCompleto.Visible = false;
            //textBoxCorreo.Visible = false;
            //textBoxDocumento.Visible = false;
            //comboBoxEstado.Visible = false;
            //labelNombreCompleto.Visible = false;
            //labelDocumento.Visible = false;
            //labelCorreo.Visible = false;
            //labelEstado.Visible = false;

            buttonConfirmar.Text = "Restablecer clave";

            this.Size = new Size(500, 330);
            this.MinimumSize = new Size(500, 330);
            this.MaximumSize = new Size(500, 330);
            panelClave.Location = new Point(12, 107);
            panelButtons.Location = new Point(12, 189);
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
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
{
                e.Handled = true;
            }
        }

        private void textBoxNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            // Expresión regular para validar la dirección de correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Se verifica si el texto del TextBox coincide con el patrón de la expresión regular
            if (!Regex.IsMatch(textBoxCorreo.Text, pattern))
            {
                MessageBox.Show("El correo electronico no tiene un formato valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCorreo.Focus(); // Devolver el foco al TextBox
                textBoxCorreo.SelectAll(); // Seleccionar todo el texto para facilitar la corrección
            }
        }

        private void textBoxDocumento_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verificar la longitud del texto
            if (textBox.Text.Length < 7 || textBox.Text.Length > 8)
            {
                MessageBox.Show("El documento no tiene un formato valido\n" + "Debe tener entre 7 y 8 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus(); // Devolver el foco al TextBox
                textBox.SelectAll(); // Seleccionar todo el texto para facilitar la corrección
            }
        }

        private void textBoxDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxNombreCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }
    }
}
