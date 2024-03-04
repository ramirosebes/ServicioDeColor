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
using CapaPresentacion.Modales;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario _usuarioActual;
        private static ToolStripMenuItem _menuActivo = null;
        private static Form _formularioActivo = null;

        public Inicio(Usuario oUsuario = null)
        {
            //Para testear el sistema sin loguearse
            //if (oUsuario == null)
            //{
            //    _usuarioActual = new Usuario() { NombreCompleto = "Admin", IdUsuario = 1 };
            //    _usuarioActual.SetPermisos(new CC_Permiso().ListarPermisosPorId(_usuarioActual.IdUsuario));
            //}
            //else
            //{
            //    _usuarioActual = oUsuario;
            //}

            //Para ingresar logueandose
            _usuarioActual = oUsuario;
            _usuarioActual.SetPermisos(new CC_Permiso().ListarPermisosPorId(_usuarioActual.IdUsuario));

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //MODULO DE SEGURIDAD - VISIBILIDAD DE LOS MENUES
            List<Permiso> listaPermisos = _usuarioActual.GetPermisos();

            //List<Permiso> listaPermisos = new CC_Permiso().ListarPermisos(__usuarioActual.IdUsuario);

            //Recorre todo el menu pricipal ocultado o mostrando los menues dependiendo los permisos que tenga
            foreach (ToolStripMenuItem menuItem in menu.Items)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menuItem.Name);

                if (encontrado)
                {
                    menuItem.Visible = true;
                }
                else
                {
                    menuItem.Visible = false;
                }
            }

            //Recorre todo el menu Seguridad ocultado o mostrando los menues dependiendo los permisos que tenga
            foreach (ToolStripMenuItem menu in menuSeguridad.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            //Recorre todo el menu Permisos ocultado o mostrando los menues dependiendo los permisos que tenga
            foreach (ToolStripMenuItem menu in menuPermisos.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuAuditorias.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuVentas.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuCompras.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuReportes.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            foreach (ToolStripMenuItem menu in menuConfiguracion.DropDownItems)
            {
                bool encontrado = listaPermisos.Any(p => p.NombreMenu == menu.Name);

                if (encontrado)
                {
                    menu.Visible = true;
                }
                else
                {
                    menu.Visible = false;
                }
            }

            labelUsuario.Text = _usuarioActual.NombreCompleto;
        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (_menuActivo != null)
            {
                _menuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            _menuActivo = menu;

            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
            }

            _formularioActivo = formulario;
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
            abrirFormulario(menuSeguridad, new frmUsuario(_usuarioActual));
        }

        private void menuPermisosSimples_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmPermisoSimple(_usuarioActual));
        }

        private void menuGrupos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmGrupoPermisos(_usuarioActual));
        }

        private void menuPermisosUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmPermisoUsuario(_usuarioActual));
        }
        private void menuAuditoriaCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmAuditoriaCompra(_usuarioActual));
        }

        private void auditoriaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmAuditoriaVenta(_usuarioActual));
        }

        private void auditoriaSesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuSeguridad, new frmAuditoriaSesion(_usuarioActual));
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmCliente(_usuarioActual));
        }

        private void menuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCategoria(_usuarioActual));
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmProducto(_usuarioActual));
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmProveedor(_usuarioActual));
        }

        private void menuDatosNegocio_Click(object sender, EventArgs e)
        {
            //mdDetalleNegocio frm = new mdDetalleNegocio();
            //frm.ShowDialog();
            abrirFormulario(menuConfiguracion, new frmNegocio(_usuarioActual));
        }

        private void ordenesDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuCompras, new frmCompra(_usuarioActual));
        }

        private void pedidosDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuVentas, new frmVenta(_usuarioActual));
        }

        private void menuReportesCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReporteCompra(_usuarioActual));
        }

        private void menuReportesVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuReportes, new frmReporteVentas(_usuarioActual));
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            CierreSesion();
        }

        private void CierreSesion()
        {
            AuditoriaSesion auditoriaSesion = new AuditoriaSesion()
            {
                oUsuario = _usuarioActual,
                DescripcionAuditoria = "Cierre de sesión",
            };

            bool auditoriaSesionRegistrada = new CC_AuditoriaSesion().RegistrarAuditoriaSesion(auditoriaSesion, out string mensaje);

            ////PRUEBA
            //if (auditoriaSesionRegistrada)
            //{
            //    MessageBox.Show("Inicio de sesion auditado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}