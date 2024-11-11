using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre de la Producto \n";
            }

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el Nombre de la Producto \n";
            }


            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre de la Producto \n";
            }

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el Nombre de la Producto \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
        public bool DarBaja(int Id_Producto, out string Mensaje)
        {
            return objcd_Producto.DarBaja(Id_Producto, out Mensaje);
        }
        public bool DarAlta(int Id_Producto, out string Mensaje)
        {
            return objcd_Producto.DarAlta(Id_Producto, out Mensaje);
        }
    }
}
