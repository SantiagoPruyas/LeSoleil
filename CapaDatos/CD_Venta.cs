using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int ObtenerNroFactura()
        {
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT count(*) + 1 from VentaCabecera");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Producto set Stock = Stock - @cantidad where Id_producto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Producto set Stock = Stock + @cantidad where Id_producto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool Registrar(VentaCabecera obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("Id_Factura", obj.oFactura.Id_Factura);
                    cmd.Parameters.AddWithValue("Id_cliente", obj.oCliente.Id_cliente);
                    cmd.Parameters.AddWithValue("Nro_Factura", obj.Nro_Factura);
                    cmd.Parameters.AddWithValue("Monto_pago", obj.Monto_pago);
                    cmd.Parameters.AddWithValue("Monto_cambio", obj.Monto_cambio);
                    cmd.Parameters.AddWithValue("Total", obj.Total);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            } catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }

        public VentaCabecera ObtenerVenta(string numero)
        {
            VentaCabecera obj = new VentaCabecera();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT v.Id_venta, u.Nombre[NombreVendedor], c.DNI, c.Nombre[NombreCliente], f.Tipo_Factura, v.Nro_Factura, v.Monto_pago, v.Monto_cambio, v.Total,");
                    query.AppendLine("convert(char(10),v.FechaVenta,103)[FechaRegistro]");
                    query.AppendLine("from VentaCabecera v");
                    query.AppendLine("inner join Usuario u on u.Id_usuario = v.Id_usuario");
                    query.AppendLine("inner join Cliente c on c.Id_cliente = v.Id_cliente");
                    query.AppendLine("inner join Factura f on f.Id_Factura = v.Id_Factura");
                    query.AppendLine("where v.Nro_Factura = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new VentaCabecera()
                            {
                                Id_venta = int.Parse(dr["Id_venta"].ToString()),
                                oUsuario = new Usuario() { Nombre = dr["NombreVendedor"].ToString() },
                                oCliente = new Cliente() { Nombre = dr["NombreCliente"].ToString(), DNI = dr["DNI"].ToString() },
                                oFactura = new Factura() { Tipo_Factura = (dr["Tipo_Factura"].ToString()) },
                                Nro_Factura = dr["Nro_Factura"].ToString(),
                                Monto_pago = Convert.ToDecimal(dr["Monto_pago"].ToString()),
                                Monto_cambio = Convert.ToDecimal(dr["Monto_cambio"].ToString()),
                                Total = Convert.ToDecimal(dr["Total"].ToString()),
                                Fecha_venta = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    obj = new VentaCabecera();
                }
            }
            return obj;
        }

        public List<VentaDetalle> ObtenerDetalleVenta(int idVenta)
        {
            List<VentaDetalle> oLista = new List<VentaDetalle>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Nombre, vd.Cantidad, vd.Precio_venta, vd.Subtotal");
                    query.AppendLine("FROM VentaDetalle vd");
                    query.AppendLine("INNER JOIN Producto p on p.Id_producto = vd.Id_producto");
                    query.AppendLine("WHERE vd.Id_venta = @idVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) 
                        {
                            oLista.Add(new VentaDetalle()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                Precio_venta = Convert.ToDecimal(dr["Precio_venta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                Subtotal = Convert.ToDecimal(dr["Subtotal"].ToString()),
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<VentaDetalle>();
                }
            }
            return oLista;
        }
    }
}
