using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Modales;
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

namespace CapaPresentacion
{
    public partial class frmPermisoUsuario : Form
    {
        private CC_Usuario oCC_Usuario = new CC_Usuario();
        private Usuario _usuarioActual;

        public frmPermisoUsuario(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmPermisoUsuario_Load(object sender, EventArgs e)
        {
            //CONFIGURACION DEL OPCION COMBO SELECCIONAR
            foreach (DataGridViewColumn columna in dataGridView.Columns)
            {
                if (columna.Visible && columna.Name != "buttonSeleccionar")
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo(columna.Name, columna.HeaderText));
                }
            }
            comboBoxBusqueda.SelectedIndex = 0;
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";

            buttonActualizar_Click(sender, e);

            //MODULO DE SEGURIDAD
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
            menuVerPermisosUsuario.Visible = true;
        }

        private void AbrirModal(string tipoModal, int idUsuario)
        {
            using (var modal = new mdDetallePermisoUsuario(tipoModal, idUsuario))
            {
                var resultado = modal.ShowDialog();
            }
            buttonActualizar_Click(null, null);
        }

        private void menuVerPermisosUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Trim() != "")
            {
                AbrirModal("VerDetalle", Convert.ToInt32(textBoxId.Text));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuEditarPermisosUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Trim() != "")
            {
                AbrirModal("Editar", Convert.ToInt32(textBoxId.Text));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            //MOSTRAR LOS USUARIOS
            List<Usuario> listaUsuarios = oCC_Usuario.ListarUsuarios();
            listaUsuarios = listaUsuarios.OrderBy(p => p.NombreCompleto).ToList();

            foreach (Usuario oUsuario in listaUsuarios)
            {
                dataGridView.Rows.Add(
                    "",
                    oUsuario.IdUsuario,
                    oUsuario.IdPersona,
                    oUsuario.NombreCompleto,
                    oUsuario.Correo,
                    oUsuario.Documento,
                    oUsuario.Estado == true ? 1 : 0,
                    oUsuario.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();

            textBoxId.Text = "";
            textBoxIdPersona.Text = "";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();

            if (dataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridView.Rows)
                {
                    if (fila.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBoxBusqueda.Text.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Text = "";

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                fila.Visible = true;
            }

            dataGridView.ClearSelection();
            textBoxId.Text = "";
            textBoxIdPersona.Text = "";
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
            if (textBoxBusqueda.Text.Trim() == "")
            {
                buttonLimpiar_Click(sender, e);
            }
        }

        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
            if (textBoxBusqueda.Text.Trim() == "")
            {
                buttonLimpiar_Click(sender, e);
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                e.PaintBackground(e.ClipBounds, true);

                var w = Properties.Resources.Seleccion.Width;
                var h = Properties.Resources.Seleccion.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Seleccion, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                textBoxId.Text = dataGridView.Rows[indice].Cells["idUsuario"].Value.ToString();
                textBoxIdPersona.Text = dataGridView.Rows[indice].Cells["idPersona"].Value.ToString();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                menuVerPermisosUsuario_Click(sender, e);
            }
        }
    }
}
