﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        public int Id_categoria { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Fecha_creacion { get; set; }
    }
}