using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CapaDatos
{
    public class CD_Auditoria
    {
        public List<Auditoria> Listar()
        {
            List<Auditoria> lista = new List<Auditoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT a.Id_auditoria, u.Nombre, a.Estado, a.Fecha_backup, a.Ubicacion_backup from auditoria_backup a");
                    query.AppendLine("inner join Usuario u on u.Id_usuario = a.Id_usuario  ");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Auditoria()
                            {
                                Id_auditoria = Convert.ToInt32(dr["Id_auditoria"]),
                                oUsuario = new Usuario() { Nombre = dr["Nombre"].ToString() },
                                Estado = Convert.ToInt32(dr["Estado"]),
                                Fecha = dr["Fecha_backup"].ToString(),
                                Ubicacion = dr["Ubicacion_backup"].ToString()
                            });
                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Auditoria>();
                }
            }

            return lista;
        }

        public bool Registrar(int id, out string Mensaje)
        {
            bool respuesta = false;

            string ubicacion = @"C:\BackUps";
            string nombreBackup = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

            // Verificar si la carpeta existe
            if (!Directory.Exists(ubicacion))
            {
                // Si la carpeta no existe, intenta crearla
                Directory.CreateDirectory(ubicacion);
            }
            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_realizar_backup", oconexion);
                    cmd.Parameters.AddWithValue("Id_usuario", id);
                    cmd.Parameters.AddWithValue("ruta_backup", ubicacion);
                    cmd.Parameters.AddWithValue("nombre_backup", nombreBackup);
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 4000).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output; 

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
