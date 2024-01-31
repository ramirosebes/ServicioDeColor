using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaControladora
{
    public class CC_Cliente
    {
        private CD_Cliente oCD_Cliente = new CD_Cliente();
        public List<Cliente> ListarClientes()
        {
            try
            {
                return oCD_Cliente.ListarClientes();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int AgregarCliente(Cliente oCliente, out string mensaje)
        {
            try
            {
                return oCD_Cliente.AgregarCliente(oCliente, out mensaje);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool EditarCliente(Cliente oCliente, out string mensaje)
        {
            try
            {
                return oCD_Cliente.EditarCliente(oCliente, out mensaje);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public bool EliminarCliente(int idCliente, int idPersona, out string mensaje)
        {
            try
            {
                return oCD_Cliente.EliminarCliente(idCliente, idPersona, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
