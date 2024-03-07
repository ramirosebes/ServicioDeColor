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
    public partial class mdListaProductos : Form
    {
        public Producto _Producto { get; set; }

        public mdListaProductos()
        {
            InitializeComponent();
        }

        private void mdListaProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0;

            List<Producto> lista = new CC_Producto().ListarProductos();

            foreach (Producto item in lista)
            {
                dataGridViewData.Rows.Add(new object[] {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta
                });
            }
        }

        private void dataGridViewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dataGridViewData.Rows[iRow].Cells["idProducto"].Value.ToString()),
                    Codigo = dataGridViewData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = dataGridViewData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dataGridViewData.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dataGridViewData.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dataGridViewData.Rows[iRow].Cells["PrecioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBoxBusqueda.SelectedItem).Valor.ToString();

            if (dataGridViewData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textBoxBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void buttonLimpiarBuscardor_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                row.Visible = true;
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
            if (textBoxBusqueda.Text.Trim() == "")
            {
                buttonLimpiarBuscardor_Click(sender, e);
            }
        }
    }
}
