using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Proveedor \n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Proveedor \n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Telefono del Proveedor \n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Es necesario el Email del Proveedor \n";
            }

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el CUIT del Proveedor \n";
            }

            if (obj.Razon_social == "")
            {
                Mensaje += "Es necesaria la Razon social del Proveedor \n";
            }

            if (obj.Ciudad == "")
            {
                Mensaje += "Es necesaria la Ciudad del Proveedor \n";
            }

            if (obj.Pais == "")
            {
                Mensaje += "Es necesario el Pais del Proveedor \n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Proveedor \n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Proveedor \n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Telefono del Proveedor \n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Es necesario el Email del Proveedor \n";
            }

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el CUIT del Proveedor \n";
            }

            if (obj.Razon_social == "")
            {
                Mensaje += "Es necesaria la Razon social del Proveedor \n";
            }

            if (obj.Ciudad == "")
            {
                Mensaje += "Es necesaria la Ciudad del Proveedor \n";
            }

            if (obj.Pais == "")
            {
                Mensaje += "Es necesario el Pais del Proveedor \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
        public bool DarBaja(int Id_Proveedor, out string Mensaje)
        {
            return objcd_Proveedor.DarBaja(Id_Proveedor, out Mensaje);
        }
        public bool DarAlta(int Id_Proveedor, out string Mensaje)
        {
            return objcd_Proveedor.DarAlta(Id_Proveedor, out Mensaje);
        }
    }
}
