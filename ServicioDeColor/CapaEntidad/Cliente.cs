using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente : Persona
    {
        #region Variables Privadas
        private int idCliente;
        private string telefono;
        private string direccion;
        private string localidad;
        private bool estado;
        #endregion

        #region Propiedades
        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Localidad { get { return localidad; } set { localidad = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        #endregion
    }
}
