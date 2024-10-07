using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select Id_usuario,Nombre,Apellido,Usuario,Contraseña,Baja from Usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                User = dr["Usuario"].ToString(),
                                Contraseña = dr["Contraseña"].ToString(),
                                Baja = Convert.ToBoolean(dr["Baja"])
                            });
                        }

                    }

                } catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }

            return lista;
        }

    }
}
