using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objcd_reporte = new CD_Reporte();

        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }

        public List<ReporteVenta> VentaVendedor(int id_usuario, string fechainicio, string fechafin)
        {
            return objcd_reporte.VentaVendedor(id_usuario, fechainicio, fechafin);
        }
    }
}
