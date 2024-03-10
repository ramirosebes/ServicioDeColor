using CapaControladora;
using CapaControladora;
using CapaEntidad;
using CapaPresentacion.Modales;
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
        private CC_Compra oCC_Compra = new CC_Compra();

        public frmReporteCompra(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            //ComboBox Proveedor
            List<Proveedor> lista = new CC_Proveedor().ListarProveedores();

            comboBoxProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });

            foreach (Proveedor item in lista)
            {
                comboBoxProveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }
            comboBoxProveedor.DisplayMember = "Texto";
            comboBoxProveedor.ValueMember = "Valor";
            comboBoxProveedor.SelectedIndex = 0;

            //ComboBox Busqueda
            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0;

            //ComboBox Filtro
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Precio compra" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Precio venta" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Cantidad" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Subtotal" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Monto total" });
            comboBoxColumna.DisplayMember = "Texto";
            comboBoxColumna.ValueMember = "Valor";
            comboBoxColumna.SelectedIndex = 0;

            comboBoxMonto.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Mayor" });
            comboBoxMonto.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Mayor igual" });
            comboBoxMonto.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Igual" });
            comboBoxMonto.Items.Add(new OpcionCombo() { Valor = 3, Texto = "Menor igual" });
            comboBoxMonto.Items.Add(new OpcionCombo() { Valor = 4, Texto = "Menor" });
            comboBoxMonto.DisplayMember = "Texto";
            comboBoxMonto.ValueMember = "Valor";
            comboBoxMonto.SelectedIndex = 0;
        }

        private void buttonBuscar1_Click(object sender, EventArgs e)
        {
            Buscar1();
            textBoxBusqueda.Clear();
            textBoxMonto.Clear();
        }

        private void Buscar1()
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
                    rc.UsuarioRegistro,
                    rc.CUITProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal,
                    rc.MontoTotal
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

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            Buscar2();
            textBoxMonto.Clear();
        }

        private void Buscar2()
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

        private void buttonLimpiar2_Click(object sender, EventArgs e)
        {
            textBoxBusqueda.Clear();
            foreach (DataGridViewRow row in dataGridViewData.Rows)
            {
                row.Visible = true;
            }
        }

        private void buttonLimpiar1_Click(object sender, EventArgs e)
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

        private void buttonGrafico_Click(object sender, EventArgs e)
        {
            string fechaInicio = dateTimePickerFechaInicio.Value.ToString("dd/MM/yyyy");
            string fechaFin = dateTimePickerFechaFin.Value.ToString("dd/MM/yyyy");

            List<Compra> listaCompras = oCC_Compra.ListarCompras();

            if (listaCompras.Count != 0)
            {
                List<Proveedor> listaProveedores;

                if (comboBoxProveedor.SelectedIndex == 0)
                {
                    listaProveedores = new CC_Proveedor().ListarProveedores();
                }
                else
                {
                    int idProveedor = Convert.ToInt32(((OpcionCombo)comboBoxProveedor.SelectedItem).Valor.ToString());
                    Proveedor proveedor = new CC_Proveedor().ListarProveedores().Where(p => p.IdProveedor == idProveedor).FirstOrDefault();
                    listaProveedores = new List<Proveedor>() { proveedor };
                }

                using (var modal = new mdGraficoCompra(fechaInicio, fechaFin, listaProveedores))
                {
                    var resultado = modal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay compras registradas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonBuscar3_Click(object sender, EventArgs e)
        {
            Buscar3();
        }

        private void Buscar3()
        {
            if (dataGridViewData.Rows.Count > 0 && textBoxMonto.Text != "")
            {
                switch (comboBoxColumna.SelectedIndex)
                {
                    case 0:
                        CalcularMonto("PrecioCompra");
                        break;
                    case 1:
                        CalcularMonto("PrecioVenta");
                        break;
                    case 2:
                        CalcularMonto("Cantidad");
                        break;
                    case 3:
                        CalcularMonto("SubTotal");
                        break;
                    case 4:
                        CalcularMonto("MontoTotal");
                        break;
                }
            }
            else if (dataGridViewData.Rows.Count == 0 && textBoxMonto.Text == "")
            {
                //buttonBuscar2_Click(sender, e);
                Buscar2();
            }
        }

        private void CalcularMonto(string columnaFiltro)
        {
            if (dataGridViewData.Rows.Count > 0)
            {
                switch (comboBoxMonto.SelectedIndex)
                {
                    case 0:
                        foreach (DataGridViewRow row in dataGridViewData.Rows) //DataGridViewRow row in dataGridViewData.Rows
                        {
                            if (row.Visible && Convert.ToDecimal(row.Cells[columnaFiltro].Value) > Convert.ToDecimal(textBoxMonto.Text))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        break;
                    case 1:
                        foreach (DataGridViewRow row in dataGridViewData.Rows)
                        {
                            if (row.Visible && Convert.ToDecimal(row.Cells[columnaFiltro].Value) >= Convert.ToDecimal(textBoxMonto.Text))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        break;
                    case 2:
                        foreach (DataGridViewRow row in dataGridViewData.Rows)
                        {
                            if (row.Visible && Convert.ToDecimal(row.Cells[columnaFiltro].Value) == Convert.ToDecimal(textBoxMonto.Text))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        break;
                    case 3:
                        foreach (DataGridViewRow row in dataGridViewData.Rows)
                        {
                            if (row.Visible && Convert.ToDecimal(row.Cells[columnaFiltro].Value) <= Convert.ToDecimal(textBoxMonto.Text))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        break;
                    case 4:
                        foreach (DataGridViewRow row in dataGridViewData.Rows)
                        {
                            if (row.Visible && Convert.ToDecimal(row.Cells[columnaFiltro].Value) < Convert.ToDecimal(textBoxMonto.Text))
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        break;
                }
            }
        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Permitir dígitos
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && textBoxMonto.Text.Length > 0 && !textBoxMonto.Text.Contains("."))
            {
                // Permitir un punto si hay al menos un número y no hay punto previamente
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Permitir teclas de control como retroceso
                e.Handled = false;
            }
            else
            {
                // Bloquear cualquier otro carácter
                e.Handled = true;
            }
        }

        private void textBoxMonto_TextChanged(object sender, EventArgs e)
        {
            //buttonBuscar_Click(sender, e);
            //buttonFiltrarMonto_Click(sender, e);
            //if (textBoxMonto.Text.Trim() == "")
            //{
            //    buttonBuscar_Click(sender, e);
            //}

            Buscar2();
            Buscar3();
            if (textBoxMonto.Text.Trim() == "")
            {
                Buscar2();
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            //buttonBuscar_Click(sender, e);
            //Buscar2();
            buttonBuscar2_Click(sender, e);
            if (textBoxBusqueda.Text.Trim() == "")
            {
                buttonBuscar2_Click(sender, e);
            }
        }

        private void comboBoxColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttonFiltrarMonto_Click(sender, e);
            Buscar2();
            Buscar3();
            if (textBoxMonto.Text.Trim() == "")
            {
                Buscar2();
            }
        }

        private void comboBoxMonto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttonFiltrarMonto_Click(sender, e);
            Buscar2();
            Buscar3();
            if (textBoxMonto.Text.Trim() == "")
            {
                Buscar2();
            }
        }

        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttonBuscar_Click(sender, e);
            buttonBuscar2_Click(sender, e);
        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscar1_Click(sender, e);
        }

        private void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            buttonBuscar1_Click(sender, e);
        }

        private void dateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
        {
            buttonBuscar1_Click(sender, e);
        }

        private void buttonLimpiar3_Click(object sender, EventArgs e)
        {
            textBoxMonto.Clear();
        }
    }
}
