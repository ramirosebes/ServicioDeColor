using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        #region Variables Privadas
        private int idProducto;
        private string codigo;
        private string nombre;
        private string descripcion;
        private Categoria categoria;
        private int stock;
        private decimal precioCompra;
        private decimal precioVenta;
        private bool estado;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdProducto { get { return idProducto; } set { idProducto = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Categoria oCategoria { get { return categoria; } set { categoria = value; } }
        public int Stock { get { return stock; } set { stock = value; } }
        public decimal PrecioCompra { get { return precioCompra; } set { precioCompra = value; } }
        public decimal PrecioVenta { get { return precioVenta; } set { precioVenta = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
