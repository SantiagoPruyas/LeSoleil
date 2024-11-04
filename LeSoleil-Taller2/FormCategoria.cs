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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            // Limpiar los TextBox
            TBNombre.Text = "";
            TBDescripcion.Text = "";
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 50 caracteres
            if (!TBNombre.Text.All(char.IsLetter) || TBNombre.Text.Length < 2 || TBNombre.Text.Length > 50)
            {
                MessageBox.Show("El nombre debe contener solo letras, tener entre 2 y 50 caracteres.");
                TBNombre.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBNombre.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBNombre.Text = char.ToUpper(TBNombre.Text[0]) + TBNombre.Text.Substring(1).ToLower();
                }
            }
        }

        private void TBDescripcion_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (TBDescripcion.Text.Length < 2 || TBDescripcion.Text.Length > 100)
            {
                MessageBox.Show("La descripcion debe tener entre 2 y 100 caracteres.");
                TBDescripcion.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBDescripcion.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBDescripcion.Text = char.ToUpper(TBDescripcion.Text[0]) + TBDescripcion.Text.Substring(1).ToLower();
                }
            }
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            // Mostrar todos los usuarios activos en la tabla
            List<Categoria> listaCategoria = new CN_Categoria().Listar().Where(u => u.Estado == true).ToList();

            foreach (Categoria item in listaCategoria)
            {
                DGVCategorias.Rows.Add(new object[] {
                    item.Id_Categoria,
                    item.Nombre,
                    item.Descripcion,
                });
            }

        }

        public void ActualizarCategoria(int rowIndex, int id, string nombre, string descripcion)
        {
            DGVCategorias.Rows[rowIndex].Cells[0].Value = id;
            DGVCategorias.Rows[rowIndex].Cells[1].Value = nombre;
            DGVCategorias.Rows[rowIndex].Cells[2].Value = descripcion;

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void BGuardarCategoria_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                Categoria objCategoria = new Categoria()
                {
                    Nombre = TBNombre.Text,
                    Descripcion = TBDescripcion.Text
                };

                int IdCategoriaGenerado = new CN_Categoria().Registrar(objCategoria, out Mensaje);

                if (IdCategoriaGenerado != 0)
                {
                    if (DGVCategorias.Columns[4].HeaderText == "Dar de Baja")
                    {
                        // Adicionar nuevo renglón en el DataGridView
                        int n = DGVCategorias.Rows.Add();

                        // Colocar la información en las celdas correspondientes
                        DGVCategorias.Rows[n].Cells[0].Value = IdCategoriaGenerado;
                        DGVCategorias.Rows[n].Cells[1].Value = TBNombre.Text;
                        DGVCategorias.Rows[n].Cells[2].Value = TBDescripcion.Text;

                        Limpiar();

                        MessageBox.Show("Categoria guardada exitosamente.");
                    }
                    else
                    {
                        Limpiar();

                        MessageBox.Show("Categoria guardada exitosamente.");
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

        private void BCancelarCategoria_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DGVCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_Categoria = Convert.ToInt32(DGVCategorias.Rows[e.RowIndex].Cells[0].Value);
            string Mensaje = string.Empty;

            // Verificar si la celda clickeada es el botón "bajaCategoria"
            if (e.ColumnIndex == DGVCategorias.Columns["bajaCategoria"].Index && e.RowIndex >= 0)
            {
                if (DGVCategorias.Columns[4].HeaderText == "Dar de Alta")
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVCategorias.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de alta esta Categoria?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el usuario presiona 'Sí', dar de baja el usuario
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Categoria().DarAlta(Id_Categoria, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Categoria dada de alta en el sistema!");
                                DGVCategorias.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta a la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVCategorias.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja esta categoria?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el usuario presiona 'Sí', dar de baja el usuario
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Categoria().DarBaja(Id_Categoria, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Categoria dada de baja del sistema!");
                                DGVCategorias.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja a la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            // Verificar si la celda clickeada es el botón "Modificar"
            else if (e.ColumnIndex == DGVCategorias.Columns["editarCategoria"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores actuales de la fila seleccionada
                int id = Convert.ToInt32(DGVCategorias.Rows[e.RowIndex].Cells[0].Value); // Convertir el valor a int
                string nombre = DGVCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                string descripcion = DGVCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();


                // Crear y abrir el formulario de edición con los datos
                FormCategoriasEditar editarForm = new FormCategoriasEditar(
                    id, nombre, descripcion, e.RowIndex, this
                );

                // Establecer la propiedad Owner (propietario del formulario)
                editarForm.Owner = this; // 'this' es el formulario principal UsuariosForm

                // Mostrar el formulario de edición como un cuadro de diálogo modal
                editarForm.ShowDialog();
            }
        }

        private void DGVCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4)
            {
                // Pintar la celda normal
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Verificar el encabezado de la columna para determinar qué imagen pintar
                if (DGVCategorias.Columns[4].HeaderText == "Dar de Alta")
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

            if (e.ColumnIndex == 3)
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

        private void BActivosCategory_Click(object sender, EventArgs e)
        {
            DGVCategorias.Rows.Clear();

            DGVCategorias.Columns[4].HeaderText = "Dar de Baja";

            List<Categoria> listaCategoriaActivos = new CN_Categoria().Listar().Where(u => u.Estado == true).ToList();

            foreach (Categoria item in listaCategoriaActivos)
            {
                DGVCategorias.Rows.Add(new object[] {
                    item.Id_Categoria,
                    item.Nombre,
                    item.Descripcion,
                });
            }
        }

        private void BInactivosCategory_Click(object sender, EventArgs e)
        {
            DGVCategorias.Rows.Clear();

            DGVCategorias.Columns[4].HeaderText = "Dar de Alta";

            List<Categoria> listaCategoriaInactivos = new CN_Categoria().Listar().Where(u => u.Estado == false).ToList();

            foreach (Categoria item in listaCategoriaInactivos)
            {
                DGVCategorias.Rows.Add(new object[] {
                    item.Id_Categoria,
                    item.Nombre,
                    item.Descripcion,
                });
            }
        }
    }
}
