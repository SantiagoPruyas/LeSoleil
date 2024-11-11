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
                imagen.Save(ms, imagen.RawFormat);
                // Convertir el contenido del MemoryStream a un array de bytes
                return ms.ToArray();
            }
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
        public FormProductosEditar(int id, string codigo, string nombre, string stock, string stock_min, string precio_compra, string precio_venta, string descripcion, string categoria, byte[] imagen, int rowIndex, FormProductos productosForm)
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
            PBImagen.Image = ConvertirBytesAImagen(imagen);
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
                Precio_compra = Convert.ToDecimal(TBPrecioCompra),
                Precio_venta = Convert.ToDecimal(TBPrecioVenta),
                Stock = Convert.ToInt32(TBStockProducto),
                Stock_minimo = Convert.ToInt32(TBStockMin),
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
                            TBImagen.Text = openFileDialog.FileName;

                            PBImagen.Image = img;

                        }
                    }
                    catch (OutOfMemoryException)
                    {
                        // Ocurre si el archivo no es una imagen válida
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TBImagen.Clear();
                    }
                }
            }
        }
    }
}
