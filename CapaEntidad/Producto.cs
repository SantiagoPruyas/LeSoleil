using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int Id_producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria oCategoria { get; set; }
        public CompraCabecera oCompra { get; set; }
        public byte[] Imagen { get; set; }
        public int Stock { get; set; }
        public int Stock_minimo { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta { get; set;}
        public bool Baja { get; set; }
        public string Fecha_registro { get; set; }

    }
}
