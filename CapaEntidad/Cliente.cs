﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set;}
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Baja { get; set; }
        public string Fecha_creacion { get; set; }
        public Usuario Usuario_creacion{ get; set; }
    }
}