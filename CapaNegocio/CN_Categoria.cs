using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {

        private CD_Categoria objcd_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre de la Categoria \n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre de la Categoria \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
        public bool DarBaja(int Id_Categoria, out string Mensaje)
        {
            return objcd_Categoria.DarBaja(Id_Categoria, out Mensaje);
        }
        public bool DarAlta(int Id_Categoria, out string Mensaje)
        {
            return objcd_Categoria.DarAlta(Id_Categoria, out Mensaje);
        }

    }
}
