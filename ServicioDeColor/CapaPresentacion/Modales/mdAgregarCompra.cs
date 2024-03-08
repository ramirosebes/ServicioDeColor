using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdAgregarCompra : Form
    {
        private Usuario _usuarioActual;

        public mdAgregarCompra(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void mdDetalleCompra_Load(object sender, EventArgs e)
        {
            //CONFIGURACION DEL OPCION COMBO TIPO DOCUMENTO -- SE PUEDEN AGREGAR MAS COMO "CHEQUE"
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboBoxTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboBoxTipoDocumento.DisplayMember = "Texto";
            comboBoxTipoDocumento.ValueMember = "Valor";
            comboBoxTipoDocumento.SelectedIndex = 0;

            textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            textBoxIdProveedor.Text = "0";
            textBoxIdProducto.Text = "0";

            AutoCompletarCuitProveedor();
            AutoCompletarCodigoProducto();
            EliminarComrpobantes();
        }

        private void buttonBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdListaProveedores())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    textBoxIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    textBoxCUIT.Text = modal._Proveedor.CUIT;
                    textBoxRazonSocial.Text = modal._Proveedor.RazonSocial;
                    textBoxCorreo.Text = modal._Proveedor.Correo;
                }
                else
                {
                    textBoxCUIT.Select();
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
                    textBoxPrecioCompra.Select();
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
                    textBoxCodigoProducto.BackColor = System.Drawing.Color.FromArgb(45, 204, 112);
                    textBoxIdProducto.Text = oProducto.IdProducto.ToString();
                    textBoxProducto.Text = oProducto.Nombre;
                    textBoxPrecioCompra.Select();
                }
                else
                {
                    textBoxCodigoProducto.BackColor = System.Drawing.Color.FromArgb(254, 61, 78);
                    textBoxIdProducto.Text = "0";
                    textBoxProducto.Text = "";
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
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false;

            if (int.Parse(textBoxIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (textBoxPrecioCompra.Text == "")
            {
                MessageBox.Show("Debe introducir un precio de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(textBoxPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioCompra.Select();
                return;
            }

            if (textBoxPrecioVenta.Text == "")
            {
                MessageBox.Show("Debe introducir un precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(textBoxPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxPrecioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in dataGridViewData.Rows)
            {
                //CODIGO ESTUDIANTE
                if (fila.Cells["IdProducto"].Value.ToString() == textBoxIdProducto.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            //Esta validacion debe estar arriba de foreach (DataGridViewRow fila in dataGridViewData.Rows), si no retornara null la fila
            if (!productoExiste)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    textBoxIdProducto.Text,
                    textBoxProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    numericUpDownCantidad.Value.ToString(),
                    (numericUpDownCantidad.Value * precioCompra).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                textBoxCodigoProducto.Select();
            }
        }

        private void limpiarProducto()
        {
            textBoxIdProducto.Text = "0";
            textBoxCodigoProducto.Text = "";
            textBoxCodigoProducto.BackColor = System.Drawing.Color.White;
            textBoxProducto.Text = "";
            textBoxPrecioCompra.Text = "";
            textBoxPrecioVenta.Text = "";
            numericUpDownCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {

                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString()); //--> No funcionaba ya que lo toma como null, de una para otras funciona
                }
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
            else if (dataGridViewData.Rows.Count == 0) //Esto lo agregue yo
            {
                total = 0;
                textBoxTotalAPagar.Text = total.ToString("0.00");
            }
        }

        private void dataGridViewData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Papelera.Width;
                var h = Properties.Resources.Papelera.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Papelera, new System.Drawing.Rectangle(x, y, w, h));
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
                    dataGridViewData.Rows.RemoveAt(indice);
                    calcularTotal();
                }
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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            AgregarCompra();
        }

        private void AgregarCompra()
        {
            if (!ValidarProveedor())
                return;

            if (!ValidarProductosEnCompra())
                return;

            DataTable detalleCompra = CrearTablaDetalleCompra();

            LlenarDetalleCompra(detalleCompra);

            string numeroDocumento = ObtenerNumeroDocumento();

            Compra oCompra = CrearCompra(numeroDocumento);

            GenerarPDF(oCompra);

            ProcesarCompra(oCompra, detalleCompra, numeroDocumento);
        }

        private bool ValidarProveedor()
        {
            if (Convert.ToInt32(textBoxIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool ValidarProductosEnCompra()
        {
            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private DataTable CrearTablaDetalleCompra()
        {
            DataTable detalleCompra = new DataTable();

            detalleCompra.Columns.Add("IdProducto", typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("MontoTotal", typeof(decimal));

            return detalleCompra;
        }

        private void LlenarDetalleCompra(DataTable detalleCompra)
        {
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                detalleCompra.Rows.Add(
                    new object[]
                    {
                Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                Convert.ToInt32(row.Cells["Cantidad"].Value),
                Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    });
            }
        }

        private string ObtenerNumeroDocumento()
        {
            int idCorrelativo = new CC_Compra().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);
            return numeroDocumento;
        }

        private Compra CrearCompra(string numeroDocumento)
        {
            return new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _usuarioActual.IdUsuario, NombreCompleto = _usuarioActual.NombreCompleto, Correo = _usuarioActual.Correo, Documento = _usuarioActual.Documento },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(textBoxIdProveedor.Text), RazonSocial = textBoxRazonSocial.Text, CUIT = textBoxCUIT.Text, Correo = textBoxCorreo.Text },
                TipoDocumento = ((OpcionCombo)comboBoxTipoDocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(textBoxTotalAPagar.Text)
            };
        }

        private void ProcesarCompra(Compra oCompra, DataTable detalleCompra, string numeroDocumento)
        {
            string mensaje = string.Empty;
            bool respuesta = new CC_Compra().AgregarCompra(oCompra, detalleCompra, out mensaje);

            if (respuesta)
            {
                MostrarConfirmacion(numeroDocumento);
                LimpiarCampos();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MostrarConfirmacion(string numeroDocumento)
        {
            //var result = MessageBox.Show("Numero de compra generado:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (result == DialogResult.Yes)
            //{
            //    Clipboard.SetText(numeroDocumento);
            //    this.Close(); //Agregado recientemente
            //}

            var result = MessageBox.Show("Orden de compra registrada correctamente\n" + "Numero de compra generado: " + numeroDocumento, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close(); //Agregado recientemente
            }
        }

        private void LimpiarCampos()
        {
            textBoxIdProveedor.Text = "0";
            textBoxCUIT.Clear();
            textBoxRazonSocial.Clear();
            dataGridViewData.Rows.Clear();
        }

        private void textBoxCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            Producto oProducto = new CC_Producto().ListarProductos().Where(p => p.Codigo == textBoxCodigoProducto.Text && p.Estado == true).FirstOrDefault();

            if (oProducto != null)
            {
                textBoxCodigoProducto.BackColor = System.Drawing.Color.FromArgb(45, 204, 112);
                textBoxIdProducto.Text = oProducto.IdProducto.ToString();
                textBoxProducto.Text = oProducto.Nombre;
                //.Select();
            }
            else
            {
                textBoxCodigoProducto.BackColor = System.Drawing.Color.FromArgb(254, 61, 78);
                textBoxIdProducto.Text = "0";
                textBoxProducto.Text = "";
            }
        }

        void AutoCompletarCodigoProducto()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            foreach (var item in new CC_Producto().ListarProductos().Where(p => p.Estado == true).Select(p => p.Codigo).ToArray())
            {
                lista.Add(item);
            }

            textBoxCodigoProducto.AutoCompleteCustomSource = lista;
        }

        private void textBoxCUIT_TextChanged(object sender, EventArgs e)
        {
            Proveedor oProveedor = new CC_Proveedor().ListarProveedores().Where(p => p.CUIT == textBoxCUIT.Text && p.Estado == true).FirstOrDefault();

            if (oProveedor != null)
            {
                textBoxCUIT.BackColor = System.Drawing.Color.FromArgb(45, 204, 112);
                textBoxIdProveedor.Text = oProveedor.IdProveedor.ToString();
                textBoxCUIT.Text = oProveedor.CUIT;
                textBoxRazonSocial.Text = oProveedor.RazonSocial;
                textBoxCorreo.Text = oProveedor.Correo;
                //textBoxCodigoProducto.Select();
            }
            else
            {
                textBoxCUIT.BackColor = System.Drawing.Color.FromArgb(254, 61, 78);
                textBoxIdProveedor.Text = "0";
                textBoxRazonSocial.Text = "";
            }
        }

        void AutoCompletarCuitProveedor()
        {
            //DataTable datos = new DataTable();
            AutoCompleteStringCollection listaCUIT = new AutoCompleteStringCollection();

            //Metodo 1
            //foreach (var item in new CC_Proveedor().ListarProveedores().Where(p => p.Estado == true).ToArray()) //.Select(p => p.CUIT)
            //{
            //    listaCUIT.Add(item.CUIT + " - " + item.RazonSocial);
            //}

            //Metodo 2
            foreach (var item in new CC_Proveedor().ListarProveedores().Where(p => p.Estado == true).Select(p => p.CUIT).ToArray())
            {
                listaCUIT.Add(item);
            }

            textBoxCUIT.AutoCompleteCustomSource = listaCUIT;
        }

        private void textBoxCUIT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Proveedor oProveedor = new CC_Proveedor().ListarProveedores().Where(p => p.CUIT == textBoxCUIT.Text && p.Estado == true).FirstOrDefault();

                if (oProveedor != null)
                {
                    textBoxCUIT.BackColor = System.Drawing.Color.FromArgb(45, 204, 112);
                    textBoxIdProveedor.Text = oProveedor.IdProveedor.ToString();
                    textBoxCUIT.Text = oProveedor.CUIT;
                    textBoxRazonSocial.Text = oProveedor.RazonSocial;
                    textBoxCorreo.Text = oProveedor.Correo;
                    textBoxCodigoProducto.Select();
                }
                else
                {
                    textBoxCUIT.BackColor = System.Drawing.Color.FromArgb(254, 61, 78);
                    textBoxIdProveedor.Text = "0";
                    textBoxRazonSocial.Text = "";
                }
            }

            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDownCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buttonAgregar_Click(sender, e);
            }
        }

        private void textBoxPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBoxPrecioVenta.Select();
            }
        }

        private void textBoxPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //numericUpDownCantidad.Select();
                numericUpDownCantidad.Focus();
                numericUpDownCantidad.Select(0, numericUpDownCantidad.Text.Length);
            }
        }

        private void GenerarPDF(Compra oCompra)
        {
            string textoHTML = Properties.Resources.PlantillaCompra.ToString();
            Negocio oNegocio = new CC_Negocio().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombrenegocio", oNegocio.Nombre.ToUpper()); //@nombreNegocio
            textoHTML = textoHTML.Replace("@cuitnegocio", oNegocio.CUIT); //@documentoNegocio
            textoHTML = textoHTML.Replace("@direcnegocio", oNegocio.Direccion); //direccionNegocio

            textoHTML = textoHTML.Replace("@tipodocumento", oCompra.TipoDocumento);
            textoHTML = textoHTML.Replace("@numerodocumento", oCompra.NumeroDocumento);

            textoHTML = textoHTML.Replace("@docproveedor", oCompra.oProveedor.CUIT);
            textoHTML = textoHTML.Replace("@nombreproveedor", oCompra.oProveedor.RazonSocial);
            textoHTML = textoHTML.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));
            textoHTML = textoHTML.Replace("@usuarioregistro", oCompra.oUsuario.NombreCompleto);

            string filas = string.Empty;

            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            textoHTML = textoHTML.Replace("@filas", filas);
            textoHTML = textoHTML.Replace("@montototal", oCompra.MontoTotal.ToString());

            try
            {
                // Especifica la ubicación de descarga del archivo PDF
                string nombreArchivo = string.Format("Compra_{0}.pdf", oCompra.NumeroDocumento);

                // Obtener la ruta del directorio base del proyecto
                string directorioBase = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                // Construir la ruta completa para la carpeta "Comprobantes" dentro del proyecto
                string rutaComprobantes = Path.Combine(directorioBase, "Comprobantes");
                //string rutaComprobantes = @"../../Comprobantes"; --> No funcionaba

                // Combinar la ruta de la carpeta "Comprobantes" con el nombre del archivo
                string rutaDescarga = Path.Combine(rutaComprobantes, nombreArchivo);

                // Crea el archivo PDF en la ubicación especificada
                using (FileStream stream = new FileStream(rutaDescarga, FileMode.Create))
                {
                    Document pdfDocumento = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDocumento, stream);
                    pdfDocumento.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CC_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDocumento.Left, pdfDocumento.GetTop(51));
                        pdfDocumento.Add(img);
                    }

                    using (StringReader sr = new StringReader(textoHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocumento, sr);
                    }

                    pdfDocumento.Close();
                    stream.Close();
                    //MessageBox.Show("Documento generado en " + rutaDescarga, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Luego de generar el PDF, aquí puedes implementar la lógica para enviarlo por correo electrónico al proveedor.
                #region EnviarCorreo
                EnviarCorreo(rutaDescarga, oCompra);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarCorreo(string rutaDescarga, Compra oCompra)
        {
            try
            {
                // Crear un cliente SMTP para enviar el correo electrónico
                SmtpClient client = new SmtpClient("smtp-mail.outlook.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("serviciodecolortdp@outlook.com", "Ser01Vi02Cio03De04Co05Lor06."),
                    EnableSsl = true,
                };

                // Crear el mensaje de correo electrónico
                MailMessage mensaje = new MailMessage
                {
                    From = new MailAddress("serviciodecolortdp@outlook.com"),
                    Subject = "Comprobante de compra",
                    Body = "Adjunto encontrarás el comprobante de compra.",
                };

                // Agregar el archivo adjunto (el comprobante PDF)
                Attachment adjunto = new Attachment(rutaDescarga);
                mensaje.Attachments.Add(adjunto);

                // Especificar el destinatario del correo electrónico
                mensaje.To.Add(oCompra.oProveedor.Correo);

                // Enviar el mensaje de correo electrónico
                client.Send(mensaje);

                // Borra el archivo después de enviar el correo electrónico
                //File.Delete(rutaDescarga);

                MessageBox.Show("Se ha enviado el comprobante de la compra por correo electronico a " + oCompra.oProveedor.RazonSocial + ".", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarComrpobantes()
        {
            try
            {
                // Obtener la ruta del directorio base del proyecto
                string directorioBase = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

                // Construir la ruta completa para la carpeta "Comprobantes" dentro del proyecto
                string rutaComprobantes = Path.Combine(directorioBase, "Comprobantes");

                string[] archivos = Directory.GetFiles(rutaComprobantes);

                // Eliminar cada archivo en el directorio de comprobantes
                foreach (string archivo in archivos)
                {
                    File.Delete(archivo);
                }

                //MessageBox.Show("Se han eliminado todos los comprobantes correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Se han eliminado todos los comprobantes correectamente");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al eliminar los comprobantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al eliminar los comprobantes: " + ex.Message);
            }
        }
    }
}
