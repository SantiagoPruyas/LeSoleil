using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;

namespace LeSoleil_Taller2
{
    public partial class FormReporteGerente2 : Form
    {
        public FormReporteGerente2()
        {
            InitializeComponent();
        }

        public void MostrarProductosVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            string connectionString = Conexion.cadena;

            string query = "EXEC sp_ProductosVendidos @fechaInicio, @fechaFin";  // Llamar al procedimiento almacenado

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Definir los parámetros
                    command.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                    // Ejecutar el procedimiento y llenar el DataGridView
                    connection.Open();
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                    DGVProductosVendidos.DataSource = dt;


                    // Limpiar los datos previos del gráfico
                    CProductosVendidos.Series.Clear();
                    CProductosVendidos.Legends.Clear();

                    // Agregar una nueva serie de tipo 'Pie' (gráfico de torta)
                    var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Productos Vendidos");
                    serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                    // Agregar los valores al gráfico
                    foreach (DataRow row in dt.Rows)
                    {
                        string producto = row["Producto"].ToString();
                        int unidadesVendidas = Convert.ToInt32(row["UnidadesVendidas"]); // Cantidad vendida

                        serie.Points.AddXY(producto, unidadesVendidas);
                    }

                    // Agregar la serie al gráfico
                    CProductosVendidos.Series.Add(serie);

                    // Agregar una leyenda al gráfico
                    CProductosVendidos.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("Productos Vendidos"));


                }
            }
        }

        private void BProductosVendidos_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = fechainicio.Value;  
            DateTime fechaFin = fechafin.Value;        

            // Llamar al método para mostrar los productos vendidos
            MostrarProductosVendidos(fechaInicio, fechaFin);
        }
    }
}
