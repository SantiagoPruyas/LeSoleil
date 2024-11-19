using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void BTDescargar_Click(object sender, EventArgs e)
        {
            if (TBBusqueda.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();

            Texto_Html = Texto_Html.Replace("@tipodocumento", TBTipoFactura.Text);
            Texto_Html = Texto_Html.Replace("@numerodocumento", TBFactura.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", TBDNICliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", TBNombreCliente.Text);

            Texto_Html = Texto_Html.Replace("@fecharegistro", TBFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", TBUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in DGVProductosDetalle.Rows)
            {
                if (row.IsNewRow)
                    continue;

                filas += "<tr>";
                filas += "<td>" + row.Cells["nombreProducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", TBPrecioTotalDetalle.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", TBPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", TBMonto.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", TBFactura.Text);
            savefile.Filter = "Pdf files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string filePath = savefile.FileName;
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true // Usa la aplicación predeterminada del sistema
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
