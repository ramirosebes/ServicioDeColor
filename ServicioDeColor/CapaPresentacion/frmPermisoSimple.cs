using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using CapaPresentacion.Modales;

namespace CapaPresentacion
{
    public partial class frmPermisoSimple : Form
    {
        private CC_Permiso oCCPermiso = new CC_Permiso();
        private Usuario _usuarioActual;

        public frmPermisoSimple(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmPermiso_Load(object sender, EventArgs e)
        {
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
            menuVerDetallePermisoSimple.Visible = true;

            buttonActualizar_Click(sender, e);
        }

        private void AbrirModal()
        {
            if (textBoxId.Text.Trim() != "")
            {
                int idPermiso = Convert.ToInt32(textBoxId.Text);

                using (var modal = new mdDetallePermisoSimple(idPermiso))
                {
                    var resultado = modal.ShowDialog();
                }
                buttonActualizar_Click(null, null);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuVerDetallePermisoSimple_Click(object sender, EventArgs e)
        {
            AbrirModal();
        }

        private void menuModificarEstadoPermiso_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text.Trim() != "")
            {
                string estado = dataGridView.Rows[dataGridView.CurrentRow.Index].Cells["estadoValor"].Value.ToString();
                string nuevoEstado = string.Empty;
                bool valorEstado = true;
                if (estado == "Activo")
                {
                    nuevoEstado = "Inactivo";
                    valorEstado = false;
                }
                else
                {
                    nuevoEstado = "Activo";
                    valorEstado = true;
                }

                if (MessageBox.Show("¿Está seguro de cambiar el estado de permiso a " + nuevoEstado + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    bool editado = oCCPermiso.EditarEstado(Convert.ToInt32(textBoxIdComponente.Text), valorEstado, out mensaje);

                    if (editado)
                    {
                        MessageBox.Show("Estado editado correctamente.\nSe recomienda reiniciar el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonActualizar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            //MOSTRAR LOS PERMISOS
            List<Permiso> listaPermisos = oCCPermiso.ListarPermisos();
            listaPermisos = listaPermisos.OrderBy(p => p.Nombre).ToList();

            foreach (Permiso oPermiso in listaPermisos)
            {
                dataGridView.Rows.Add(
                    "",
                    oPermiso.IdPermiso,
                    oPermiso.IdComponente,
                    oPermiso.Nombre,
                    oPermiso.NombreMenu,
                    oPermiso.Estado == true ? 1 : 0,
                    oPermiso.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();

            textBoxId.Text = "";
            textBoxIdComponente.Text = "";
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
                textBoxId.Text = dataGridView.Rows[indice].Cells["idPermiso"].Value.ToString();
                textBoxIdComponente.Text = dataGridView.Rows[indice].Cells["idComponente"].Value.ToString();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                AbrirModal();
            }
        }
    }
}
