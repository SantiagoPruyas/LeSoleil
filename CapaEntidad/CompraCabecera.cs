using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class CompraCabecera
    {
        public int Id_Compra { get; set; }
        public string Fecha_compra { get; set; }
        public decimal Total { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public List<CompraDetalle> oDetalleCompra { get; set; }
    }
}
