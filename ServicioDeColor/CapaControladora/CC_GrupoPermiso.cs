using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaControladora
{
    public class CC_GrupoPermiso
    {
        CD_GrupoPermiso oCD_GrupoPermiso = new CD_GrupoPermiso();
        public List<GrupoPermiso> ListarGrupoPermisos()
        {
            try
            {
                return oCD_GrupoPermiso.ListarGrupoPermisos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Componente> ListarComponentes(int idGrupoPermiso)
        {
            try
            {
                return oCD_GrupoPermiso.ListarComponentes(idGrupoPermiso);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool AgregarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return oCD_GrupoPermiso.AgregarGrupoPermiso(oGrupoPermiso, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EditarGrupoPermiso(GrupoPermiso oGrupoPermiso, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return oCD_GrupoPermiso.EditarGrupoPermiso(oGrupoPermiso, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EliminarGrupoPermiso(GrupoPermiso oGrupoPermiso, out string mensaje)
        {
            try
            {
                return oCD_GrupoPermiso.EliminarGrupoPermiso(oGrupoPermiso, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
