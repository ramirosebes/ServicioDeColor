using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
    public partial class frmReporteVentas : Form
    {
        private Usuario _usuarioActual;

        public frmReporteVentas(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            List<Cliente> oListaCliente = new CC_Cliente().ListarClientes();

            comboBoxCliente.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });

            foreach (Cliente item in oListaCliente)
            {
                comboBoxCliente.Items.Add(new OpcionCombo() { Valor = item.IdCliente, Texto = item.NombreCompleto });
            }
            comboBoxCliente.DisplayMember = "Texto";
            comboBoxCliente.ValueMember = "Valor";
            comboBoxCliente.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0;
        }

        private void buttonBuscarResultado_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(((OpcionCombo)comboBoxCliente.SelectedItem).Valor.ToString());

            List<ReporteVenta> oListaReporteCompras = new List<ReporteVenta>();

            oListaReporteCompras = new CC_Reporte().ListarReporteVentas(
                dateTimePickerFechaInicio.Value.ToString("dd/MM/yyyy"),
                dateTimePickerFechaFin.Value.ToString("dd/MM/yyyy"),
                idCliente
                );

            dataGridViewData.Rows.Clear();

            foreach (ReporteVenta rv in oListaReporteCompras)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
        }

        private void buttonDescarcarExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensjae", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dataGridViewData.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dataGridViewData.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[] {
                                row.Cells[0].Value.ToString(),
                                row.Cells[1].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[5].Value.ToString(),
                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[10].Value.ToString(),
                                row.Cells[11].Value.ToString(),
                                row.Cells[12].Value.ToString(),
                            });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
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

        private void buttonLimpiarBuscador_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                row.Visible = true;
            }
        }

        private void buttonLimpiarClientes_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(((OpcionCombo)comboBoxCliente.SelectedItem).Valor.ToString());

            comboBoxCliente.SelectedIndex = 0;

            List<ReporteVenta> oListaReporteCompras = new List<ReporteVenta>();

            oListaReporteCompras = new CC_Reporte().ListarReporteVentas(
                dateTimePickerFechaInicio.Value.ToString("dd/MM/yyyy"),
                dateTimePickerFechaFin.Value.ToString("dd/MM/yyyy"),
                idCliente
                );

            dataGridViewData.Rows.Clear();

            foreach (ReporteVenta rv in oListaReporteCompras)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
        }
    }
}
