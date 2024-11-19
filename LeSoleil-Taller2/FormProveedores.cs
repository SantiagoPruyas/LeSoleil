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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            // Limpiar los TextBox
            TBDescripcionProveedor.Text = "";
            TBNombreProveedor.Text = "";
            TBDireccionProveedor.Text = "";
            TBTelefonoProveedor.Text = "";
            TBEmailProveedor.Text = "";
            TBCUITProveedor.Text = "";
            TBRazonSocialProveedor.Text = "";
            TBCiudadProveedor.Text = "";
            TBPaisProveedor.Text = "";
        }

        // Validación del CUIT del Proveedor
        private void TBCUITProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga números y tenga hasta 11 dígitos
            if (!TBCUITProveedor.Text.All(char.IsDigit) || TBCUITProveedor.Text.Length > 11)
            {
                MessageBox.Show("El CUIT debe contener solo números y tener hasta 11 dígitos.");
                TBCUITProveedor.Focus();
            }
        }

        // Validación del Nombre del Proveedor
        private void TBNombreProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (!TBNombreProveedor.Text.All(char.IsLetter) || TBNombreProveedor.Text.Length < 2 || TBNombreProveedor.Text.Length > 20)
            {
                MessageBox.Show("El nombre debe contener solo letras, tener entre 2 y 20 caracteres.");
                TBNombreProveedor.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBNombreProveedor.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBNombreProveedor.Text = char.ToUpper(TBNombreProveedor.Text[0]) + TBNombreProveedor.Text.Substring(1).ToLower();
                }
            }
        }

        // Validación de la Dirección del Proveedor
        private void TBDireccionProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que la dirección no esté vacía y tenga al menos 5 caracteres
            if (string.IsNullOrWhiteSpace(TBDireccionProveedor.Text) || TBDireccionProveedor.Text.Length < 5)
            {
                MessageBox.Show("La dirección debe contener al menos 5 caracteres.");
                TBDireccionProveedor.Focus();
            }

        }

        // Validación del Telefono del Proveedor
        private void TBTelefonoProveedor_Leave(object sender, EventArgs e)
        {
            if (!TBTelefonoProveedor.Text.All(char.IsDigit) || TBTelefonoProveedor.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos y solo contener números.");
                TBTelefonoProveedor.Focus();
            }
        }

        // Validación del Email del Proveedor
        private void TBEmailProveedor_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TBEmailProveedor.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del email no es válido.");
                TBEmailProveedor.Focus();
            }
        }

        // Validación de la Razon Social del Proveedor
        private void TBRazonSocialProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que no esté vacío y tenga entre 2 y 50 caracteres
            if (string.IsNullOrWhiteSpace(TBRazonSocialProveedor.Text) || TBRazonSocialProveedor.Text.Length < 2 || TBRazonSocialProveedor.Text.Length > 50)
            {
                MessageBox.Show("La Razón Social debe tener entre 2 y 50 caracteres.");
                TBRazonSocialProveedor.Focus();
            }
            else
            {
                // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                TBRazonSocialProveedor.Text = char.ToUpper(TBRazonSocialProveedor.Text[0]) + TBRazonSocialProveedor.Text.Substring(1).ToLower();
            }
        }

        // Validación de la Ciudad del Proveedor
        private void TBCiudadProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que no esté vacío y tenga entre 2 y 50 caracteres
            if (string.IsNullOrWhiteSpace(TBCiudadProveedor.Text) || TBCiudadProveedor.Text.Length < 2 || TBCiudadProveedor.Text.Length > 50)
            {
                MessageBox.Show("La Ciudad debe tener entre 2 y 50 caracteres.");
                TBCiudadProveedor.Focus();
            }
            else
            {
                TBCiudadProveedor.Text = char.ToUpper(TBCiudadProveedor.Text[0]) + TBCiudadProveedor.Text.Substring(1).ToLower();
            }
        }

        // Validación del Pais del Proveedor
        private void TBPaisProveedor_Leave(object sender, EventArgs e)
        {
            // Validación de que no esté vacío y tenga entre 2 y 50 caracteres
            if (string.IsNullOrWhiteSpace(TBPaisProveedor.Text) || TBPaisProveedor.Text.Length < 2 || TBPaisProveedor.Text.Length > 50)
            {
                MessageBox.Show("El País debe tener entre 2 y 50 caracteres.");
                TBPaisProveedor.Focus();
            }
            else
            {
                TBPaisProveedor.Text = char.ToUpper(TBPaisProveedor.Text[0]) + TBPaisProveedor.Text.Substring(1).ToLower();
            }
        }

        // Validación de la Descripción del Proveedor
        private void TBDescripcionProveedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string descripcion = TBDescripcionProveedor.Text.Trim();

            if (!string.IsNullOrEmpty(descripcion))
            {
                if (descripcion.Length > 150 || !descripcion.All(char.IsLetter))
                {
                    MessageBox.Show("La descripción solo puede contener hasta 150 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; // Cancela el evento de salida del control
                }
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            // Mostrar todos los Proveedores activos en la tabla
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar().Where(u => u.Baja == false).ToList();

            foreach (Proveedor item in listaProveedor)
            {
                DGVProveedores.Rows.Add(new object[] {
                    item.Id_Proveedor,
                    item.CUIT,
                    item.Nombre,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Razon_social,
                    item.Ciudad,
                    item.Pais,
                    item.Descripcion,
                });
            }
        }

        // Guardar Proveedor
        private void BGuardarProveedor_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBDescripcionProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBNombreProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBDireccionProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBTelefonoProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBEmailProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBCUITProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBRazonSocialProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBCiudadProveedor.Text) &&
                !string.IsNullOrWhiteSpace(TBPaisProveedor.Text) )
            {
                Proveedor objProveedor = new Proveedor()
                {
                    Descripcion = TBDescripcionProveedor.Text,
                    Nombre = TBNombreProveedor.Text,
                    Direccion = TBDireccionProveedor.Text,
                    Telefono = TBTelefonoProveedor.Text,
                    Email = TBEmailProveedor.Text,
                    CUIT = TBCUITProveedor.Text,
                    Razon_social = TBRazonSocialProveedor.Text,
                    Ciudad = TBCiudadProveedor.Text,
                    Pais = TBPaisProveedor.Text,
                    Baja = false,
                };

                int IdProveedorGenerado = new CN_Proveedor().Registrar(objProveedor, out Mensaje);

                if (IdProveedorGenerado != 0)
                {
                    if (DGVProveedores.Columns[11].HeaderText == "Dar de Baja")
                    {
                        // Adicionar nuevo renglón en el DataGridView
                        int n = DGVProveedores.Rows.Add();

                        // Colocar la información en las celdas correspondientes
                        DGVProveedores.Rows[n].Cells[0].Value = IdProveedorGenerado;
                        DGVProveedores.Rows[n].Cells[1].Value = TBCUITProveedor.Text;
                        DGVProveedores.Rows[n].Cells[2].Value = TBNombreProveedor.Text;
                        DGVProveedores.Rows[n].Cells[3].Value = TBDireccionProveedor.Text;
                        DGVProveedores.Rows[n].Cells[4].Value = TBTelefonoProveedor.Text;
                        DGVProveedores.Rows[n].Cells[5].Value = TBEmailProveedor.Text;
                        DGVProveedores.Rows[n].Cells[6].Value = TBRazonSocialProveedor.Text;
                        DGVProveedores.Rows[n].Cells[7].Value = TBCiudadProveedor.Text;
                        DGVProveedores.Rows[n].Cells[8].Value = TBPaisProveedor.Text;
                        DGVProveedores.Rows[n].Cells[9].Value = TBDescripcionProveedor.Text;

                        Limpiar();

                        MessageBox.Show("Proveedor guardado exitosamente.");
                    }
                    else
                    {
                        Limpiar();

                        MessageBox.Show("Proveedor guardado exitosamente.");
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

        private void BCancelarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DGVProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 11)
            {
                // Pintar la celda normal
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Verificar el encabezado de la columna para determinar qué imagen pintar
                if (DGVProveedores.Columns[11].HeaderText == "Dar de Alta")
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

        private void DGVProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_Proveedor = Convert.ToInt32(DGVProveedores.Rows[e.RowIndex].Cells[0].Value);
            string Mensaje = string.Empty;

            // Verificar si la celda clickeada es el botón "bajaProveedor"
            if (e.ColumnIndex == DGVProveedores.Columns["bajaProveedor"].Index && e.RowIndex >= 0)
            {
                if (DGVProveedores.Columns[11].HeaderText == "Dar de Alta")
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVProveedores.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de alta este Proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el Proveedor presiona 'Sí', dar de baja el Proveedor
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Proveedor().DarAlta(Id_Proveedor, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Proveedor dado de alta del sistema!");
                                DGVProveedores.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta al Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVProveedores.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja este Proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el Proveedor presiona 'Sí', dar de baja el Proveedor
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Proveedor().DarBaja(Id_Proveedor, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Proveedor dado de baja del sistema!");
                                DGVProveedores.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja al Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            // Verificar si la celda clickeada es el botón "Modificar"
            else if (e.ColumnIndex == DGVProveedores.Columns["editarProveedor"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores actuales de la fila seleccionada
                int id = Convert.ToInt32(DGVProveedores.Rows[e.RowIndex].Cells[0].Value); // Convertir el valor a int
                string CUIT = DGVProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nombre = DGVProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
                string direccion = DGVProveedores.Rows[e.RowIndex].Cells[3].Value.ToString();
                string telefono = DGVProveedores.Rows[e.RowIndex].Cells[4].Value.ToString();
                string email = DGVProveedores.Rows[e.RowIndex].Cells[5].Value.ToString();
                string razonSocial = DGVProveedores.Rows[e.RowIndex].Cells[6].Value.ToString();
                string ciudad = DGVProveedores.Rows[e.RowIndex].Cells[7].Value.ToString();
                string pais = DGVProveedores.Rows[e.RowIndex].Cells[8].Value.ToString();
                string descripcion = DGVProveedores.Rows[e.RowIndex].Cells[9].Value.ToString();

                // Crear y abrir el formulario de edición con los datos
                FormProveedoresEditar editarForm = new FormProveedoresEditar(
                    id, CUIT, nombre, direccion, telefono, email, razonSocial, ciudad, pais, descripcion, e.RowIndex, this
                );

                // Establecer la propiedad Owner (propietario del formulario)
                editarForm.Owner = this; // 'this' es el formulario principal ProveedorForm

                // Mostrar el formulario de edición como un cuadro de diálogo modal
                editarForm.ShowDialog();
            }
        }

        private void BActivosProveedor_Click(object sender, EventArgs e)
        {
            DGVProveedores.Rows.Clear();

            DGVProveedores.Columns[11].HeaderText = "Dar de Baja";

            List<Proveedor> listaProveedorActivos = new CN_Proveedor().Listar().Where(u => u.Baja == false).ToList();

            foreach (Proveedor item in listaProveedorActivos)
            {
                DGVProveedores.Rows.Add(new object[] {
                    item.Id_Proveedor,
                    item.CUIT,
                    item.Nombre,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Razon_social,
                    item.Ciudad,
                    item.Pais,
                    item.Descripcion,
                });
            }
        }
        private void BInactivosProveedores_Click(object sender, EventArgs e)
        {
            DGVProveedores.Rows.Clear();

            DGVProveedores.Columns[11].HeaderText = "Dar de Alta";

            List<Proveedor> listaProveedorInactivos = new CN_Proveedor().Listar().Where(u => u.Baja == true).ToList();

            foreach (Proveedor item in listaProveedorInactivos)
            {
                DGVProveedores.Rows.Add(new object[] {
                    item.Id_Proveedor,
                    item.CUIT,
                    item.Nombre,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Razon_social,
                    item.Ciudad,
                    item.Pais,
                    item.Descripcion,
                });
            }
        }
        public void ActualizarProveedor(int rowIndex, int id, string CUIT, string nombre,
        string direccion, string telefono, string email, string razonSocial, string ciudad, string pais, string descripcion)
        {
            DGVProveedores.Rows[rowIndex].Cells[0].Value = id;
            DGVProveedores.Rows[rowIndex].Cells[1].Value = CUIT;
            DGVProveedores.Rows[rowIndex].Cells[2].Value = nombre;
            DGVProveedores.Rows[rowIndex].Cells[3].Value = direccion;
            DGVProveedores.Rows[rowIndex].Cells[4].Value = telefono;
            DGVProveedores.Rows[rowIndex].Cells[5].Value = email;
            DGVProveedores.Rows[rowIndex].Cells[6].Value = razonSocial;
            DGVProveedores.Rows[rowIndex].Cells[7].Value = ciudad;
            DGVProveedores.Rows[rowIndex].Cells[8].Value = pais;
            DGVProveedores.Rows[rowIndex].Cells[9].Value = descripcion;


            MessageBox.Show("Datos actualizados correctamente.");
        }
    }
}
