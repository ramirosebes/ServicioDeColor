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
    public partial class mdDetallePermisoSimple : Form
    {
        private int _idPermiso;
        private CC_Permiso oCCPermiso = new CC_Permiso();
        private Permiso oPermiso = new Permiso();

        public mdDetallePermisoSimple(int idPermiso)
        {
            _idPermiso = idPermiso;
            oPermiso = oCCPermiso.ListarPermisos().Where(p => p.IdPermiso == _idPermiso).FirstOrDefault();
            InitializeComponent();
        }

        private void mdDetallePermisoSimple_Load(object sender, EventArgs e)
        {
            textBoxNombreMenu.Text = oPermiso.NombreMenu;
            textBoxNombreMenu.Enabled = false;
            textBoxNombrePermiso.Text = oPermiso.Nombre;
            textBoxNombrePermiso.Enabled = false;

            comboBoxEstado.Items.Add(new OpcionCombo(1, "Activo"));
            comboBoxEstado.Items.Add(new OpcionCombo(0, "Inactivo"));
            comboBoxEstado.SelectedIndex = 0;
            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";
            comboBoxEstado.Enabled = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNombrePermiso_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica si la longitud del texto es mayor que 100
            if (textBox.Text.Length > 100)
            {
                // Si es mayor, truncamos el texto a 100 caracteres
                textBox.Text = textBox.Text.Substring(0, 100);
                // Establecemos el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBoxNombreMenu_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Verifica si la longitud del texto es mayor que 100
            if (textBox.Text.Length > 100)
            {
                // Si es mayor, truncamos el texto a 100 caracteres
                textBox.Text = textBox.Text.Substring(0, 100);
                // Establecemos el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
