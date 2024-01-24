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
        private string ruc;
        private string direccion;
        #endregion

        #region Propiedades
        public int IdNegocio { get { return idNegocio; } set { idNegocio = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string RUC { get { return ruc; } set { ruc = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        #endregion
    }
}
