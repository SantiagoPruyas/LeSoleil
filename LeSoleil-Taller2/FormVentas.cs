using CapaEntidad;
using CapaNegocio;
using LeSoleil_Taller2.Modales;
using LeSoleil_Taller2.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeSoleil_Taller2
{
    public partial class FormVentas : Form
    {
        private Usuario usuario = new Usuario();
        public FormVentas(Usuario usuarioActual)
        {
            InitializeComponent();
            usuario = usuarioActual;
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            TBIdVendedor.Text = usuario.Id_usuario.ToString();
            TBNombreVendedor.Text = usuario.Nombre;

            List<Factura> listaFactura = new CN_Factura().Listar();

            foreach (Factura item in listaFactura)
            {
                CBTipoFactura.Items.Add(new OpcionCombo() { Valor = item.Id_Factura, Texto = item.Tipo_Factura });
                CBTipoFactura.DisplayMember = "Texto";
                CBTipoFactura.ValueMember = "Valor";
                CBTipoFactura.SelectedIndex = 0;
            }

            TBFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TBPrecioTotal.Text = "0";
        }

        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new FormClientes(usuario))
            {
                var res = modal.ShowDialog();
            }
        }

        private void BTBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new mdClientes())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    LId_cliente.Text = modal.pCliente.Id_cliente.ToString();
                    TBDniCliente.Text = modal.pCliente.DNI;
                    TBNombreCliente.Text = modal.pCliente.Nombre;
                    TBApellidoCliente.Text = modal.pCliente.DNI;
                }
                else
                {
                    TBDniCliente.Select();
                }
            }
        }

        private void BTBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LId_producto.Text = modal.pProducto.Id_producto.ToString();
                    TBCodigoProducto.Text = modal.pProducto.Codigo;
                    TBProducto.Text = modal.pProducto.Nombre;
                    TBPrecio.Text = modal.pProducto.Precio_venta.ToString("0.00");
                    TBStock.Text = modal.pProducto.Stock.ToString();
                    DUDCantidad.Select();
                }
                else
                {
                    TBCodigoProducto.Select();
                }
            }
        }

        private void TBCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == TBCodigoProducto.Text && p.Baja == false).FirstOrDefault();

                if (oProducto != null)
                {
                    TBCodigoProducto.BackColor = Color.Aquamarine;
                    LId_producto.Text = oProducto.Id_producto.ToString();
                    TBCodigoProducto.Text = oProducto.Codigo;
                    TBProducto.Text = oProducto.Nombre;
                    TBPrecio.Text = oProducto.Precio_venta.ToString("0.00");
                    TBStock.Text = oProducto.Stock.ToString();
                    DUDCantidad.Select();
                }
                else
                {
                    TBCodigoProducto.BackColor = Color.Magenta;
                    limpiarProducto();
                }
            }
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (DGVProductosVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVProductosVenta.Rows)
                {
                    if (!row.IsNewRow && row.Cells["Subtotal"].Value != null && !string.IsNullOrEmpty(row.Cells["Subtotal"].Value.ToString()))
                    {
                        total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    }
                }
                TBPrecioTotal.Text = total.ToString("0.00");
            }
        }

        private void calcularCambio()
        {
            if(TBPrecioTotal.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(TBPrecioTotal.Text);

            if(TBPago.Text.Trim() == "")
            {
                TBPago.Text = "0";
            }

            if (decimal.TryParse(TBPago.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    TBCambio.Text = "0.00";
                } else
                {
                    decimal cambio = pagacon = total;
                    TBCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void limpiarProducto()
        {
            LId_producto.Text = "0";
            TBCodigoProducto.Text = "0";
            TBProducto.Text = "";
            TBPrecio.Text = "";
            TBStock.Text = "0";
            DUDCantidad.Text = ""; 
        }

        private void DGVProductosVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0){ return; }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.deletepng.Width;
                var h = Properties.Resources.deletepng.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.deletepng, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TBPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") 
                {
                    e.Handled = true;
                } else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") 
                    {
                        e.Handled = false;
                    } else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void DGVProductosVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVProductosVenta.Columns[e.ColumnIndex].Name == "BTEliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(Convert.ToInt32(DGVProductosVenta.Rows[index].Cells["IdProducto"].Value.ToString())
                        , Convert.ToInt32(DGVProductosVenta.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        DGVProductosVenta.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                }
            }
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (LId_cliente.Text == "")
            {
                MessageBox.Show("Debe asignar esta venta a algun cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DGVProductosVenta.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable Detalle_Venta = new DataTable();

            Detalle_Venta.Columns.Add("Id_producto", typeof(int));
            Detalle_Venta.Columns.Add("Precio_venta", typeof(decimal));
            Detalle_Venta.Columns.Add("Cantidad", typeof(int));
            Detalle_Venta.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow row in DGVProductosVenta.Rows)
            {
                if (!row.IsNewRow)
                {
                    Detalle_Venta.Rows.Add(new object[]
                {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["Subtotal"].Value.ToString(),

                });
                }
            }

            int nroFactura = new CN_Venta().ObtenerNroFactura();
            string factura = string.Format("{0:0000}", nroFactura);
            calcularCambio();

            VentaCabecera oVenta = new VentaCabecera()
            {
                oUsuario = new Usuario() { Id_usuario = usuario.Id_usuario },
                oFactura = new Factura() { Id_Factura = (int)((OpcionCombo)CBTipoFactura.SelectedItem).Valor },
                oCliente = new Cliente() { Id_cliente = Convert.ToInt32(LId_cliente.Text)},
                Nro_Factura = factura,
                Monto_pago = Convert.ToDecimal(TBPago.Text),
                Monto_cambio = Convert.ToDecimal(TBCambio.Text),
                Total = Convert.ToDecimal(TBPrecioTotal.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, Detalle_Venta, out mensaje);

            if (respuesta) 
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + factura + "\n\n ¿Desea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(factura);

                limpiarVenta();
            } else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BAgregarProducto_Click(object sender, EventArgs e)
        {
            {
                decimal precio = 0;
                bool producto_existe = false;

                if (int.Parse(TBCodigoProducto.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!decimal.TryParse(TBPrecio.Text, out precio))
                {
                    MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TBPrecio.Select();
                    return;
                }

                if (Convert.ToInt32(TBStock.Text) < Convert.ToInt32(DUDCantidad.Text))
                {
                    MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (DataGridViewRow fila in DGVProductosVenta.Rows)
                {
                    if (fila.Cells["Codigo"].Value != null && fila.Cells["Codigo"].Value.ToString() == TBCodigoProducto.Text)
                    {
                        producto_existe = true;
                        break;
                    }
                }

                if (!producto_existe)
                {
                    bool respuesta = new CN_Venta().RestarStock(Convert.ToInt32(LId_producto.Text), Convert.ToInt32(DUDCantidad.Text));

                    if (respuesta)
                    {
                        DGVProductosVenta.Rows.Add(new object[]
                    {
                    LId_producto.Text,
                    TBCodigoProducto.Text,
                    TBProducto.Text,
                    precio.ToString("0.00"),
                    DUDCantidad.Text,
                    (Convert.ToInt32(DUDCantidad.Text) * precio).ToString("0.00")
                    });

                        calcularTotal();
                        limpiarProducto();
                        TBCodigoProducto.Select();
                    }
                }
            }
        }
        private void TBPago_TextChanged(object sender, EventArgs e)
        {
            calcularCambio();
        }

        private void limpiarVenta()
        {
            TBDniCliente.Text = "";
            LId_cliente.Text = "";
            TBNombreCliente.Text = "";
            TBApellidoCliente.Text = "";
            DGVProductosVenta.Rows.Clear();
            calcularTotal();
            limpiarProducto();
            TBPago.Text = "";
            TBCambio.Text = "";
        }
    }
}
