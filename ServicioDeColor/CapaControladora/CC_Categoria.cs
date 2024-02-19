using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladora
{
    public class CC_Categoria
    {
        private CD_Categoria oCD_Categoria = new CD_Categoria();

        public List<Categoria> ListarCategorias()
        {
            try
            {
                return oCD_Categoria.ListarCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AgregarCategoria(Categoria oCategoria, out string mensaje)
        {
            try
            {
                return oCD_Categoria.AgregarCategoria(oCategoria, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarCategoria(Categoria oCategoria, out string mensaje)
        {
            try
            {
                return oCD_Categoria.EditarCategoria(oCategoria, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EliminarCategoria(int idCategoria, out string mensaje)
        {
            try
            {
                return oCD_Categoria.EliminarCategoria(idCategoria, out mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
