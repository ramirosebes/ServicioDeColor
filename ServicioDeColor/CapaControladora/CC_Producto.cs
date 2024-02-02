using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Producto
    {
        private CD_Producto oCD_Producto = new CD_Producto();

        public List<Producto> ListarProductos()
        {
            try
            {
                return oCD_Producto.ListarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AgregarProducto(Producto oProducto, out string mensaje)
        {
            try
            {
                return oCD_Producto.AgregarProducto(oProducto, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarProducto(Producto oProducto, out string mensaje)
        {
            try
            {
                return oCD_Producto.EditarProducto(oProducto, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarProducto(int idProducto, out string mensaje)
        {
            try
            {
                return oCD_Producto.EliminarProducto(idProducto, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}