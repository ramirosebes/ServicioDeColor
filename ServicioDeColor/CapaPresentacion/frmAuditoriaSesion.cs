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
    public partial class frmAuditoriaSesion : Form
    {
        private Usuario _usuarioActual;
        private CC_AuditoriaSesion oCC_AuditoriaSesion = new CC_AuditoriaSesion();

        public frmAuditoriaSesion(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmAuditoriaSesion_Load(object sender, EventArgs e)
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

            menuVerDetalleAuditoriaSesion.Visible = true;

            buttonActualizar_Click(sender, e);
        }

        private void menuVerDetalleAuditoriaSesion_Click(object sender, EventArgs e)
        {
            if (textBoxIdAuditoria.Text != "")
            {
                using (var modal = new mdDetalleAuditoriaSesion(Convert.ToInt32(textBoxIdAuditoria.Text)))
                {
                    var resultado = modal.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        buttonActualizar_Click(null, null);
                    }
                }
                buttonActualizar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            //MOSTRAR LOS Sesion
            List<AuditoriaSesion> listaAuditoriaSesions = oCC_AuditoriaSesion.ListarAuditoriaSesiones();

            foreach (AuditoriaSesion oAuditoriaSesion in listaAuditoriaSesions)
            {
                dataGridView.Rows.Add(
                    "",
                    oAuditoriaSesion.IdAuditoriaSesion,
                    oAuditoriaSesion.DescripcionAuditoria,
                    oAuditoriaSesion.FechaAuditoria,
                    oAuditoriaSesion.oUsuario.IdUsuario,
                    oAuditoriaSesion.oUsuario.IdPersona,
                    oAuditoriaSesion.oUsuario.NombreCompleto,
                    oAuditoriaSesion.oUsuario.Documento,
                    oAuditoriaSesion.oUsuario.Correo,
                    //oAuditoriaSesion.oUsuario.Estado == true ? 1 : 0,
                    oAuditoriaSesion.oUsuario.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();

            textBoxIdAuditoria.Text = "";
            textBoxIdUsuario.Text = "";
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
                textBoxIdAuditoria.Text = dataGridView.Rows[indice].Cells["IdAuditoriaSesion"].Value.ToString();
                textBoxIdUsuario.Text = dataGridView.Rows[indice].Cells["IdUsuario"].Value.ToString();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                menuVerDetalleAuditoriaSesion_Click(sender, e);
            }
        }
    }
}
