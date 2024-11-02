using CapaEntidad;
using LeSoleil_Taller2.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LeSoleil_Taller2
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCamposProducto()
        {
            // Limpiar los TextBox
            TBNombreProducto.Text = "";
            TBPrecioCompra.Text = "";
            TBStockProducto.Text = "";
            TBTelaProducto.Text = "";
            TBPrecioVenta.Text = "";
            TBStockMin.Text = "";
            TBImagenProducto.Text = "";

            // Limpiar el ComboBox
            CBCategoriaProducto.SelectedIndex = -1;
        }

        private void TBNombreProducto_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras y espacios, al menos 2 caracteres y no más de 50 caracteres
            if (!TBNombreProducto.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || TBNombreProducto.Text.Length < 2 || TBNombreProducto.Text.Length > 50)
            {
                MessageBox.Show("El nombre del producto debe contener solo letras y espacios, y tener entre 2 y 50 caracteres.");
                TBNombreProducto.Focus();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(TBNombreProducto.Text))
                {
                    TBNombreProducto.Text = char.ToUpper(TBNombreProducto.Text[0]) + TBNombreProducto.Text.Substring(1).ToLower();
                }
            }
        }
        private void TBPrecioCompra_Leave(object sender, EventArgs e)
        {
            // Validación de que sea un número decimal positivo
            if (!decimal.TryParse(TBPrecioCompra.Text, out decimal precio) || precio <= 0)
            {
                //MessageBox.Show("El precio debe ser un número decimal positivo.");
                MessageBox.Show("El precio debe ser un valor numérico.");
                TBPrecioCompra.Focus();
            }
        }

        // Validación para el Stock
        private void TBStockProducto_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga números y sea positivo
            if (!int.TryParse(TBStockProducto.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero.");
                TBStockProducto.Focus();
            }
        }

        // Validación para la Tela
        private void TBTelaProducto_Leave(object sender, EventArgs e)
        {
                // Validación de que solo contenga letras y espacios, al menos 2 caracteres y no más de 30 caracteres
                if (!TBTelaProducto.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || TBTelaProducto.Text.Length < 2 || TBTelaProducto.Text.Length > 30)
                {
                    MessageBox.Show("La tela debe contener solo letras y tener entre 2 y 30 caracteres.");
                    TBTelaProducto.Focus();
                }
        }

        // Validación para el Precio de Venta
        private void TBPrecioVenta_Leave(object sender, EventArgs e)
        {
                // Validación de que sea un número decimal positivo
                if (!decimal.TryParse(TBPrecioVenta.Text, out decimal precioVenta) || precioVenta <= 0)
                {
                    MessageBox.Show("El precio de venta debe ser un número decimal");
                    TBPrecioVenta.Focus();
                }
        }

        // Validación para el Stock Mínimo
        private void TBStockMin_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga números y sea positivo
            if (!int.TryParse(TBStockMin.Text, out int stockMinimo) || stockMinimo < 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero.");
                TBStockMin.Focus();
            }
        }

        // Validación para la Categoría
        private void CBCategoriaProducto_Leave(object sender, EventArgs e)
        {
                // Validar que se haya seleccionado una opción en el ComboBox
                if (CBCategoriaProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una categoría.");
                    CBCategoriaProducto.Focus();
                }
        }

        private void TBImagenProducto_Leave(object sender, EventArgs e)
        {
            
        }

        private void BSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurar el filtro para que solo muestre archivos de imagen
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccione una imagen";

                // Mostrar el cuadro de diálogo y verificar si se seleccionó un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Verificar que el archivo seleccionado sea efectivamente una imagen
                    try
                    {
                        // Intentar cargar la imagen para asegurarse de que el archivo es válido
                        using (System.Drawing.Image img = System.Drawing.Image.FromFile(openFileDialog.FileName))
                        {
                            // Asignar la ruta del archivo al TextBox
                            TBImagenProducto.Text = openFileDialog.FileName;
                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        // Ocurre si el archivo no es una imagen válida
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBImagenProducto.Clear();
                    }
                }
            }
        }

        private void DGVProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 10)
                {
                    // Pintar la celda normal
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Verificar el encabezado de la columna para determinar qué imagen pintar
                    if (DGVProductos.Columns[10].HeaderText == "Dar de Alta")
                    {
                        // Pintar la imagen de "Dar de Alta"
                        var w = Properties.Resources.altapng.Width;
                        var h = Properties.Resources.altapng.Height;
                        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                        e.Graphics.DrawImage(Properties.Resources.altapng, new Rectangle(x, y, w, h));
                    }
                    else
                    {
                        // Pintar la imagen de "Dar de Baja"
                        var w = Properties.Resources.deletepng.Width;
                        var h = Properties.Resources.deletepng.Height;
                        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                        var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                        e.Graphics.DrawImage(Properties.Resources.deletepng, new Rectangle(x, y, w, h));
                    }

                    // Marcar como pintado
                    e.Handled = true;
                }

                if (e.ColumnIndex == 9)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = Properties.Resources.editpng.Width;
                    var h = Properties.Resources.editpng.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Properties.Resources.editpng, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }

        private void BGuardarProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void BCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }
    }
    }

