using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso : Componente
    {
        #region Variables Privadas
        private int idPermiso;
        private string nombreMenu;
        #endregion

        #region Propiedades
        public int IdPermiso { get { return idPermiso; } set { idPermiso = value; } }
        public string NombreMenu { get { return nombreMenu; } set { nombreMenu = value; } }
        #endregion

        //#region Metodos
        //public static List<Permiso> ListaPermisosCompleta()
        //{
        //    List<Permiso> listaPermisos = new List<Permiso>();

        //    return listaPermisos;
        //}
        //#endregion
    }
}
