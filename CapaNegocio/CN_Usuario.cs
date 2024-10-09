using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_usuario objcd_usuario = new CD_usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Usuario \n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Usuario \n";
            }

            if (obj.Contraseña == "")
            {
                Mensaje += "Es necesario la Contraseña del Usuario \n";
            }

            if(Mensaje != string.Empty)
            {
                return 0;
            } else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Usuario \n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Usuario \n";
            }

            if (obj.Contraseña == "")
            {
                Mensaje += "Es necesario la Contraseña del Usuario \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            } else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
        public bool DarBaja(int Id_usuario, out string Mensaje)
        {
            return objcd_usuario.DarBaja(Id_usuario, out Mensaje);
        }
    }
}
