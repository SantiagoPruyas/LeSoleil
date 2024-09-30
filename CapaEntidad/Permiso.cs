using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int Id_permiso { get; set; }
        public Perfil oPerfil { get; set; }
        public string Nombre { get; set; }
        public string Fecha_registro { get; set; }
    }
}
