using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CompraDetalle
    {
        public int Id_detalleCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta { get; set; }
        public string Fecha_registro { get; set; }
        public Producto oProducto { get; set; }
    }
}
