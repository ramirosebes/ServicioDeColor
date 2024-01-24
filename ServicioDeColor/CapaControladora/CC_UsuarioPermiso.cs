using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaControladora
{
    public class CC_UsuarioPermiso
    {
        private CD_UsuarioPermiso oCD_UsuarioPermiso = new CD_UsuarioPermiso();
        public List<Componente> ListarComponentesPorId(int idUsuario)
        {
            try
            {
                return oCD_UsuarioPermiso.ListarComponentesPorId(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool EditarUsuarioPermiso(int idUsuario, DataTable listaComponentes, out string mensaje)
        {
            try
            {
                return oCD_UsuarioPermiso.EditarUsuarioPermiso(idUsuario, listaComponentes, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
