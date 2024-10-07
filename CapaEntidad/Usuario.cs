using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        public bool Baja { get; set; }
        public Perfil oPerfil { get; set; }
        public string Fecha_creacion { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }
    }
}
