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
    public partial class frmCliente : Form
    {
        private CC_Cliente oCC_Cliente = new CC_Cliente();
        private Usuario _usuarioActual;

        public frmCliente(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
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
            //foreach (ToolStripMenuItem menu in menu.Items)
            //{
            //    bool encontrado = _usuarioActual.GetPermisos().Any(p => p.NombreMenu == menu.Name);

            //    if (encontrado)
            //    {
            //        menu.Visible = true;
            //    }
            //    else
            //    {
            //        menu.Visible = false;
            //    }
            //}

            menuVerDetalleCliente.Visible = true;

            buttonActualizar_Click(sender, e);
        }

        private void AbrirModal(string tipoModal, int idCliente)
        {
            using (var modal = new mdDetalleCliente(tipoModal, idCliente))
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    buttonActualizar_Click(null, null);
                }
            }
        }

        private void menuVerDetalleCliente_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                AbrirModal("VerDetalle", Convert.ToInt32(textBoxId.Text));
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuAgregarCliente_Click(object sender, EventArgs e)
        {
            AbrirModal("Agregar", 0);
        }

        private void menuEditarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                AbrirModal("Editar", Convert.ToInt32(textBoxId.Text));
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void menuEliminarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                if (MessageBox.Show("¿Está seguro de eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    bool eliminado = oCC_Cliente.EliminarCliente(Convert.ToInt32(textBoxId.Text), Convert.ToInt32(textBoxIdPersona.Text), out mensaje);

                    if (eliminado)
                    {
                        MessageBox.Show("Cliente eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            //MOSTRAR LOS CLIENTES
            List<Cliente> listaClientes = oCC_Cliente.ListarClientes();

            foreach (Cliente oCliente in listaClientes)
            {
                dataGridView.Rows.Add(
                    "",
                    oCliente.IdCliente,
                    oCliente.IdPersona,
                    oCliente.NombreCompleto,
                    oCliente.Correo,
                    oCliente.Documento,
                    oCliente.Telefono,
                    oCliente.Direccion,
                    oCliente.Localidad,
                    oCliente.Estado == true ? 1 : 0,
                    oCliente.Estado == true ? "Activo" : "Inactivo"
                    );
            }

            //CONFIGURA QUE NO ESTE SELECCIONADA NINGUNA FILA
            dataGridView.ClearSelection();

            textBoxId.Text = "";
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
                textBoxId.Text = dataGridView.Rows[indice].Cells["idCliente"].Value.ToString();
                textBoxIdPersona.Text = dataGridView.Rows[indice].Cells["idPersona"].Value.ToString();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFila = e.RowIndex;
            int indiceColumna = e.ColumnIndex;

            if (indiceFila >= 0 && indiceColumna >= 0)
            {
                menuVerDetalleCliente_Click(sender, e);
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
