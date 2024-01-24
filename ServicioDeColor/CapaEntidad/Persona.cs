using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        #region Variables Privadas
        private int idPersona;
        private string nombreCompleto;
        private string correo;
        private string documento;
        #endregion

        #region Propiedades
        public int IdPersona { get { return idPersona; } set { idPersona = value; } }
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Documento { get { return documento; } set { documento = value; } }
        #endregion
    }
}
