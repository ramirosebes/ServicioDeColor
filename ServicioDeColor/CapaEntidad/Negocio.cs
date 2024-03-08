using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Negocio
    {
        #region Variables Privadas
        private int idNegocio;
        private string nombre;
        private string cuit;
        private string direccion;
        private string correo;
        private string clave;
        #endregion

        #region Propiedades
        public int IdNegocio { get { return idNegocio; } set { idNegocio = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string CUIT { get { return cuit; } set { cuit = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Clave { get { return clave; } set { clave = value; } }
        #endregion
    }
}
