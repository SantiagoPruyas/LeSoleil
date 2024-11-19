using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Auditoria
    {
        public int Id_auditoria { get; set; }
        public Usuario oUsuario { get; set; }
        public int Estado { get; set; }
        public string Fecha { get; set; }
        public string Ubicacion { get; set; }
    }
}
