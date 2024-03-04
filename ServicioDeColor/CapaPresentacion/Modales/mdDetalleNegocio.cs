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

        private void textBoxCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void textBoxCUIT_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxNombreNegocio_TextChanged(object sender, EventArgs e)
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

        private void textBoxCUIT_TextChanged(object sender, EventArgs e)
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

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
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
    }
}
