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
    public class CD_permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Perfil_id,p.Nombre from Permiso p ");
                    query.AppendLine("inner join Perfil r on r.Perfil_id = p.Perfil_id");
                    query.AppendLine("inner join Usuario u on u.Perfil_id = r.Perfil_id");
                    query.AppendLine("where u.Id_usuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oPerfil = new Perfil() { Perfil_id = Convert.ToInt32(dr["Perfil_id"]) },
                                Nombre = dr["Nombre"].ToString(),
                            });
                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }

    }
}
