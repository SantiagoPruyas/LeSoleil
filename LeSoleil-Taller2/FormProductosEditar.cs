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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LeSoleil_Taller2
{
    public partial class FormProductosEditar : Form
    {
        private int rowIndex;
        private FormProductos productosForm;  // Referencia al formulario principal

        public byte[] ConvertirImagenABytes(System.Drawing.Image imagen)
        {
            if (imagen == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Guardar la imagen en el MemoryStream en su formato original
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Convertir el contenido del MemoryStream a un array de bytes
                return ms.ToArray();
            }
        }
        private Image RedimensionarImagen(Image imgOriginal, int ancho, int alto)
        {
            Bitmap imgRedimensionada = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(imgRedimensionada))
            {
                g.DrawImage(imgOriginal, 0, 0, ancho, alto);
            }
            return imgRedimensionada;
        }

        public FormProductosEditar(int id, string codigo, string nombre, string stock, string stock_min, string precio_compra, string precio_venta, string descripcion, string categoria, Image imagen, int rowIndex, FormProductos productosForm)
        {
            InitializeComponent();
            this.productosForm = productosForm;
            this.rowIndex = rowIndex;

            // Cargar los valores actuales en los TextBox y demás controles
            LIDProducto.Text = id.ToString();
            TBCodigoProducto.Text = codigo;
            TBNombreProducto.Text = nombre;
            TBStockProducto.Text = stock;
            TBStockMin.Text = stock_min;
            TBPrecioCompra.Text = precio_compra;
            TBPrecioVenta.Text = precio_venta;
            TBDescripcionProducto.Text = descripcion;
            CBCategoriaProducto.Text = categoria;
            PBImagen.Image = imagen;
        }

        private void FormProductosEditar_Load(object sender, EventArgs e)
        {
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                CBCategoriaProducto.Items.Add(new OpcionCombo() { Valor = item.Id_Categoria, Texto = item.Nombre });
                CBCategoriaProducto.DisplayMember = "Texto";
                CBCategoriaProducto.ValueMember = "Valor";
                CBCategoriaProducto.SelectedIndex = 0;
            }
        }

        private void BEditarGuardar_Click(object sender, EventArgs e)
        {
            FormProductos productosForm = (FormProductos)this.Owner;

            string Mensaje = string.Empty;
            int IdProducto = Convert.ToInt32(LIDProducto.Text);

            Producto objProducto = new Producto()
            {
                Id_producto = IdProducto,
                Nombre = TBNombreProducto.Text,
                Descripcion = TBDescripcionProducto.Text,
                Precio_compra = Convert.ToInt32(TBPrecioCompra.Text),
                Precio_venta = Convert.ToInt32(TBPrecioVenta.Text),
                Stock = Convert.ToInt32(TBStockProducto.Text),
                Stock_minimo = Convert.ToInt32(TBStockMin.Text),
                Codigo = TBCodigoProducto.Text,
                oCategoria = new Categoria() { Id_Categoria = Convert.ToInt32(((OpcionCombo)CBCategoriaProducto.SelectedItem).Valor) },
                Imagen = ConvertirImagenABytes(PBImagen.Image),
                Baja = false
            };

            bool resultado = new CN_Producto().Editar(objProducto, out Mensaje);

            if (resultado)
            {
                productosForm.ActualizarProducto(rowIndex, IdProducto, TBCodigoProducto.Text, TBNombreProducto.Text, TBStockProducto.Text, TBStockMin.Text, TBPrecioCompra.Text,
                TBPrecioVenta.Text, TBDescripcionProducto.Text, CBCategoriaProducto.Text, PBImagen.Image);
                this.Close();
            }
            else
            {
                MessageBox.Show(Mensaje);
            }
        }

        private void BEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurar el filtro para que solo muestre archivos de imagen
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png";
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

                            PBImagen.Image = RedimensionarImagen(img,130,110);

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
        private void TBDescripcionProducto_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras y espacios, al menos 2 caracteres y no más de 30 caracteres
            if (!TBDescripcionProducto.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || TBDescripcionProducto.Text.Length < 2 || TBDescripcionProducto.Text.Length > 500)
            {
                MessageBox.Show("La tela debe contener solo letras y tener entre 2 y 500 caracteres.");
                TBDescripcionProducto.Focus();
            }
        }
        private void TBCodigoProducto_Leave(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox y eliminar espacios al principio y al final
            string codigoProducto = TBCodigoProducto.Text.Trim();

            // Verificar que el código de producto tenga entre 8 y 14 dígitos
            if (codigoProducto.Length < 8 || codigoProducto.Length > 14)
            {
                MessageBox.Show("El código de producto debe tener entre 8 y 14 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCodigoProducto.Focus();  // Colocar el foco en el TextBox para corregir
                return;
            }

            // Verificar que el código solo contenga números (no letras ni caracteres especiales)
            if (!codigoProducto.All(char.IsDigit))
            {
                MessageBox.Show("El código de producto no debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBCodigoProducto.Focus();  // Colocar el foco en el TextBox para corregir
                return;
            }
        }

        private void TBImagenProducto_Leave(object sender, EventArgs e)
        {
            // Verificar si el TextBox de la imagen está vacío
            if (string.IsNullOrEmpty(TBImagenProducto.Text))
            {
                // Si el TextBox está vacío, mostrar un mensaje de advertencia
                MessageBox.Show("Por favor, seleccione una imagen para el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Enfocar nuevamente el TextBox para que el usuario pueda corregirlo
                TBImagenProducto.Focus();
            }
        }



    }
}
