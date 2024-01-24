using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class GrupoPermiso : Componente
    {
        #region Variables Privadas
        private int idGrupoPermiso;
        private string nombreGrupo;
        #endregion

        #region Propiedades
        public int IdGrupoPermiso { get { return idGrupoPermiso; } set { idGrupoPermiso = value; } }
        public string NombreGrupo { get { return nombreGrupo; } set { nombreGrupo = value; } }
        #endregion
    }
}
