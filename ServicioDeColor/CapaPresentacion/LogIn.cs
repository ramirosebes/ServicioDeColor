using CapaControladora;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            textBoxDocumento.Clear();
            textBoxClave.Clear();
            textBoxDocumento.Select();
            this.Show();
        }

        private void textBoxClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void IniciarSesion()
        {
            Usuario oUsuario = new CC_Usuario().ListarUsuarios().Where(u => u.Documento == textBoxDocumento.Text).FirstOrDefault();

            if (oUsuario != null)
            {
                bool claveCorrecta = oUsuario.VerificarClave(textBoxClave.Text);

                if (claveCorrecta)
                {
                    if (oUsuario.Estado == false)
                    {
                        MessageBox.Show("El usuario se encuentra inactivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Inicio inicio = new Inicio(oUsuario);

                    #region Auditoria sesion
                    AuditoriaSesion auditoriaSesion = new AuditoriaSesion()
                    {
                        oUsuario = oUsuario,
                        DescripcionAuditoria = "Inicio de sesión",
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

                    #endregion

                    inicio.Show();
                    this.Hide();

                    inicio.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            // Evita que se pegue texto
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suprime la pulsación de tecla Ctrl+V
                e.SuppressKeyPress = true;
            }
        }
    }
}
