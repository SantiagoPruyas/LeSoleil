using CapaEntidad;
using CapaNegocio;
using LeSoleil_Taller2.Utilidades;
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

namespace LeSoleil_Taller2.Modales
{ 
    public partial class mdProductos : Form
    {
        public Producto pProducto { get; set; }
        public mdProductos()
        {
            InitializeComponent();
        }

        private System.Drawing.Image RedimensionarImagen(System.Drawing.Image imgOriginal, int ancho, int alto)
        {
            Bitmap imgRedimensionada = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(imgRedimensionada))
            {
                g.DrawImage(imgOriginal, 0, 0, ancho, alto);
            }
            return imgRedimensionada;
        }


        public System.Drawing.Image ConvertirBytesAImagen(byte[] bytesImagen)
        {
            if (bytesImagen == null || bytesImagen.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(bytesImagen))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void mdProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DGVProductos.Columns)
            {
                if (columna.Visible == true)
                {
                    CBBusquedaProducto.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            CBBusquedaProducto.DisplayMember = "Texto";
            CBBusquedaProducto.ValueMember = "Valor";
            CBBusquedaProducto.SelectedIndex = 0;

            List<Producto> listaProducto = new CN_Producto().Listar().Where(u => u.Baja == false).ToList();

            foreach (Producto item in listaProducto)
            {
                DGVProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo,
                    item.Nombre,
                    item.Stock,
                    item.Stock_minimo,
                    item.Precio_venta,
                    item.oCategoria.Nombre,
                    RedimensionarImagen(ConvertirBytesAImagen(item.Imagen),130,110),
                });
            }
        }

        private void DGVProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                pProducto = new Producto()
                {
                    Id_producto = Convert.ToInt32(DGVProductos.Rows[iRow].Cells["IdProducto"].Value.ToString()),
                    Codigo = DGVProductos.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Nombre = DGVProductos.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(DGVProductos.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Precio_venta = Convert.ToDecimal(DGVProductos.Rows[iRow].Cells["Precio"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BTBuscarProducto_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusquedaProducto.SelectedItem).Valor.ToString();

            if (DGVProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVProductos.Rows)
                {
                    // Ignorar la fila si es la fila de inserción nueva
                    if (row.IsNewRow)
                        continue;

                    // Verificar si el valor de la celda es null antes de acceder a ToString()
                    if (row.Cells[columnaFiltro].Value != null &&
                        row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusquedaProducto.Text.Trim().ToUpper()))
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

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBusquedaProducto.Text = "";
            foreach (DataGridViewRow row in DGVProductos.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
