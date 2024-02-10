using CapaEntidad;
using CapaControladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Modales;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        private Usuario _usuarioActual;
        private CC_Negocio oCC_Negocio = new CC_Negocio();
        public int idNegocio { get; set; }

        public frmNegocio(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            //MODULO DE SEGURIDAD - VISIBILIDAD DE LOS MENUES
            foreach (ToolStripMenuItem menu in menu.Items)
            {
                bool encontrado = _usuarioActual.GetPermisos().Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            ActualizarDatos();
        }

        private void menuEditarNegocio_Click(object sender, EventArgs e)
        {
            mdDetalleNegocio frm = new mdDetalleNegocio(idNegocio);
            frm.ShowDialog();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);
            return imagen;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
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
    }
}
