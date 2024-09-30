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
        public Perfil Perfil_id { get; set; }
        public string Fecha_creacion { get; set; }

    }
}
