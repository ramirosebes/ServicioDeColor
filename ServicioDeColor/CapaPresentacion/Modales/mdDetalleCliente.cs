using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleCliente : Form
    {
        private readonly string _tipoModal;
        private int _idCliente;
        private Cliente _oCliente;
        private CC_Cliente oCC_Cliente = new CC_Cliente();
        public int idCliente { get; set; }

        public mdDetalleCliente(string tipoModal, int idCliente)
        {
            _idCliente = idCliente;
            _tipoModal = tipoModal;
            _oCliente = oCC_Cliente.ListarClientes().Where(c => c.IdCliente == _idCliente).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleCliente_Load(object sender, EventArgs e)
        {
            ConfigurarModal();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(panelContenedor.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_tipoModal)
            {
                case "Agregar":
                    AgregarCliente();
                    break;
                case "Editar":
                    EditarCliente();
                    break;
            }
        }

        private void AgregarCliente()
        {
            Cliente cliente = new Cliente()
            {
                Documento = textBoxDocumento.Text.Trim(),
                NombreCompleto = textBoxNombreCompleto.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                //Direccion = textBoxDireccion.Text.Trim(),
                //Localidad = textBoxLocalidad.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idClienteRegistrado = oCC_Cliente.AgregarCliente(cliente, out string mensaje);

            if (idClienteRegistrado != 0)
            {
                MessageBox.Show("Cliente agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                idCliente = idClienteRegistrado;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarCliente()
        {
            bool clienteEditado = oCC_Cliente.EditarCliente(new Cliente()
            {
                IdCliente = _idCliente,
                IdPersona = _oCliente.IdPersona,
                NombreCompleto = textBoxNombreCompleto.Text.Trim(),
                Documento = textBoxDocumento.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                //Direccion = textBoxDireccion.Text.Trim(),
                //Localidad = textBoxLocalidad.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, out string mensaje);

            if (clienteEditado)
            {
                MessageBox.Show("Cliente editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private void ConfigurarVerDetalle()
        {
            this.Text = "Ver Detalle";
            textBoxNombreCompleto.Enabled = false;
            textBoxDocumento.Enabled = false;
            textBoxCorreo.Enabled = false;
            comboBoxEstado.Enabled = false;
            textBoxTelefono.Enabled = false;
            //textBoxDireccion.Enabled = false;
            //textBoxLocalidad.Enabled = false;
            buttonConfirmar.Visible = false;

            textBoxNombreCompleto.Text = _oCliente.NombreCompleto.ToString();
            textBoxDocumento.Text = _oCliente.Documento.ToString();
            textBoxCorreo.Text = _oCliente.Correo.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oCliente.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
            textBoxTelefono.Text = _oCliente.Telefono.ToString();
            //textBoxDireccion.Text = _oCliente.Direccion.ToString();
            //textBoxLocalidad.Text = _oCliente.Localidad.ToString();
        }

        private void ConfigurarAgregar()
        {
            this.Text = "Agregar cliente";
            labelSubTitulo.Text = "Agregar cliente";
            buttonConfirmar.Text = "Agregar";
        }
        private void ConfigurarEditar()
        {
            this.Text = "Editar cliente";
            labelSubTitulo.Text = "Editar cliente";
            buttonConfirmar.Text = "Editar";

            textBoxNombreCompleto.Text = _oCliente.NombreCompleto.ToString();
            textBoxDocumento.Text = _oCliente.Documento.ToString();
            textBoxCorreo.Text = _oCliente.Correo.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oCliente.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
            textBoxTelefono.Text = _oCliente.Telefono.ToString();
            //textBoxDireccion.Text = _oCliente.Direccion.ToString();
            //textBoxLocalidad.Text = _oCliente.Localidad.ToString();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
    }
}
