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
    public partial class mdDetalleAuditoriaCompra : Form
    {
        public int _idAuditoriaCompra;

        public mdDetalleAuditoriaCompra(int idAuditoriaCompra)
        {
            _idAuditoriaCompra = idAuditoriaCompra;
            InitializeComponent();
        }

        private void mdDetalleAuditoriaCompra_Load(object sender, EventArgs e)
        {
            AuditoriaCompra oAuditoriaCompra = new CC_AuditoriaCompra().ObtenerAuditoriaCompra(_idAuditoriaCompra);

            if (oAuditoriaCompra.IdAuditoriaCompra != 0)
            {
                //Informacion Auditoria
                textBoxFechaAuditoria.Text = oAuditoriaCompra.FechaAuditoria;
                textBoxUltimoUsuario.Text = oAuditoriaCompra.oUsuarioAuditoria.NombreCompleto;
                textBoxDescripcion.Text = oAuditoriaCompra.DescripcionAuditoria;
                //Informacion Compra
                textBoxIdCompra.Text = oAuditoriaCompra.IdCompra.ToString();
                textBoxFecha.Text = oAuditoriaCompra.FechaRegistro;
                textBoxTipoDocumento.Text = oAuditoriaCompra.TipoDocumento;
                textBoxUsuario.Text = oAuditoriaCompra.oUsuarioCompra.NombreCompleto;
                //Informacion Proveedor
                textBoxCUIT.Text = oAuditoriaCompra.oProveedor.CUIT;
                textBoxRazonSocial.Text = oAuditoriaCompra.oProveedor.RazonSocial;

                dataGridViewData.Rows.Clear();
                foreach (AuditoriaDetalleCompra adc in oAuditoriaCompra.oAuditoriaDetalleCompra)
                {
                    dataGridViewData.Rows.Add(new object[] { adc.oProducto.Nombre, adc.PrecioCompra, adc.Cantidad, adc.MontoTotal });
                }

                textBoxMontoTotal.Text = oAuditoriaCompra.MontoTotal.ToString("0.00");
            }
        }

        private void buttonDescargarPDF_Click(object sender, EventArgs e)
        {
            if (textBoxTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textoHTML = Properties.Resources.PlantillaAuditoriaCompra.ToString();
            Negocio oNegocio = new CC_Negocio().ObtenerDatos();

            textoHTML = textoHTML.Replace("@nombrenegocio", oNegocio.Nombre.ToUpper()); //@nombreNegocio
            textoHTML = textoHTML.Replace("@cuitnegocio", oNegocio.CUIT); //@documentoNegocio
            textoHTML = textoHTML.Replace("@direcnegocio", oNegocio.Direccion); //direccionNegocio

            //textoHTML = textoHTML.Replace("@tipodocumento", textBoxTipoDocumento.Text.ToUpper());
            textoHTML = textoHTML.Replace("@idCompra", textBoxIdCompra.Text);

            textoHTML = textoHTML.Replace("@fechaAuditoria", textBoxFechaAuditoria.Text);
            textoHTML = textoHTML.Replace("@usuarioAuditoria", textBoxUltimoUsuario.Text);
            textoHTML = textoHTML.Replace("@descripcionAuditoria", textBoxDescripcion.Text);
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
            saveFile.FileName = string.Format("AuditoriaCompra_{0}.pdf", textBoxIdCompra.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el archivo PDF: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
