using CapaControladora;
using CapaEntidad;
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
    public partial class mdDetalleNegocio : Form
    {
        private CC_Negocio oCC_Negocio = new CC_Negocio();
        public int idNegocio { get; set; }

        public mdDetalleNegocio(int idNegocio)
        {
            InitializeComponent();
        }

        private void mdDetalleNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImage = oCC_Negocio.ObtenerLogo(out obtenido);

            if (obtenido)
            {
                pictureBoxLogo.Image = ByteToImage(byteImage);
            }

            Negocio datos = oCC_Negocio.ObtenerDatos();

            idNegocio = datos.IdNegocio;
            textBoxNombreNegocio.Text = datos.Nombre;
            textBoxCUIT.Text = datos.CUIT;
            textBoxDireccion.Text = datos.Direccion;
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);
            return imagen;
        }

        private void buttonSubirImagen_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CC_Negocio().ActualizarLogo(byteImage, out mensaje);

                if (respuesta)
                {
                    pictureBoxLogo.Image = ByteToImage(byteImage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = textBoxNombreNegocio.Text,
                CUIT = textBoxCUIT.Text,
                Direccion = textBoxDireccion.Text
            };

            bool respuesta = new CC_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
