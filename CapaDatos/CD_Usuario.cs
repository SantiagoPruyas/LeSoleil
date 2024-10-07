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
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.Id_Usuario, u.Nombre, u.Apellido, u.Contraseña, u.Baja, u.Usuario, u.Direccion, u.Telefono, u.DNI, u.Sexo, u.Fecha_nacimiento, r.Perfil_id, r.Nombre from Usuario u");
                    query.AppendLine("inner join Perfil r on r.Perfil_id = u.Perfil_id");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
                                Baja = Convert.ToBoolean(dr["Baja"]),
                                DNI = dr["DNI"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Fecha_nacimiento = dr["Fecha_nacimiento"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Sexo = dr["Sexo"].ToString(),
                                oPerfil = new Perfil() { Perfil_id = Convert.ToInt32(dr["Perfil_id"]), Nombre = dr["Nombre"].ToString() }
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

    }
}
