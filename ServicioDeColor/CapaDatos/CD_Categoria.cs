using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Idcategoria, Descripcion, Estado from Categoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                        categoria.Descripcion = dr["Descripcion"].ToString();
                        categoria.Estado = Convert.ToBoolean(dr["Estado"]);

                        listaCategorias.Add(categoria);
                    }

                }
                catch (Exception ex)
                {
                    listaCategorias = new List<Categoria>();
                }
            }

            CD_Conexion.CerrarConexion();
            return listaCategorias;
        }

        public int AgregarCategoria(Categoria oCategoria, out string mensaje)
        {
            int categoriaRegistrada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", oCategoria.Estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    categoriaRegistrada = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                categoriaRegistrada = 0;
                mensaje = ex.Message;
            }

            CD_Conexion.CerrarConexion();
            return categoriaRegistrada;
        }

        public bool EditarCategoria(Categoria obj, out string mensaje)
        {
            bool categoriaEditada = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCategoria", conexion);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    categoriaEditada = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                categoriaEditada = false;
                mensaje = ex.Message;
            }

            CD_Conexion.CerrarConexion();
            return categoriaEditada;
        }

        public bool EliminarCategoria(int idCategoria, out string mensaje)
        {
            bool categoriaEliminada = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdCategoria", idCategoria);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    categoriaEliminada = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                categoriaEliminada = false;
                mensaje = ex.Message;
            }

            CD_Conexion.CerrarConexion();
            return categoriaEliminada;
        }
    }
}
