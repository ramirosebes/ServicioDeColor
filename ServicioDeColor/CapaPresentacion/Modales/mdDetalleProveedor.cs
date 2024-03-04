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
    public partial class mdDetalleProveedor : Form
    {
        private readonly string _tipoModal;
        private int _idProveedor;
        private Proveedor _oProveedor;
        private CC_Proveedor oCC_Proveedor = new CC_Proveedor();
        public int idProveedor { get; set; }

        public mdDetalleProveedor(string tipoModal, int idProveedor)
        {
            _idProveedor = idProveedor;
            _tipoModal = tipoModal;
            _oProveedor = oCC_Proveedor.ListarProveedores().Where(p => p.IdProveedor == _idProveedor).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleProveedor_Load(object sender, EventArgs e)
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
                    AgregarProveedor();
                    break;
                case "Editar":
                    EditarProveedor();
                    break;
            }
        }

        private void AgregarProveedor()
        {
            Proveedor proveedor = new Proveedor()
            {
                CUIT = textBoxCUIT.Text.Trim(),
                RazonSocial = textBoxRazonSocial.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idClienteRegistrado = oCC_Proveedor.AgregarProveedor(proveedor, out string mensaje);

            if (idClienteRegistrado != 0)
            {
                MessageBox.Show("Proveedor agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                idProveedor = idClienteRegistrado;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProveedor()
        {
            bool proveedorEditado = oCC_Proveedor.EditarProveedor(new Proveedor()
            {
                IdProveedor = _idProveedor,
                CUIT = textBoxCUIT.Text.Trim(),
                RazonSocial = textBoxRazonSocial.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                Telefono = textBoxTelefono.Text.Trim(),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, out string mensaje);

            if (proveedorEditado)
            {
                MessageBox.Show("Proveedor editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBoxCUIT.Enabled = false;
            textBoxRazonSocial.Enabled = false;
            textBoxCorreo.Enabled = false;
            comboBoxEstado.Enabled = false;
            textBoxTelefono.Enabled = false;
            buttonConfirmar.Visible = false;

            textBoxCUIT.Text = _oProveedor.CUIT.ToString();
            textBoxRazonSocial.Text = _oProveedor.RazonSocial.ToString();
            textBoxCorreo.Text = _oProveedor.Correo.ToString();
            textBoxTelefono.Text = _oProveedor.Telefono.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oProveedor.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }

        private void ConfigurarAgregar()
        {
            this.Text = "Agregar proveedor";
            labelSubTitulo.Text = "Agregar proveedor";
            buttonConfirmar.Text = "Agregar";
        }

        private void ConfigurarEditar()
        {
            this.Text = "Editar proveedor";
            labelSubTitulo.Text = "Editar proveedor";
            buttonConfirmar.Text = "Editar";

            textBoxCUIT.Text = _oProveedor.CUIT.ToString();
            textBoxRazonSocial.Text = _oProveedor.RazonSocial.ToString();
            textBoxCorreo.Text = _oProveedor.Correo.ToString();
            textBoxTelefono.Text = _oProveedor.Telefono.ToString();
            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oProveedor.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxCUIT_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verificar la longitud del texto
            if (textBox.Text.Length < 10 || textBox.Text.Length > 11)
            {
                MessageBox.Show("El CUIT no tiene un formato valido\n" + "Debe tener entre 10 y 11 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus(); // Devolver el foco al TextBox
                textBox.SelectAll(); // Seleccionar todo el texto para facilitar la corrección
            }
        }

        private void textBoxCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void textBoxCUIT_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxTelefono_KeyDown(object sender, KeyEventArgs e)
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
