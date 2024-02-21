using CapaControladora;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Modales
{
    public partial class mdGraficoVenta : Form
    {
        private List<Cliente> _listaClientes;
        private CC_Venta oCC_Venta = new CC_Venta();

        public mdGraficoVenta(List<Cliente> listaClientes)
        {
            _listaClientes = listaClientes;
            InitializeComponent();
        }

        private void mdGraficoVenta_Load(object sender, EventArgs e)
        {
            string[] clientes = _listaClientes.Select(c => c.NombreCompleto).ToArray();
            int[] ventas = new int[_listaClientes.Count];

            for (int i = 0; i < _listaClientes.Count; i++)
            {
                Cliente clienteActual = _listaClientes[i];
                int ventasCliente = oCC_Venta.ListarVentas().Count(v => v.oCliente.IdCliente == clienteActual.IdCliente);
                ventas[i] = ventasCliente;
            }

            chartVenta.Titles.Add("Ventas");

            for (int i = 0; i < clientes.Length; i++)
            {
                Series serie = chartVenta.Series.Add(clientes[i]);
                serie.Label = ventas[i].ToString();
                serie.Points.Add(ventas[i]);
            }
        }
    }
}
