﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.DNI == "")
            {
                Mensaje += "Es necesario el DNI del Cliente \n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Cliente \n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Cliente \n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Cliente \n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Telefono del Cliente \n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Es necesario el Email del Cliente \n";
            }

            if (obj.Fecha_nacimiento == "")
            {
                Mensaje += "Es necesario la Fecha de Nacimiento del Cliente \n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.DNI == "")
            {
                Mensaje += "Es necesario el DNI del Cliente \n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el Nombre del Cliente \n";
            }

            if (obj.Apellido == "")
            {
                Mensaje += "Es necesario el Apellido del Cliente \n";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario la Direccion del Cliente \n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el Telefono del Cliente \n";
            }

            if (obj.Email == "")
            {
                Mensaje += "Es necesario el Email del Cliente \n";
            }

            if (obj.Fecha_nacimiento == "")
            {
                Mensaje += "Es necesario la Fecha de Nacimiento del Cliente \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }
        public bool DarBaja(int Id_Cliente, out string Mensaje)
        {
            return objcd_Cliente.DarBaja(Id_Cliente, out Mensaje);
        }
        public bool DarAlta(int Id_Cliente, out string Mensaje)
        {
            return objcd_Cliente.DarAlta(Id_Cliente, out Mensaje);
        }
    }
}
