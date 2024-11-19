using CapaEntidad;
using CapaNegocio;
using LeSoleil_Taller2.Utilidades;
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
    public partial class FormReporteGerente : Form
    {
        public FormReporteGerente()
        {
            InitializeComponent();
        }

         private void BBuscar_Click(object sender, EventArgs e)
        {
            string fechaInicio = fechainicio.Value.ToString("dd/MM/yyyy");
            string fechaFin = fechafin.Value.ToString("dd/MM/yyyy");

            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(fechaInicio, fechaFin);

            DGVTotalVentas.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                DGVTotalVentas.Rows.Add(new object[]
                {
                    rv.FechaVenta,
                    rv.TipoFactura,
                    rv.NroFactura,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DNICliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.Subtotal
                });
            }

        }

        private void FormReporteGerente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DGVTotalVentas.Columns)
            {
                cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;
        }

        private void BBuscarFiltro_Click(object sender, EventArgs e)
        {
                string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

                if (DGVTotalVentas.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGVTotalVentas.Rows)
                    {
                        if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                           
                    }
                }
        }

        private void BLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach(DataGridViewRow row in DGVTotalVentas.Rows)
            {
                row.Visible = true;
            }
        }


    }
}
