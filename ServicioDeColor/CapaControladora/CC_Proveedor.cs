using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Proveedor
    {
        private CD_Proveedor oCD_Proveedor = new CD_Proveedor();
        public List<Proveedor> ListarProveedores()
        {
            try
            {
                return oCD_Proveedor.ListarProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AgregarProveedor(Proveedor oProveedor, out string mensaje)
        {
            try
            {
                return oCD_Proveedor.AgregarProveedor(oProveedor, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarProveedor(Proveedor oProveedor, out string mensaje)
        {
            try
            {
                return oCD_Proveedor.EditarProveedor(oProveedor, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarProveedor(int idProveedor, out string mensaje)
        {
            try
            {
                return oCD_Proveedor.EliminarProveedor(idProveedor, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
