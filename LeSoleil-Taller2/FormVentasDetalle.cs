using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeSoleil_Taller2
{
    public partial class FormVentasDetalle : Form
    {
        public FormVentasDetalle()
        {
            InitializeComponent();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            VentaCabecera oVenta = new CN_Venta().ObtenerVenta(TBBusqueda.Text);
            if (oVenta.Id_venta != 0)
            {
                TBFactura.Text = oVenta.Nro_Factura;

                TBFecha.Text = oVenta.Fecha_venta;
                TBTipoFactura.Text = oVenta.oFactura.Tipo_Factura;
                TBUsuario.Text = oVenta.oUsuario.Nombre;

                TBNombreCliente.Text = oVenta.oCliente.Nombre;
                TBDNICliente.Text = oVenta.oCliente.DNI;

                DGVProductosDetalle.Rows.Clear();
                foreach (VentaDetalle vd in oVenta.oDetalleVenta)
                {
                    DGVProductosDetalle.Rows.Add(new object[] { vd.oProducto.Nombre, vd.Precio_venta, vd.Cantidad, vd.Subtotal });
                }

                TBPrecioTotalDetalle.Text = oVenta.Total.ToString("0.00");
                TBPago.Text = oVenta.Monto_pago.ToString("0.00");
                TBMonto.Text = oVenta.Monto_cambio.ToString("0.00");
            } else
            {
                MessageBox.Show("No se encuentra una factura con ese numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TBBusqueda.Text = "";
            TBFactura.Text = "";

            TBFecha.Text = "";
            TBTipoFactura.Text = "";
            TBUsuario.Text = "";

            TBNombreCliente.Text = "";
            TBDNICliente.Text = "";

            TBPrecioTotalDetalle.Text = "0.00";
            TBPago.Text = "0.00";
            TBMonto.Text = "0.00";
        }

        private void FormVentasDetalle_Load(object sender, EventArgs e)
        {
            TBBusqueda.Select();
        }
    }
}
