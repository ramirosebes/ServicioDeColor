using CapaControladora;
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
    public partial class frmReporteCompra : Form
    {
        private Usuario _usuarioActual;

        public frmReporteCompra(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new CC_Proveedor().ListarProveedores();

            comboBoxProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });

            foreach (Proveedor item in lista)
            {
                comboBoxProveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            comboBoxProveedor.DisplayMember = "Texto";
            comboBoxProveedor.ValueMember = "Valor";
            comboBoxProveedor.SelectedIndex = 0;

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
            int idProveedor = Convert.ToInt32(((OpcionCombo)comboBoxProveedor.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CC_Reporte().ListarReporteCompras(
                dateTimePickerFechaInicio.Value.ToString("dd/MM/yyyy"), //Solucion .ToString("dd/MM/yyyy")
                dateTimePickerFechaFin.Value.ToString("dd/MM/yyyy"), //Solucion .ToString("dd/MM/yyyy")
                idProveedor
                );

            dataGridViewData.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.CUITProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
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
                                row.Cells[13].Value.ToString()
                            });
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void buttonLimpiarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(((OpcionCombo)comboBoxProveedor.SelectedItem).Valor.ToString());

            comboBoxProveedor.SelectedIndex = 0;

            List<ReporteCompra> oListaReporteCompras = new List<ReporteCompra>();

            oListaReporteCompras = new CC_Reporte().ListarReporteCompras(
                dateTimePickerFechaInicio.Value.ToString(),
                dateTimePickerFechaFin.Value.ToString(),
                idProveedor
                );

            dataGridViewData.Rows.Clear();

            foreach (ReporteCompra rc in oListaReporteCompras)
            {
                dataGridViewData.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.CUITProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }
    }
}
