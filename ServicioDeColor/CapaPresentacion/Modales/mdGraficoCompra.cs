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
    public partial class mdGraficoCompra : Form
    {
        private List<Proveedor> _listaProveedores;
        private CC_Compra oCC_Compra = new CC_Compra();
        string _fechaInicio;
        string _fechaFin;

        public mdGraficoCompra(string fechaInicio, string fechaFin, List<Proveedor> listaProveedores)
        {
            _listaProveedores = listaProveedores;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            InitializeComponent();
        }

        private void mdGraficoCompra_Load(object sender, EventArgs e)
        {
            string[] proveedores = _listaProveedores.Select(p => p.RazonSocial).ToArray();
            int[] compras = new int[_listaProveedores.Count];

            for (int i = 0; i < _listaProveedores.Count; i++)
            {
                //Metodo viejo
                //Proveedor proveedorActual = _listaProveedores[i];
                //int comprasProveedor = oCC_Compra.ListarCompras().Count(c => c.oProveedor.IdProveedor == proveedorActual.IdProveedor);
                //compras[i] = comprasProveedor;

                //Metodo nuevo
                Proveedor proveedorActual = _listaProveedores[i];
                List<Compra> comprasProveedor = oCC_Compra.ListarComprasPorFechaYId(_fechaInicio, _fechaFin, proveedorActual.IdProveedor);
                int numeroCompras = comprasProveedor.Count();
                compras[i] = numeroCompras;
            }

            chartCompra.Titles.Add("Compras");

            for (int i = 0; i < proveedores.Length; i++)
            {
                Series serie = chartCompra.Series.Add(proveedores[i]);
                serie.Label = compras[i].ToString();
                serie.Points.Add(compras[i]);
            }
        }
    }
}
