using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentaCabecera
    {
        public int Id_venta { get; set; }
        public Usuario oUsuario { get; set; }
        public int Nro_Factura { get; set; }
        public string Fecha_venta { get; set; }
        public decimal Total { get; set; }
        public decimal Monto_pago { get; set; }
        public decimal Monto_cambio { get; set; }
        public List<VentaDetalle> oDetalleVenta { get; set; }
        public Cliente oCliente { get; set; }
    }
}
