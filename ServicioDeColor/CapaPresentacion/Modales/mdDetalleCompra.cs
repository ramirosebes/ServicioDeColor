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
    public partial class mdDetalleCompra : Form
    {
        private readonly string _tipoModal;
        private int _idCompra;
        private Compra _oCompra;
        private CC_Compra oCC_Compra = new CC_Compra();
        public string _numeroDocumento;

        public mdDetalleCompra(string numeroDocumento)
        {
            _numeroDocumento = numeroDocumento;
            
            InitializeComponent();
        }

        private void mdDetalleCompra_Load(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = _numeroDocumento;
            Compra oCompra = new CC_Compra().ObtenerCompra(textBoxBusqueda.Text);

            if (oCompra.IdCompra != 0)
            {
                textBoxNumeroDocumento.Text = oCompra.NumeroDocumento;
                textBoxFecha.Text = oCompra.FechaRegistro;
                textBoxTipoDocumento.Text = oCompra.TipoDocumento;
                textBoxUsuario.Text = oCompra.oPersona.NombreCompleto;
                textBoxCUIT.Text = oCompra.oProveedor.CUIT;
                textBoxRazonSocial.Text = oCompra.oProveedor.RazonSocial; //textBoxNombreProveedor

                dataGridViewData.Rows.Clear();
                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    dataGridViewData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                textBoxMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }

        private void buttonDescargarPDF_Click(object sender, EventArgs e)
        {
            if (textBoxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHTML = Properties.Resources.PlantillaCompra.ToString();
            Negocio oNegocio = new CC_Negocio().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombrenegocio", oNegocio.Nombre.ToUpper()); //@nombreNegocio
            textoHTML = textoHTML.Replace("@cuitnegocio", oNegocio.CUIT); //@documentoNegocio
            textoHTML = textoHTML.Replace("@direcnegocio", oNegocio.Direccion); //direccionNegocio

            textoHTML = textoHTML.Replace("@tipodocumento", textBoxTipoDocumento.Text.ToUpper());
            textoHTML = textoHTML.Replace("@numerodocumento", textBoxNumeroDocumento.Text);

            textoHTML = textoHTML.Replace("@docproveedor", textBoxCUIT.Text);
            textoHTML = textoHTML.Replace("@nombreproveedor", textBoxRazonSocial.Text);
            textoHTML = textoHTML.Replace("@fecharegistro", textBoxFecha.Text);
            textoHTML = textoHTML.Replace("@usuarioregistro", textBoxUsuario.Text);

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
            textoHTML = textoHTML.Replace("@montototal", textBoxMontoTotal.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra_{0}.pdf", textBoxNumeroDocumento.Text);
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
