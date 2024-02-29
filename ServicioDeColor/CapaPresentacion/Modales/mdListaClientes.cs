using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class mdListaClientes : Form
    {
        public Cliente _Cliente { get; set; }
        public int _idCliente { get; set; }

        public mdListaClientes()
        {
            InitializeComponent();
        }

        private void mdListaClientes_Load(object sender, EventArgs e)
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

            List<Cliente> lista = new CC_Cliente().ListarClientes().Where(c => c.Estado).ToList();
            foreach (Cliente item in lista)
            {
                dataGridViewData.Rows.Add(new object[] { 
                    item.IdCliente, 
                    item.Documento, 
                    item.NombreCompleto
                });
            }
        }

        private void dataGridViewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColumn = e.ColumnIndex;

            if (iRow >= 0 && iColumn > 0)
            {
                _Cliente = new Cliente()
                {
                    IdCliente = Convert.ToInt32(dataGridViewData.Rows[iRow].Cells["idCliente"].Value.ToString()),
                    Documento = dataGridViewData.Rows[iRow].Cells["documento"].Value.ToString(),
                    NombreCompleto = dataGridViewData.Rows[iRow].Cells["nombreCompleto"].Value.ToString()
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

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdDetalleCliente("Agregar", 0))
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _idCliente = modal.idCliente;

                    Cliente oCliente = new CC_Cliente().ListarClientes().Where(c => c.IdCliente == _idCliente).FirstOrDefault();

                    _Cliente = new Cliente()
                    {
                        IdCliente = oCliente.IdCliente,
                        Documento = oCliente.Documento,
                        NombreCompleto = oCliente.NombreCompleto,
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
