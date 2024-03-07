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
    public partial class mdAgregarVenta : Form
    {
        private Usuario _usuarioActual;

        public mdAgregarVenta(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void mdAgregarVenta_Load(object sender, EventArgs e)
        {
            //CONFIGURACION DEL OPCION COMBO TIPO DOCUMENTO -- SE PUEDEN AGREGAR MAS COMO "CHEQUE"
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboBoxTipoDocumento.DisplayMember = "Texto";
            comboBoxTipoDocumento.ValueMember = "Valor";
            comboBoxTipoDocumento.SelectedIndex = 0;

            //CONFIGURACION DESCUENTO
            comboBoxDescuento.Items.Add(new OpcionCombo() { Valor = "SinDescuento", Texto = "Sin descuento" });
            comboBoxDescuento.Items.Add(new OpcionCombo() { Valor = "Fijo", Texto = "Fijo" });
            comboBoxDescuento.Items.Add(new OpcionCombo() { Valor = "Porcentual", Texto = "Porcentual" });
            comboBoxDescuento.DisplayMember = "Texto";
            comboBoxDescuento.ValueMember = "Valor";
            comboBoxDescuento.SelectedIndex = 0;

            textBoxDescuento.Text = "0.00";
            textBoxDescuento.Enabled = false;
            //FIN CONFIGURACION DESCUENTO

            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textBoxIdProducto.Text = "0";

            textBoxPagaCon.Text = "0.00";
            textBoxCambio.Text = "0.00";
            textBoxSubTotal.Text = "0.00";
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdListaClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdCliente.Text = modal._Cliente.IdCliente.ToString();
                    textBoxDocumentoCliente.Text = modal._Cliente.Documento;
                    textBoxNombreCompleto.Text = modal._Cliente.NombreCompleto; //textBoxNombreCliente
                    textBoxCodigoProducto.Select();
                }
                else
                {
                    textBoxDocumentoCliente.Select();
                }
            }
        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdListaProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProducto.Text = modal._Producto.IdProducto.ToString();
                    textBoxCodigoProducto.Text = modal._Producto.Codigo;
                    textBoxProducto.Text = modal._Producto.Nombre;
                    textBoxPrecio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    textBoxStock.Text = modal._Producto.Stock.ToString();
                    numericUpDownCantidad.Select();
                    textBoxCodigoProducto.BackColor = Color.FromArgb(45, 204, 112);
                }
                else
                {
                    textBoxCodigoProducto.Select();
                }
            }
        }

        private void textBoxCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CC_Producto().ListarProductos().Where(p => p.Codigo == textBoxCodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    textBoxCodigoProducto.BackColor = Color.FromArgb(45, 204, 112);
                    textBoxIdProducto.Text = oProducto.IdProducto.ToString();
                    textBoxProducto.Text = oProducto.Nombre;
                    textBoxPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                    textBoxStock.Text = oProducto.Stock.ToString();
                    numericUpDownCantidad.Select();
                }
                else
                {
                    textBoxCodigoProducto.BackColor = Color.FromArgb(254, 61, 78);
                    textBoxIdProducto.Text = "0";
                    textBoxProducto.Text = "";
                    textBoxPrecio.Text = "";
                    textBoxStock.Text = "";
                    numericUpDownCantidad.Value = 1;
                }
            }

            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool productoExiste = false;

            if (int.Parse(textBoxIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(textBoxPrecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecio.Select();
                return;
            }

            if (Convert.ToInt32(textBoxStock.Text) < Convert.ToInt32(numericUpDownCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puese ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dataGridViewData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            if (!productoExiste)
            {
                bool respuesta = new CC_Venta().RestarStock(
                    Convert.ToInt32(textBoxIdProducto.Text),
                    Convert.ToInt32(numericUpDownCantidad.Value.ToString())
                    );

                if (respuesta)
                {
                    dataGridViewData.Rows.Add(new object[]
                {
                    textBoxIdProducto.Text,
                    textBoxProducto.Text,
                    precio.ToString("0.00"),
                    numericUpDownCantidad.Value.ToString(),
                    (numericUpDownCantidad.Value * precio).ToString("0.00")
                });

                    CalcularSubTotal();
                    LimpiarProducto();
                    CalcularDescuento();
                    textBoxCodigoProducto.Select();
                }
            }
        }

        private void CalcularSubTotal()
        {
            decimal total = 0;

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                textBoxSubTotal.Text = total.ToString("0.00");
            }
            else if (dataGridViewData.Rows.Count == 0) //Esto lo agregue yo
            {
                total = 0;
                textBoxSubTotal.Text = total.ToString("0.00");
            }
        }

        private void CalcularDescuento()
        {
            CalculadorDescuento calculadorDescuento = new CalculadorDescuento();
            decimal totalOriginal = Convert.ToDecimal(textBoxSubTotal.Text);

            switch ((((OpcionCombo)comboBoxDescuento.SelectedItem).Valor))
            {
                case "SinDescuento":
                    calculadorDescuento.SetDescuento(new SinDescuento());
                    decimal totalSinDescuento = Convert.ToDecimal(totalOriginal);
                    textBoxTotal.Text = totalSinDescuento.ToString("0.00");
                    break;
                case "Fijo":
                    calculadorDescuento.SetDescuento(new DescuentoFijo(Convert.ToDecimal(textBoxDescuento.Text)));
                    decimal totalDescuentoNominal = calculadorDescuento.AplicarDescuento(totalOriginal);
                    textBoxTotal.Text = totalDescuentoNominal.ToString("0.00");
                    break;
                case "Porcentual":
                    calculadorDescuento.SetDescuento(new DescuentoPorcentual(Convert.ToDecimal(textBoxDescuento.Text)));
                    decimal totalDescuentoPorcentual = calculadorDescuento.AplicarDescuento(totalOriginal);
                    textBoxTotal.Text = totalDescuentoPorcentual.ToString("0.00");
                    break;
            }

            //if (comboBoxDescuento.SelectedIndex == 1)
            //{
            //    calculadorDescuento.SetDescuento(new SinDescuento());
            //    decimal totalSinDescuento = Convert.ToDecimal(totalOriginal);
            //    textBoxTotal.Text = totalSinDescuento.ToString("0.00");
            //} 
            //else if (comboBoxDescuento.SelectedIndex == 2)
            //{
            //    calculadorDescuento.SetDescuento(new DescuentoFijo(Convert.ToDecimal(textBoxDescuento.Text)));
            //    decimal totalDescuentoNominal = calculadorDescuento.AplicarDescuento(totalOriginal);
            //    textBoxTotal.Text = totalDescuentoNominal.ToString("0.00");
            //} 
            //else
            //{
            //    calculadorDescuento.SetDescuento(new DescuentoPorcentual(Convert.ToDecimal(textBoxDescuento.Text)));
            //    decimal totalDescuentoPorcentual = calculadorDescuento.AplicarDescuento(totalOriginal);
            //    textBoxTotal.Text = totalDescuentoPorcentual.ToString("0.00");
            //}
        }

        private void LimpiarProducto()
        {
            textBoxIdProducto.Text = "0";
            textBoxCodigoProducto.Text = "";
            textBoxCodigoProducto.BackColor = Color.White;
            textBoxProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
            numericUpDownCantidad.Value = 1;
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Papelera.Width;
                var h = Properties.Resources.Papelera.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Papelera, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewData.Columns[e.ColumnIndex].Name == "buttonEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    bool respuesta = new CC_Venta().SumarStock(
                        Convert.ToInt32(dataGridViewData.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dataGridViewData.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );

                    if (respuesta)
                    {
                        dataGridViewData.Rows.RemoveAt(indice);
                        CalcularDescuento();
                        CalcularSubTotal();
                        LimpiarProducto(); //Esto lo agregue yo
                    }
                }
            }
        }
        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPrecio.Text.Length > 0 && !textBoxPrecio.Text.Contains("."))
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

        private void textBoxPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxPagaCon.Text.Length > 0 && !textBoxPagaCon.Text.Contains("."))
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

        private void calcularCambio()
        {
            ////CODIGO ESTUDIANTE
            //decimal pagaCon;
            //decimal total = Convert.ToDecimal(textBoxTotalAPagar.Text);

            //if (textBoxPagaCon.Text.Trim() == "")
            //{
            //    textBoxPagaCon.Text = "0.00";
            //}

            //if (decimal.TryParse(textBoxPagaCon.Text.Trim(), out pagaCon))
            //{
            //    if (pagaCon < total)
            //    {
            //        //textBoxCambio.Text = "0.00";
            //        MessageBox.Show("Fondos insuficientes", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    else
            //    {
            //        decimal cambio = pagaCon - total;
            //        textBoxCambio.Text = cambio.ToString("0.00");
            //    }
            //}

            //CHAT GPT
            //Variables para almacenar los valores
            decimal total, pagaCon;

            // Intenta convertir el texto del textBoxTotalAPagar a decimal
            if (!decimal.TryParse(textBoxTotal.Text.Trim(), out total))
            {
                MessageBox.Show("El total a pagar no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intenta convertir el texto del textBoxPagaCon a decimal
            if (!decimal.TryParse(textBoxPagaCon.Text.Trim(), out pagaCon))
            {
                MessageBox.Show("La cantidad ingresada para pagar no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el monto pagado es suficiente
            if (pagaCon < total)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Calcula el cambio
            decimal cambio = pagaCon - total;

            // Muestra el cambio en el textBoxCambio
            textBoxCambio.Text = cambio.ToString("0.00");
        }

        private void textBoxPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
                buttonRegistrar.Select();
            }

            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPagaCon_TextChanged(object sender, EventArgs e)
        {
            //calcularCambio(); //No funciona
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (!Validaciones.ValidarCamposVacios(panelContenedor.Controls))
            {
                MessageBox.Show("Debe completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxDocumentoCliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxNombreCompleto.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxSubTotal.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToDecimal(textBoxPagaCon.Text.Trim()) < Convert.ToDecimal(textBoxTotal.Text.Trim()))
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto a la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //calcularCambio();

            #region Carga de datos
            DataTable detalleVenta = new DataTable();

            detalleVenta.Columns.Add("IdProducto", typeof(int));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                detalleVenta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });
            }

            int idCorrelativo = new CC_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _usuarioActual.IdUsuario, Documento = _usuarioActual.Documento, IdPersona = _usuarioActual.IdPersona, NombreCompleto = _usuarioActual.NombreCompleto },
                TipoDocumento = ((OpcionCombo)comboBoxTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                oCliente = new Cliente() { IdCliente = Convert.ToInt32(textBoxIdCliente.Text), Documento = textBoxDocumentoCliente.Text, NombreCompleto = textBoxNombreCompleto.Text },
                MontoPago = Convert.ToDecimal(textBoxPagaCon.Text),
                MontoCambio = Convert.ToDecimal(textBoxCambio.Text),
                SubTotal = Convert.ToDecimal(textBoxSubTotal.Text),
                MontoTotal = Convert.ToDecimal(textBoxTotal.Text),
                TipoDescuento = ((OpcionCombo)comboBoxDescuento.SelectedItem).Texto,
                MontoDescuento = Convert.ToDecimal(textBoxDescuento.Text),
            };

            string mensaje = string.Empty;
            bool respuesta = new CC_Venta().AgregarVenta(oVenta, detalleVenta, out mensaje);

            if (respuesta)
            {
                //var result = MessageBox.Show("Numero de venta generado:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (result == DialogResult.Yes)
                //{
                //    Clipboard.SetText(numeroDocumento);
                //}

                var result = MessageBox.Show("Pedido de venta registrado correctamente\n" + "Numero de venta generado: " + numeroDocumento, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

                textBoxDocumentoCliente.Clear();
                textBoxNombreCompleto.Clear();
                dataGridViewData.Rows.Clear();
                CalcularSubTotal();
                textBoxPagaCon.Clear();
                textBoxCambio.Clear();
                comboBoxDescuento.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion

            textBoxCodigoProducto.Text = "";
            textBoxIdProducto.Text = "0";
            textBoxProducto.Text = "";
            textBoxPrecio.Text = "";
            textBoxStock.Text = "";
            numericUpDownCantidad.Value = 1;
        }

        private void comboBoxDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDescuento.SelectedIndex != 0)
            {
                textBoxDescuento.Enabled = true;
            }
            else
            {
                textBoxDescuento.Enabled = false;
            }

            textBoxDescuento.Text = "0.00";
            CalcularDescuento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularDescuento();
        }

        private void textBoxDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularDescuento();
            }
        }

        private void textBoxDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o una tecla de control
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, suprime la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxDescuento.Text.Length > 0 && !textBoxDescuento.Text.Contains("."))
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

        private void textBoxCodigoProducto_TextChanged(object sender, EventArgs e)
        {

            Producto oProducto = new CC_Producto().ListarProductos().Where(p => p.Codigo == textBoxCodigoProducto.Text && p.Estado == true).FirstOrDefault();

            if (oProducto != null)
            {
                textBoxCodigoProducto.BackColor = Color.FromArgb(45, 204, 112);
                textBoxIdProducto.Text = oProducto.IdProducto.ToString();
                textBoxProducto.Text = oProducto.Nombre;
                textBoxPrecio.Text = oProducto.PrecioVenta.ToString("0.00");
                textBoxStock.Text = oProducto.Stock.ToString();
                numericUpDownCantidad.Select();
            }
            else
            {
                textBoxCodigoProducto.BackColor = Color.FromArgb(254, 61, 78);
                textBoxIdProducto.Text = "0";
                textBoxProducto.Text = "";
                textBoxPrecio.Text = "";
                textBoxStock.Text = "";
                numericUpDownCantidad.Value = 1;
            }
        }

        private void textBoxDocumentoCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente oCliente = new CC_Cliente().ListarClientes().Where(c => c.Documento == textBoxDocumentoCliente.Text && c.Estado == true).FirstOrDefault();

            if (oCliente != null)
            {
                textBoxDocumentoCliente.BackColor = Color.FromArgb(45, 204, 112);
                textBoxIdCliente.Text = oCliente.IdCliente.ToString();
                textBoxDocumentoCliente.Text = oCliente.Documento;
                textBoxNombreCompleto.Text = oCliente.NombreCompleto;
                textBoxCodigoProducto.Select();
            }
            else
            {
                textBoxDocumentoCliente.BackColor = Color.FromArgb(254, 61, 78);
                textBoxIdCliente.Text = "0";
                textBoxNombreCompleto.Text = "";
            }
        }

        private void textBoxDocumentoCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cliente oCliente = new CC_Cliente().ListarClientes().Where(c => c.Documento == textBoxDocumentoCliente.Text && c.Estado == true).FirstOrDefault();

                if (oCliente != null)
                {
                    textBoxDocumentoCliente.BackColor = Color.FromArgb(45, 204, 112);
                    textBoxIdCliente.Text = oCliente.IdCliente.ToString();
                    textBoxDocumentoCliente.Text = oCliente.Documento;
                    textBoxNombreCompleto.Text = oCliente.NombreCompleto;
                    textBoxCodigoProducto.Select();
                }
                else
                {
                    textBoxDocumentoCliente.BackColor = Color.FromArgb(254, 61, 78);
                    textBoxIdCliente.Text = "0";
                    textBoxNombreCompleto.Text = "";
                }
            }

            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void numericUpDownCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonAgregar_Click(sender, e);
            }
        }

        private void textBoxDescuento_Leave(object sender, EventArgs e)
        {
            CalcularDescuento();
        }
    }
}
