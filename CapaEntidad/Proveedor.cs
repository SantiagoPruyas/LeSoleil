using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int Id_Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Fecha_creacion { get; set; }
        public bool Baja { get; set; }
        public string CUIT { get; set; }
        public string Razon_social { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    }
}
