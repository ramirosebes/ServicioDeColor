using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Componente
    {
        #region Variables Privadas
        private int idComponente;
        private string nombre;
        private string tipoComponente;
        private bool estado;
        #endregion

        #region Propiedades
        public int IdComponente { get { return idComponente; } set { idComponente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string TipoComponente { get { return tipoComponente; } set { tipoComponente = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        #endregion
    }
}
