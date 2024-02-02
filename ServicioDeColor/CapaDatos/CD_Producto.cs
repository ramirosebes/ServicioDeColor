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
    public class CD_Producto
    {
        public List<Producto> ListarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProducto, Codigo, Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], Stock, PrecioCompra, PrecioVenta, p.Estado from Producto p");
                    query.AppendLine("inner join Categoria c on c.IdCategoria = p.IdCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Producto producto = new Producto();
                        producto.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                        producto.Codigo = dr["Codigo"].ToString();
                        producto.Nombre = dr["Nombre"].ToString();
                        producto.Descripcion = dr["Descripcion"].ToString();
                        producto.oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString() };
                        producto.Stock = Convert.ToInt32(dr["Stock"].ToString());
                        producto.PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString());
                        producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString());
                        producto.Estado = Convert.ToBoolean(dr["Estado"]);


                        listaProductos.Add(producto);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            CD_Conexion.CerrarConexion();
            return listaProductos;
        }

        public int AgregarProducto(Producto oProducto, out string mensaje)
        {
            int productoRegistrado = 0;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("Codigo", oProducto.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", oProducto.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", oProducto.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", oProducto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Stock", oProducto.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", oProducto.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", oProducto.PrecioVenta);
                    cmd.Parameters.AddWithValue("Estado", oProducto.Estado);
                    //PARAMETRO DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    productoRegistrado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    productoRegistrado = 0;
                    mensaje = ex.Message;
                }

                CD_Conexion.CerrarConexion();
                return productoRegistrado;
            }
        }

        public bool EditarProducto(Producto oProducto, out string mensaje)
        {
            bool productoEditado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdProducto", oProducto.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", oProducto.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", oProducto.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", oProducto.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", oProducto.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Stock", oProducto.Stock);
                    cmd.Parameters.AddWithValue("PrecioCompra", oProducto.PrecioCompra);
                    cmd.Parameters.AddWithValue("PrecioVenta", oProducto.PrecioVenta);
                    cmd.Parameters.AddWithValue("Estado", oProducto.Estado);
                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    productoEditado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    productoEditado = false;
                    mensaje = ex.Message;
                }

                CD_Conexion.CerrarConexion();
                return productoEditado;
            }
        }

        public bool EliminarProducto(int idProducto, out string mensaje)
        {
            bool productoEliminado = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = CD_Conexion.ObtenerConexion())
            {
                CD_Conexion.ObtenerConexion();

                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", conexion);

                    //PARAMETROS DE ENTRADA
                    cmd.Parameters.AddWithValue("IdProducto", idProducto);
                    //PARAMETROS DE SALIDA
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                    //TIPO DE COMANDO
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    productoEliminado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    productoEliminado = false;
                    mensaje = ex.Message;
                }

                CD_Conexion.CerrarConexion();
                return productoEliminado;
            }
        }
    }
}
