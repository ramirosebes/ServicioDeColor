using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        #region Variables Privadas
        private int idProveedor;
        private string cuit;
        private string razonSocial;
        private string correo;
        private string telefono;
        private bool estado;
        #endregion

        #region Propiedades
        public int IdProveedor { get { return idProveedor; } set { idProveedor = value; } }
        public string CUIT { get { return cuit; } set { cuit = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        #endregion
    }
}
