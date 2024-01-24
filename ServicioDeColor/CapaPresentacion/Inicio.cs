using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaControladora;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario oUsuario = null)
        {
            if (oUsuario == null)
            {
                usuarioActual = new Usuario() { NombreCompleto = "Admin", IdUsuario = 1 };
                usuarioActual.SetPermisos(new CC_Permiso().ListarPermisosPorId(usuarioActual.IdUsuario));
            }
            else
            {
                usuarioActual = oUsuario;
            }
            //usuarioActual = oUsuario;
            //usuarioActual.SetPermisos(new CC_Permiso().ListarPermisos(usuarioActual.IdUsuario));

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> listaPermisos = usuarioActual.GetPermisos();

            //List<Permiso> listaPermisos = new CC_Permiso().ListarPermisos(_usuarioActual.IdUsuario);

            //foreach (ToolStripMenuItem menuItem in menu.Items)
            //{
            //    bool encontrado = listaPermisos.Any(p => p.NombreMenu == menuItem.Name);

            //    if (encontrado)
            //    {
            //        menuItem.Visible = true;
            //    }
            //    else
            //    {
            //        menuItem.Visible = false;
            //    }
            //}

            //foreach (ToolStripMenuItem menu in menupermiso.DropDownItems)
            //{
            //    bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

            //    if (encontrado)
            //    {
            //        menu.Visible = true;
            //    }
            //    else
            //    {
            //        menu.Visible = false;
            //    }
            //}

            labelUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.FromArgb(45, 204, 112);
            //formulario.BackColor = Color.White; //Color de fondo del formulario al abrirlo
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUsuarios, new frmUsuario(usuarioActual));
        }

        private void menuPermisosSimples_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUsuarios, new frmPermiso(usuarioActual));
        }

        private void menuGrupos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUsuarios, new frmGrupo(usuarioActual));
        }

        private void menuPermisosUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuUsuarios, new frmPermisoUsuario());
        }
    }
}