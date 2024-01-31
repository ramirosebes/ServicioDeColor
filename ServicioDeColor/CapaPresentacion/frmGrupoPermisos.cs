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
    public partial class frmGrupoPermisos : Form
    {
        CC_GrupoPermiso oCC_GrupoPermiso = new CC_GrupoPermiso();
        private Usuario _usuarioActual;
        public frmGrupoPermisos(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmGrupo_Load(object sender, EventArgs e)
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
            menuVerDetalleGrupoPermisos.Visible = true;

            buttonActualizar_Click(sender, e);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            //MOSTRAR LOS GRUPOS
            List<GrupoPermiso> listaGrupoPermisos = oCC_GrupoPermiso.ListarGrupoPermisos();
            listaGrupoPermisos = listaGrupoPermisos.OrderBy(p => p.Nombre).ToList();

            foreach (GrupoPermiso oGrupoPermiso in listaGrupoPermisos)
            {
                dataGridView.Rows.Add(
                    "",
                    oGrupoPermiso.IdGrupoPermiso,
                    oGrupoPermiso.IdComponente,
                    oGrupoPermiso.Nombre,
                    oGrupoPermiso.Estado == true ? 1 : 0,
                    oGrupoPermiso.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();

            textBoxId.Text = "";
            textBoxIdComponente.Text = "";
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
                textBoxId.Text = dataGridView.Rows[indice].Cells["IdGrupoPermiso"].Value.ToString();
                textBoxIdComponente.Text = dataGridView.Rows[indice].Cells["IdComponente"].Value.ToString();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                menuVerGrupo_Click(sender, e);
            }
        }

        private void menuVerGrupo_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                AbrirModal("VerDetalle", Convert.ToInt32(textBoxId.Text));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuAgregarGrupo_Click(object sender, EventArgs e)
        {
            AbrirModal("Agregar", 0);
        }

        private void menuModificarGrupo_Click(object sender, EventArgs e)
        {
            AbrirModal("Editar", Convert.ToInt32(textBoxId.Text));
        }

        private void AbrirModal(string tipoModal, int idGrupoPermiso)
        {
            using (var modal = new mdDetalleGrupoPermiso(tipoModal, idGrupoPermiso))
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    buttonActualizar_Click(null, null);
                }
            }
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
            textBoxIdComponente.Text = "";
        }

        private void menuEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxIdComponente.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el grupo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    GrupoPermiso oGrupoPermiso = new GrupoPermiso();
                    oGrupoPermiso.IdGrupoPermiso = Convert.ToInt32(textBoxId.Text);
                    oGrupoPermiso.IdComponente = Convert.ToInt32(textBoxIdComponente.Text);

                    string mensaje;
                    bool respuesta = oCC_GrupoPermiso.EliminarGrupoPermiso(oGrupoPermiso, out mensaje);

                    if (respuesta)
                    {
                        MessageBox.Show("Grupo eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonActualizar_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
