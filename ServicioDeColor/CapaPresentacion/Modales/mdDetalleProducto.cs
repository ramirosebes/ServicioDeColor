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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleProducto : Form
    {
        private readonly string _tipoModal;
        private int _idProducto;
        private Producto _oProducto;
        private CC_Producto oCC_Producto = new CC_Producto();
        public int idProducto { get; set; }
        private CC_Categoria oCC_Categoria = new CC_Categoria();

        public mdDetalleProducto(string tipoModal, int idProducto)
        {
            _idProducto = idProducto;
            _tipoModal = tipoModal;
            _oProducto = oCC_Producto.ListarProductos().Where(p => p.IdProducto == _idProducto).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetalleProducto_Load(object sender, EventArgs e)
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
                    AgregarProducto();
                    break;
                case "Editar":
                    EditarProducto();
                    break;
            }
        }

        private void AgregarProducto()
        {
            Producto producto = new Producto()
            {
                Codigo = textBoxCodigo.Text.Trim(),
                Nombre = textBoxNombre.Text.Trim(),
                Descripcion = richTextBoxDescripcion.Text.Trim(),
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)comboBoxCategoria.SelectedItem).Valor) },
                Stock = Convert.ToInt32(textBoxStock.Text.Trim()),
                PrecioCompra = Convert.ToDecimal(textBoxPrecioCompra.Text.Trim()),
                PrecioVenta = Convert.ToDecimal(textBoxPrecioVenta.Text.Trim()),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            };

            int idProductoRegistrado = oCC_Producto.AgregarProducto(producto, out string mensaje);

            if (idProductoRegistrado != 0)
            {
                MessageBox.Show("Producto agregado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                idProducto = idProductoRegistrado;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProducto()
        {
            bool productoEditado = oCC_Producto.EditarProducto(new Producto()
            {
                IdProducto = _idProducto,
                Codigo = textBoxCodigo.Text.Trim(),
                Nombre = textBoxNombre.Text.Trim(),
                Descripcion = richTextBoxDescripcion.Text.Trim(),
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)comboBoxCategoria.SelectedItem).Valor) },
                Stock = Convert.ToInt32(textBoxStock.Text.Trim()),
                PrecioCompra = Convert.ToDecimal(textBoxPrecioCompra.Text.Trim()),
                PrecioVenta = Convert.ToDecimal(textBoxPrecioVenta.Text.Trim()),
                Estado = Convert.ToInt32(((OpcionCombo)comboBoxEstado.SelectedItem).Valor) == 1 ? true : false
            }, out string mensaje);

            if (productoEditado)
            {
                MessageBox.Show("Producto editado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //comboBoxEstado
            comboBoxEstado.Items.Add(new OpcionCombo(1, "Activo"));
            comboBoxEstado.Items.Add(new OpcionCombo(0, "Inactivo"));
            comboBoxEstado.SelectedIndex = 0;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            //comboBoxEstado
            List<Categoria> listaCategorias = oCC_Categoria.ListarCategorias();
            //listaCategorias = listaCategorias.OrderBy(p => p.Descripcion).ToList();

            foreach (Categoria item in listaCategorias)
            {
                comboBoxCategoria.Items.Add(new OpcionCombo(item.IdCategoria, item.Descripcion));
            }
            comboBoxCategoria.DisplayMember = "Texto";
            comboBoxCategoria.ValueMember = "Valor";
            comboBoxCategoria.SelectedIndex = 0;

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
            textBoxCodigo.Enabled = false;
            textBoxNombre.Enabled = false;
            richTextBoxDescripcion.Enabled = false;
            textBoxStock.Enabled = false;
            textBoxPrecioCompra.Enabled = false;
            textBoxPrecioVenta.Enabled = false;
            comboBoxEstado.Enabled = false;
            comboBoxCategoria.Enabled = false;
            buttonConfirmar.Visible = false;
            
            textBoxCodigo.Text = _oProducto.Codigo.ToString();
            textBoxNombre.Text = _oProducto.Nombre.ToString();
            richTextBoxDescripcion.Text = _oProducto.Descripcion.ToString();
            textBoxStock.Text = _oProducto.Stock.ToString();
            textBoxPrecioCompra.Text = _oProducto.PrecioCompra.ToString();
            textBoxPrecioVenta.Text = _oProducto.PrecioVenta.ToString();

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oProducto.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }
            
            foreach (OpcionCombo opcion in comboBoxCategoria.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == _oProducto.oCategoria.IdCategoria)
                {
                    int indiceCombo = comboBoxCategoria.Items.IndexOf(opcion);
                    comboBoxCategoria.SelectedIndex = indiceCombo;
                    break;
                }
            }
        }

        private void ConfigurarAgregar()
        {
            this.Text = "Agregar producto";
            labelSubTitulo.Text = "Agregar producto";
            buttonConfirmar.Text = "Agregar";
        }

        private void ConfigurarEditar()
        {
            this.Text = "Editar producto";
            labelSubTitulo.Text = "Editar producto";
            buttonConfirmar.Text = "Editar";

            textBoxCodigo.Text = _oProducto.Codigo.ToString();
            textBoxNombre.Text = _oProducto.Nombre.ToString();
            richTextBoxDescripcion.Text = _oProducto.Descripcion.ToString();
            textBoxStock.Text = _oProducto.Stock.ToString();
            textBoxPrecioCompra.Text = _oProducto.PrecioCompra.ToString();
            textBoxPrecioVenta.Text = _oProducto.PrecioVenta.ToString();

            foreach (OpcionCombo opcion in comboBoxEstado.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == (_oProducto.Estado == true ? 1 : 0))
                {
                    int indiceCombo = comboBoxEstado.Items.IndexOf(opcion);
                    comboBoxEstado.SelectedIndex = indiceCombo;
                    break;
                }
            }

            foreach (OpcionCombo opcion in comboBoxCategoria.Items)
            {
                if (Convert.ToInt32(opcion.Valor) == _oProducto.oCategoria.IdCategoria)
                {
                    int indiceCombo = comboBoxCategoria.Items.IndexOf(opcion);
                    comboBoxCategoria.SelectedIndex = indiceCombo;
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

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecioCompra.Text.Length > 0 && !textBoxPrecioCompra.Text.Contains("."))
            {
                // Permitir un punto si hay al menos un número y no hay punto previamente
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }

        private void textBoxPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecioVenta.Text.Length > 0 && !textBoxPrecioVenta.Text.Contains("."))
            {
                // Permitir un punto si hay al menos un número y no hay punto previamente
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }

        private void textBoxStock_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica si la longitud del texto es mayor que 50
            if (textBox.Text.Length > 50)
            {
                // Si es mayor, truncamos el texto a 50 caracteres
                textBox.Text = textBox.Text.Substring(0, 50);
                // Establecemos el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica si la longitud del texto es mayor que 50
            if (textBox.Text.Length > 50)
            {
                // Si es mayor, truncamos el texto a 50 caracteres
                textBox.Text = textBox.Text.Substring(0, 50);
                // Establecemos el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = (RichTextBox)sender;

            // Verifica si la longitud del texto es mayor que 50
            if (richTextBox.Text.Length > 50)
            {
                // Si es mayor, truncamos el texto a 100 caracteres
                richTextBox.Text = richTextBox.Text.Substring(0, 50);
                // Establecemos el cursor al final del texto
                richTextBox.SelectionStart = richTextBox.Text.Length;
            }
        }
    }
}
