using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public int ObtenerNroFactura()
        {
            return objcd_venta.ObtenerNroFactura();
        }

        public bool Registrar(VentaCabecera obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

        public bool RestarStock(int codigoproducto, int cantidad)
        {
            return objcd_venta.RestarStock(codigoproducto, cantidad);   
        }

        public bool SumarStock(int codigoproducto, int cantidad)
        {
            return objcd_venta.SumarStock(codigoproducto, cantidad);
        }

        public VentaCabecera ObtenerVenta (string numero)
        {
            VentaCabecera oVenta = objcd_venta.ObtenerVenta(numero);

            if(oVenta.Id_venta != 0 )
            {
                List<VentaDetalle> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.Id_venta);
                oVenta.oDetalleVenta = oDetalleVenta;
            }

            return oVenta;
        }
    }
}
