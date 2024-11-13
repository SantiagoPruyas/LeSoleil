using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Factura
    {
        private CD_Factura objcd_factura = new CD_Factura();

        public List<Factura> Listar()
        {
            return objcd_factura.Listar();
        }
    }
}
