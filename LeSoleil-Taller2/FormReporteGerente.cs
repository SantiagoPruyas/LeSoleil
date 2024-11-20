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
using ClosedXML.Excel;

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
                    // Ignorar la fila si es la fila de inserción nueva
                    if (row.IsNewRow)
                        continue;

                    // Verificar si el valor de la celda es null antes de acceder a ToString()
                    if (row.Cells[columnaFiltro].Value != null &&
                    row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
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

        private void BDescargarExcel_Click(object sender, EventArgs e)
        {
            if(DGVTotalVentas.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in DGVTotalVentas.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in DGVTotalVentas.Rows)
                {
                    // Ignorar la fila de inserción nueva
                    if (row.IsNewRow)
                        continue;

                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }



    }
}
