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
    public partial class FormClientes : Form
    {
        private static Usuario usuarioActual;
        public FormClientes(Usuario objusuario)
        {
            InitializeComponent();
            usuarioActual = objusuario;
        }
        private void Limpiar()
        {
            // Limpiar los TextBox
            TBDNICliente.Text = "";
            TBNombreCliente.Text = "";
            TBApellidoCliente.Text = "";
            TBDireccionCliente.Text = "";
            TBTelefonoCliente.Text = "";
            TBEmailCliente.Text = "";
        }

        // Validación del DNI (sólo números y entre 7 y 8 dígitos)
        private void TBDNICliente_Leave(object sender, EventArgs e)
        {
            if (!TBDNICliente.Text.All(char.IsDigit) || TBDNICliente.Text.Length < 7 || TBDNICliente.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe ser un número entre 7 y 8 dígitos.");
                TBDNICliente.Focus();
            }
        }

        // Validación del Nombre del Cliente
        private void TBNombreCliente_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (!TBNombreCliente.Text.All(char.IsLetter) || TBNombreCliente.Text.Length < 2 || TBNombreCliente.Text.Length > 20)
            {
                MessageBox.Show("El nombre debe contener solo letras, tener entre 2 y 20 caracteres.");
                TBNombreCliente.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBNombreCliente.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBNombreCliente.Text = char.ToUpper(TBNombreCliente.Text[0]) + TBNombreCliente.Text.Substring(1).ToLower();
                }
            }
        }

        // Validación del Apellido del Cliente
        private void TBApellidoCliente_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (!TBApellidoCliente.Text.All(char.IsLetter) || TBApellidoCliente.Text.Length < 2 || TBApellidoCliente.Text.Length > 20)
            {
                MessageBox.Show("El apellido debe contener solo letras, tener entre 2 y 20 caracteres.");
                TBApellidoCliente.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBApellidoCliente.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBApellidoCliente.Text = char.ToUpper(TBApellidoCliente.Text[0]) + TBApellidoCliente.Text.Substring(1).ToLower();
                }
            }
        }

        // Validación de la Dirección del Cliente
        private void TBDireccionCliente_Leave(object sender, EventArgs e)
        {
            // Validación de que la dirección no esté vacía y tenga al menos 5 caracteres
            if (string.IsNullOrWhiteSpace(TBDireccionCliente.Text) || TBDireccionCliente.Text.Length < 5)
            {
                MessageBox.Show("La dirección debe contener al menos 5 caracteres.");
                TBDireccionCliente.Focus();
            }

        }

        // Validación del Telefono del Cliente
        private void TBTelefonoCliente_Leave(object sender, EventArgs e)
        {
            if (!TBTelefonoCliente.Text.All(char.IsDigit) || TBTelefonoCliente.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos y solo contener números.");
                TBTelefonoCliente.Focus();
            }
        }

        // Validación del Email del Cliente
        private void TBEmailCliente_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TBEmailCliente.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del email no es válido.");
                TBEmailCliente.Focus();
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            //List<Perfil> listaPerfil = new CN_Perfil().Listar();

            // Mostrar todos los Clientes activos en la tabla
            List<Cliente> listaCliente = new CN_Cliente().Listar().Where(u => u.Baja == false).ToList();

            foreach (Cliente item in listaCliente)
            {
                DGVClientes.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre,
                    item.Apellido,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Fecha_nacimiento,
                });
            }
        }

        private void BGuardarCliente_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;

            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBDNICliente.Text) &&
                !string.IsNullOrWhiteSpace(TBNombreCliente.Text) &&
                !string.IsNullOrWhiteSpace(TBApellidoCliente.Text) &&
                !string.IsNullOrWhiteSpace(TBDireccionCliente.Text) &&
                !string.IsNullOrWhiteSpace(TBTelefonoCliente.Text) &&
                !string.IsNullOrWhiteSpace(TBEmailCliente.Text) &&
                DTPFechaNacCliente.Value != null)
            {
                Cliente objCliente = new Cliente()
                {
                    DNI = TBDNICliente.Text,
                    Nombre = TBNombreCliente.Text,
                    Apellido = TBApellidoCliente.Text,
                    Direccion = TBDireccionCliente.Text,
                    Telefono = TBTelefonoCliente.Text,
                    Email = TBEmailCliente.Text,
                    Fecha_nacimiento = DTPFechaNacCliente.Value.ToString("yyyy-MM-dd"),
                    Usuario_creacion = usuarioActual.Id_usuario,
                    Baja = false,
                };

                int IdClienteGenerado = new CN_Cliente().Registrar(objCliente, out Mensaje);

                if (IdClienteGenerado != 0)
                {
                    if (DGVClientes.Columns[9].HeaderText == "Dar de Baja")
                    {
                        // Adicionar nuevo renglón en el DataGridView
                        int n = DGVClientes.Rows.Add();

                        // Colocar la información en las celdas correspondientes
                        DGVClientes.Rows[n].Cells[0].Value = IdClienteGenerado;
                        DGVClientes.Rows[n].Cells[1].Value = TBDNICliente.Text;
                        DGVClientes.Rows[n].Cells[2].Value = TBNombreCliente.Text;
                        DGVClientes.Rows[n].Cells[3].Value = TBApellidoCliente.Text;
                        DGVClientes.Rows[n].Cells[4].Value = TBDireccionCliente.Text;
                        DGVClientes.Rows[n].Cells[5].Value = TBTelefonoCliente.Text;
                        DGVClientes.Rows[n].Cells[6].Value = TBEmailCliente.Text;
                        DGVClientes.Rows[n].Cells[7].Value = DTPFechaNacCliente.Value.ToString("yyyy-MM-dd");

                        Limpiar();

                        MessageBox.Show("Cliente guardado exitosamente.");
                    }
                    else
                    {
                        Limpiar();

                        MessageBox.Show("Cliente guardado exitosamente.");
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

        private void BCancelarCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DGVClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9)
            {
                // Pintar la celda normal
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Verificar el encabezado de la columna para determinar qué imagen pintar
                if (DGVClientes.Columns[9].HeaderText == "Dar de Alta")
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

            if (e.ColumnIndex == 8)
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
        private void BActivosCliente_Click(object sender, EventArgs e)
        {
            DGVClientes.Rows.Clear();

            DGVClientes.Columns[9].HeaderText = "Dar de Baja";

            List<Cliente> listaClienteActivos = new CN_Cliente().Listar().Where(u => u.Baja == false).ToList();

            foreach (Cliente item in listaClienteActivos)
            {
                DGVClientes.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre,
                    item.Apellido,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Fecha_nacimiento,
                });
            }
        }

        private void BInactivosClientes_Click(object sender, EventArgs e)
        {
            DGVClientes.Rows.Clear();

            DGVClientes.Columns[9].HeaderText = "Dar de Alta";

            List<Cliente> listaClienteInactivos = new CN_Cliente().Listar().Where(u => u.Baja == true).ToList();

            foreach (Cliente item in listaClienteInactivos)
            {
                DGVClientes.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre,
                    item.Apellido,
                    item.Direccion,
                    item.Telefono,
                    item.Email,
                    item.Fecha_nacimiento,
                });
            }
        }
        public void ActualizarCliente(int rowIndex, int id, string dni, string nombre, string apellido,
        string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            DGVClientes.Rows[rowIndex].Cells[0].Value = id;
            DGVClientes.Rows[rowIndex].Cells[1].Value = dni;
            DGVClientes.Rows[rowIndex].Cells[2].Value = nombre;
            DGVClientes.Rows[rowIndex].Cells[3].Value = apellido;
            DGVClientes.Rows[rowIndex].Cells[4].Value = direccion;
            DGVClientes.Rows[rowIndex].Cells[5].Value = telefono;
            DGVClientes.Rows[rowIndex].Cells[6].Value = email;
            DGVClientes.Rows[rowIndex].Cells[7].Value = fechaNacimiento.ToShortDateString();

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void DGVClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_cliente = Convert.ToInt32(DGVClientes.Rows[e.RowIndex].Cells[0].Value);
            string Mensaje = string.Empty;

            // Verificar si la celda clickeada es el botón "bajaCliente"
            if (e.ColumnIndex == DGVClientes.Columns["bajaCliente"].Index && e.RowIndex >= 0)
            {
                if (DGVClientes.Columns[9].HeaderText == "Dar de Alta")
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVClientes.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de alta este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el Cliente presiona 'Sí', dar de baja el Cliente
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Cliente().DarAlta(Id_cliente, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Cliente dado de alta del sistema!");
                                DGVClientes.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de alta al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Verificar que la fila no sea la nueva fila sin confirmar
                    if (!DGVClientes.Rows[e.RowIndex].IsNewRow)
                    {
                        // Mostrar mensaje de confirmación
                        DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Si el Cliente presiona 'Sí', dar de baja el Cliente
                        if (result == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Cliente().DarBaja(Id_cliente, out Mensaje);
                            if (respuesta)
                            {
                                MessageBox.Show("Cliente dado de baja del sistema!");
                                DGVClientes.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show(Mensaje);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            // Verificar si la celda clickeada es el botón "Modificar"
            else if (e.ColumnIndex == DGVClientes.Columns["editarCliente"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores actuales de la fila seleccionada
                int id = Convert.ToInt32(DGVClientes.Rows[e.RowIndex].Cells[0].Value); // Convertir el valor a int
                string dni = DGVClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                string nombre = DGVClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                string apellido = DGVClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                string direccion = DGVClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                string telefono = DGVClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                string email = DGVClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(DGVClientes.Rows[e.RowIndex].Cells[7].Value);


                // Crear y abrir el formulario de edición con los datos
                FormClientesEditar editarForm = new FormClientesEditar(
                    id, dni, nombre, apellido, direccion, telefono, email, fechaNacimiento, e.RowIndex, this
                );

                // Establecer la propiedad Owner (propietario del formulario)
                editarForm.Owner = this; // 'this' es el formulario principal ClientesForm

                // Mostrar el formulario de edición como un cuadro de diálogo modal
                editarForm.ShowDialog();
            }
        }
    }
}
