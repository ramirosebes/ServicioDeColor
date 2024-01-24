using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        #region Variables Privadas
        private int idCategoria;
        private string descripcion;
        private bool estado;
        private string fechaRegistro;
        #endregion

        #region Propiedades
        public int IdCategoria { get { return idCategoria; } set { idCategoria = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public bool Estado { get { return estado; } set { estado = value; } }
        public string FechaRegistro { get { return fechaRegistro; } set { fechaRegistro = value; } }
        #endregion
    }
}
