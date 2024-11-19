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
using System.Windows.Controls;
using System.Windows.Forms;

namespace LeSoleil_Taller2
{
    public partial class FormProductos : Form
    {
        byte[] imagenBytes;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void LimpiarCamposProducto()
        {
            // Limpiar los TextBox
            TBNombreProducto.Text = "";
            TBPrecioCompra.Text = "";
            TBStockProducto.Text = "";
            TBDescripcion.Text = "";
            TBPrecioVenta.Text = "";
            TBStockMin.Text = "";
            TBImagenProducto.Text = "";
            TBCodigoProducto.Text = "";

            // Limpiar el ComboBox
            CBCategoriaProducto.SelectedIndex = -1;
            imagenBytes = null;
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

        private void BSeleccionarImagen_Click(object sender, EventArgs e)
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

                            // Convertir la imagen a un array de bytes
                            using (MemoryStream ms = new MemoryStream())
                            {
                                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Guardar la imagen en el stream en formato jpeg
                                imagenBytes = ms.ToArray();  // Obtener el array de bytes
                            }

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

            if (e.ColumnIndex == 11)
            {
                // Pintar la celda normal
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Verificar el encabezado de la columna para determinar qué imagen pintar
                if (DGVProductos.Columns[11].HeaderText == "Dar de Alta")
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

            if (e.ColumnIndex == 10)
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
            string Mensaje = string.Empty;

            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBNombreProducto.Text) &&
                !string.IsNullOrWhiteSpace(TBDescripcion.Text) &&
                !string.IsNullOrWhiteSpace(TBPrecioCompra.Text) &&
                !string.IsNullOrWhiteSpace(TBPrecioVenta.Text) &&
                !string.IsNullOrWhiteSpace(TBStockProducto.Text) &&
                !string.IsNullOrWhiteSpace(TBStockMin.Text) &&
                !string.IsNullOrWhiteSpace(TBCodigoProducto.Text) &&
                !string.IsNullOrWhiteSpace(CBCategoriaProducto.Text))
            {
                Producto objProducto = new Producto()
                {
                    Nombre = TBNombreProducto.Text,
                    Descripcion = TBDescripcion.Text,
                    Precio_compra = Convert.ToInt32(TBPrecioCompra.Text),
                    Precio_venta = Convert.ToInt32(TBPrecioVenta.Text),
                    Stock = Convert.ToInt32(TBStockProducto.Text),
                    Stock_minimo = Convert.ToInt32(TBStockMin.Text),
                    Codigo = TBCodigoProducto.Text,
                    oCategoria = new Categoria() { Id_Categoria = Convert.ToInt32(((OpcionCombo)CBCategoriaProducto.SelectedItem).Valor) },
                    Imagen = imagenBytes,
                    Baja = false
                };

                int IdProductoGenerado = new CN_Producto().Registrar(objProducto, out Mensaje);

                if (IdProductoGenerado != 0)
                {
                    if (DGVProductos.Columns[11].HeaderText == "Dar de Baja")
                    {
                        // Adicionar nuevo renglón en el DataGridView
                        int n = DGVProductos.Rows.Add();

                        // Colocar la información en las celdas correspondientes
                        DGVProductos.Rows[n].Cells[0].Value = IdProductoGenerado;
                        DGVProductos.Rows[n].Cells[1].Value = TBCodigoProducto.Text;
                        DGVProductos.Rows[n].Cells[2].Value = TBNombreProducto.Text;
                        DGVProductos.Rows[n].Cells[3].Value = TBStockProducto.Text;
                        DGVProductos.Rows[n].Cells[4].Value = TBStockMin.Text;
                        DGVProductos.Rows[n].Cells[5].Value = TBPrecioCompra.Text;
                        DGVProductos.Rows[n].Cells[6].Value = TBPrecioVenta.Text;
                        DGVProductos.Rows[n].Cells[7].Value = TBDescripcion.Text;
                        DGVProductos.Rows[n].Cells[8].Value = CBCategoriaProducto.Text;
                        DGVProductos.Rows[n].Cells[9].Value = RedimensionarImagen(ConvertirBytesAImagen(imagenBytes),130,110);

                        LimpiarCamposProducto();

                        MessageBox.Show("Producto guardado exitosamente.");
                    }
                    else
                    {
                        LimpiarCamposProducto();

                        MessageBox.Show("Producto guardado exitosamente.");
                    }
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void BCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                CBCategoriaProducto.Items.Add(new OpcionCombo() { Valor = item.Id_Categoria, Texto = item.Nombre });
                CBCategoriaProducto.DisplayMember = "Texto";
                CBCategoriaProducto.ValueMember = "Valor";
                CBCategoriaProducto.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in DGVProductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "editarProducto" && columna.Name != "bajaProducto")
                {
                    CBBusquedaProducto.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            CBBusquedaProducto.DisplayMember = "Texto";
            CBBusquedaProducto.ValueMember = "Valor";
            CBBusquedaProducto.SelectedIndex = 0;

            // Mostrar todos los usuarios activos en la tabla
            List<Producto> listaProducto = new CN_Producto().Listar().Where(u => u.Baja == false).ToList();

            foreach (Producto item in listaProducto)
            {
                DGVProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo,
                    item.Nombre,
                    item.Stock,
                    item.Stock_minimo,
                    item.Precio_compra,
                    item.Precio_venta,
                    item.Descripcion,
                    item.oCategoria.Nombre,
                    RedimensionarImagen(ConvertirBytesAImagen(item.Imagen),130,110),
                });
            }
        }

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_producto = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells[0].Value);
            string Mensaje = string.Empty;

            // Verificar si la celda clickeada es el botón "bajaProducto"
            if (e.ColumnIndex == DGVProductos.Columns["bajaProducto"].Index && e.RowIndex >= 0)
            {
                if (DGVProductos.Columns[11].HeaderText == "Dar de Alta")
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVProductos.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de alta este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el usuario presiona 'Sí', dar de baja el usuario
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Producto().DarAlta(Id_producto, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Producto dado de alta del sistema!");
                                DGVProductos.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta al producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVProductos.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el usuario presiona 'Sí', dar de baja el usuario
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Producto().DarBaja(Id_producto, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Producto dado de baja del sistema!");
                                DGVProductos.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja al producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            // Verificar si la celda clickeada es el botón "Modificar"
            else if (e.ColumnIndex == DGVProductos.Columns["editarProducto"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores actuales de la fila seleccionada
                int id = Convert.ToInt32(DGVProductos.Rows[e.RowIndex].Cells[0].Value); // Convertir el valor a int
                string codigo = DGVProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nombre = DGVProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                string stock = DGVProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                string stock_min = DGVProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                string precio_compra = DGVProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                string precio_venta = DGVProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                string descripcion = DGVProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
                string categoria = DGVProductos.Rows[e.RowIndex].Cells[8].Value.ToString();
                System.Drawing.Image imagen = DGVProductos.Rows[e.RowIndex].Cells[9].Value as System.Drawing.Image;


                // Crear y abrir el formulario de edición con los datos
                FormProductosEditar editarForm = new FormProductosEditar(
                    id, codigo, nombre, stock, stock_min, precio_compra, precio_venta, descripcion, categoria, imagen, e.RowIndex, this);

                // Establecer la propiedad Owner (propietario del formulario)
                editarForm.Owner = this; 

                // Mostrar el formulario de edición como un cuadro de diálogo modal
                editarForm.ShowDialog();
            }
        }
        public void ActualizarProducto(int rowIndex, int id, string codigo, string nombre, string stock,
        string stock_min, string precio_compra, string precio_venta, string descripcion, string categoria, System.Drawing.Image imagen)
        {
            DGVProductos.Rows[rowIndex].Cells[0].Value = id;
            DGVProductos.Rows[rowIndex].Cells[1].Value = codigo;
            DGVProductos.Rows[rowIndex].Cells[2].Value = nombre;
            DGVProductos.Rows[rowIndex].Cells[3].Value = stock;
            DGVProductos.Rows[rowIndex].Cells[4].Value = stock_min;
            DGVProductos.Rows[rowIndex].Cells[5].Value = precio_compra;
            DGVProductos.Rows[rowIndex].Cells[6].Value = precio_venta;
            DGVProductos.Rows[rowIndex].Cells[7].Value = descripcion;
            DGVProductos.Rows[rowIndex].Cells[8].Value = categoria;
            DGVProductos.Rows[rowIndex].Cells[9].Value = imagen;

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void TBDescripcionProducto_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras y espacios, al menos 2 caracteres y no más de 30 caracteres
            if (!TBDescripcion.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || TBDescripcion.Text.Length < 2 || TBDescripcion.Text.Length > 500)
            {
                MessageBox.Show("La tela debe contener solo letras y tener entre 2 y 500 caracteres.");
                TBDescripcion.Focus();
            }
        }

        private void BInactivosUsers_Click(object sender, EventArgs e)
        {
            DGVProductos.Rows.Clear();

            DGVProductos.Columns[11].HeaderText = "Dar de Alta";

            List<Producto> listaProductoInactivos = new CN_Producto().Listar().Where(u => u.Baja == true).ToList();

            foreach (Producto item in listaProductoInactivos)
            {
                DGVProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo,
                    item.Nombre,
                    item.Stock,
                    item.Stock_minimo,
                    item.Precio_compra,
                    item.Precio_venta,
                    item.Descripcion,
                    item.oCategoria.Nombre,
                    ConvertirBytesAImagen(item.Imagen),
                });
            }
        }

        private void BActivosUser_Click(object sender, EventArgs e)
        {
            DGVProductos.Rows.Clear();

            DGVProductos.Columns[11].HeaderText = "Dar de Baja";

            List<Producto> listaProductoActivos = new CN_Producto().Listar().Where(u => u.Baja == false).ToList();

            foreach (Producto item in listaProductoActivos)
            {
                DGVProductos.Rows.Add(new object[] {
                    item.Id_producto,
                    item.Codigo,
                    item.Nombre,
                    item.Stock,
                    item.Stock_minimo,
                    item.Precio_compra,
                    item.Precio_venta,
                    item.Descripcion,
                    item.oCategoria.Nombre,
                    ConvertirBytesAImagen(item.Imagen),
                });
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

