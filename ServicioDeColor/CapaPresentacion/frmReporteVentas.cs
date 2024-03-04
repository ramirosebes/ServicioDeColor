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
    public partial class frmReporteVentas : Form
    {
        private Usuario _usuarioActual;
        private CC_Venta oCC_Venta = new CC_Venta();

        public frmReporteVentas(Usuario oUsuario)
        {
            _usuarioActual = oUsuario;
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            //ComboBox Clientes
            List<Cliente> oListaCliente = new CC_Cliente().ListarClientes();

            comboBoxCliente.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });

            foreach (Cliente item in oListaCliente)
            {
                comboBoxCliente.Items.Add(new OpcionCombo() { Valor = item.IdCliente, Texto = item.NombreCompleto });
            }
            comboBoxCliente.DisplayMember = "Texto";
            comboBoxCliente.ValueMember = "Valor";
            comboBoxCliente.SelectedIndex = 0;

            //ComboBox Busqueda
            foreach (DataGridViewColumn columna in dataGridViewData.Columns)
            {
                comboBoxBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            comboBoxBusqueda.DisplayMember = "Texto";
            comboBoxBusqueda.ValueMember = "Valor";
            comboBoxBusqueda.SelectedIndex = 0;

            //ComboBox Filtro
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Precio venta" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Cantidad" });
            comboBoxColumna.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Monto descuento" });
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
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.TipoDescuento,
                    rv.MontoDescuento,
                    rv.SubTotal,
                    rv.MontoTotal
                });
            }

            textBoxBusqueda.Clear();
            textBoxMonto.Clear();
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

            textBoxMonto.Clear();
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

        private void buttonGrafico_Click(object sender, EventArgs e)
        {
            List<Venta> listaVentas = oCC_Venta.ListarVentas();

            if(listaVentas.Count != 0)
            {
                List<Cliente> listaClientes;

                if (comboBoxCliente.SelectedIndex == 0)
                {
                    listaClientes = new CC_Cliente().ListarClientes();
                }
                else
                {
                    int idCliente = Convert.ToInt32(((OpcionCombo)comboBoxCliente.SelectedItem).Valor.ToString());
                    Cliente cliente = new CC_Cliente().ListarClientes().Where(c => c.IdCliente == idCliente).FirstOrDefault();
                    listaClientes = new List<Cliente>() { cliente };
                }

                using (var modal = new mdGraficoVenta(listaClientes))
                {
                    var resultado = modal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay ventas registradas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonFiltrarMonto_Click(object sender, EventArgs e)
        {
            if (dataGridViewData.Rows.Count > 0 && textBoxMonto.Text != "")
            {
                switch (comboBoxColumna.SelectedIndex)
                {
                    case 0:
                        CalcularMonto("PrecioVenta");
                        break;
                    case 1:
                        CalcularMonto("Cantidad");
                        break;
                    case 2:
                        CalcularMonto("montoDescuento");
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
                //MessageBox.Show("Ingrese un monto para filtrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //buttonBuscarResultado_Click(sender, e);
                buttonBuscar_Click(sender, e);
            }
        }

        private void CalcularMonto(string columnaFiltro)
        {
            if (dataGridViewData.Rows.Count > 0)
            {
                switch (comboBoxMonto.SelectedIndex)
                {
                    case 0:
                        foreach (DataGridViewRow row in dataGridViewData.Rows)
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

        private void textBoxMonto_TextChanged(object sender, EventArgs e)
        {
            buttonFiltrarMonto_Click(sender, e);
            if (textBoxMonto.Text.Trim() == "")
            {
                buttonBuscar_Click(sender, e);
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

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
        }

        private void comboBoxColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonFiltrarMonto_Click(sender, e);
        }

        private void comboBoxMonto_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonFiltrarMonto_Click(sender, e);
        }

        private void comboBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscar_Click(sender, e);
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBuscarResultado_Click(sender, e);
        }

        private void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            buttonBuscarResultado_Click(sender, e);
        }

        private void dateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
        {
            buttonBuscarResultado_Click(sender, e);
        }
    }
}
