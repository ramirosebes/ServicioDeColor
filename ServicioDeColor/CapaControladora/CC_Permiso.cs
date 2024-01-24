using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaControladora
{
    public class CC_Permiso
    {
        private CD_Permiso oCD_Permiso = new CD_Permiso();
        public List<Permiso> ListarPermisosPorId(int idUsuario)
        {
            try
            {
                return oCD_Permiso.ListarPermisosPorId(idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Permiso> ListarPermisos()
        {
            try
            {
                return oCD_Permiso.ListarPermisos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EditarEstado(int idComponente, bool estado, out string mensaje)
        {
            try
            {
                return oCD_Permiso.EditarEstado(idComponente, estado, out mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
