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

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Id_producto, Codigo, p.Nombre[NombreProducto], p.Descripcion, c.Id_Categoria, c.Nombre[NombreCategoria], Precio_compra, Precio_venta, Stock, Stock_minimo, Imagen, Baja from Producto p");
                    query.AppendLine("inner join Categoria c on c.Id_Categoria = p.Id_Categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                Id_producto = Convert.ToInt32(dr["Id_Producto"]),
                                Nombre = dr["NombreProducto"].ToString(),
                                Codigo = dr["Codigo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria() { Id_Categoria = Convert.ToInt32(dr["Id_Categoria"]), Nombre = dr["NombreCategoria"].ToString() },
                                Stock = Convert.ToInt32(dr["Stock"]),
                                Stock_minimo = Convert.ToInt32(dr["Stock_minimo"]),
                                Precio_compra = Convert.ToInt32(dr["Precio_compra"]),
                                Precio_venta = Convert.ToInt32(dr["Precio_venta"]),
                                Baja = Convert.ToBoolean(dr["Baja"]),
                                Imagen = dr["Imagen"] == DBNull.Value ? null : (byte[])dr["Imagen"],
                            });
                        }

                    }

                }
                catch (SqlException sqlEx)
                {
                    // Mostramos el error SQL en la consola
                    Console.WriteLine($"Error en la consulta SQL: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    // Mostramos el error general en la consola
                    Console.WriteLine($"Error general: {ex.Message}");
                }
            }

            return lista;
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            int IdProductogenerado = 0;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Precio_compra", obj.Precio_compra);
                    cmd.Parameters.AddWithValue("Precio_venta", obj.Precio_venta);
                    cmd.Parameters.AddWithValue("stock", obj.Stock);
                    cmd.Parameters.AddWithValue("stock_min", obj.Stock_minimo);
                    cmd.Parameters.AddWithValue("Id_Categoria", obj.oCategoria.Id_Categoria);
                    cmd.Parameters.AddWithValue("Imagen", obj.Imagen);
                    cmd.Parameters.AddWithValue("Baja", obj.Baja);
                    cmd.Parameters.Add("IdProductoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdProductogenerado = Convert.ToInt32(cmd.Parameters["IdProductoResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                IdProductogenerado = 0;
                Mensaje = ex.Message;
            }

            return IdProductogenerado;
        }
        public bool Editar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("Id_Producto", obj.Id_producto);
                    cmd.Parameters.AddWithValue("Codigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("Precio_compra", obj.Precio_compra);
                    cmd.Parameters.AddWithValue("Precio_venta", obj.Precio_venta);
                    cmd.Parameters.AddWithValue("stock", obj.Stock);
                    cmd.Parameters.AddWithValue("stock_min", obj.Stock_minimo);
                    cmd.Parameters.AddWithValue("Id_Categoria", obj.oCategoria.Id_Categoria);
                    cmd.Parameters.AddWithValue("Imagen", obj.Imagen);
                    cmd.Parameters.AddWithValue("Baja", obj.Baja);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("Id_Producto", obj.Id_producto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool DarBaja(int Id_Producto, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_BAJAPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", Id_Producto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool DarAlta(int Id_Producto, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_ALTAPRODUCTO", oconexion);
                    cmd.Parameters.AddWithValue("IdProducto", Id_Producto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
