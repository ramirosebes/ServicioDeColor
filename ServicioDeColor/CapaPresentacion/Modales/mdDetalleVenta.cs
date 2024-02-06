using CapaControladora;
using CapaEntidad;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdDetalleVenta : Form
    {
        public string _numeroDocumento;

        public mdDetalleVenta(string numeroDocumento)
        {
            _numeroDocumento = numeroDocumento;
            InitializeComponent();
        }

        private void mdDetalleVenta_Load(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = _numeroDocumento;
            Venta oVenta = new CC_Venta().ObtenerVenta(textBoxBusqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                textBoxNumeroDocumento.Text = oVenta.NumeroDocumento;

                textBoxFecha.Text = oVenta.FechaRegistro;
                textBoxTipoDocumento.Text = oVenta.TipoDocumento;
                textBoxUsuario.Text = oVenta.oUsuario.NombreCompleto;

                textBoxDocumentoCliente.Text = oVenta.oCliente.Documento;
                textBoxNombreCliente.Text = oVenta.oCliente.NombreCompleto;

                dataGridViewData.Rows.Clear();

                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dataGridViewData.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                textBoxMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                textBoxMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                textBoxMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
        }

        private void buttonDescargarPDF_Click(object sender, EventArgs e)
        {
            if (textBoxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHTML = Properties.Resources.PlantillaVenta.ToString();
            Negocio oDatos = new CC_Negocio().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombrenegocio", oDatos.Nombre.ToUpper());
            textoHTML = textoHTML.Replace("@cuitnegocio", oDatos.CUIT);
            textoHTML = textoHTML.Replace("@direcnegocio", oDatos.Direccion);

            textoHTML = textoHTML.Replace("@tipodocumento", textBoxTipoDocumento.Text.ToUpper());
            textoHTML = textoHTML.Replace("@numerodocumento", textBoxNumeroDocumento.Text);

            textoHTML = textoHTML.Replace("@doccliente", textBoxDocumentoCliente.Text);
            textoHTML = textoHTML.Replace("@nombrecliente", textBoxNombreCliente.Text);
            textoHTML = textoHTML.Replace("@fecharegistro", textBoxFecha.Text);
            textoHTML = textoHTML.Replace("@usuarioregistro", textBoxUsuario.Text);

            string filas = string.Empty;

            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }

            textoHTML = textoHTML.Replace("@filas", filas);
            textoHTML = textoHTML.Replace("@montototal", textBoxMontoTotal.Text);
            textoHTML = textoHTML.Replace("@pagocon", textBoxMontoPago.Text);
            textoHTML = textoHTML.Replace("@cambio", textBoxMontoCambio.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta_{0}.pdf", textBoxNumeroDocumento.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
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
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
