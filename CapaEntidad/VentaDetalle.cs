using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class VentaDetalle
    {
        public int Id_detalleVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Precio_venta { get; set; }
        public string Fecha_registro { get; set; }
        public Producto oProducto { get; set; }
    }
}
