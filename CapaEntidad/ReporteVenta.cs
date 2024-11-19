using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class ReporteVenta
    {
        public string FechaRegistro {  get; set; }
        public string TipoFactira {  get; set; }
        public string NroFactura {  get; set; }
        public string MontoTotal {  get; set; }
        public string UsuarioRegistro {  get; set; }
        public string DNICliente {  get; set; }
        public string NombreCliente {  get; set; }
        public string CodigoProducto {  get; set; }
        public string NombreProducto {  get; set; }
        public string Categoria {  get; set; }
        public string PrecioVenta {  get; set; }
        public string Cantidad {  get; set; }  
        public string Subtotal {  get; set; }  
    }
}
