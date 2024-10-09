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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            // Limpiar los TextBox
            TBNombreUser.Text = "";
            TBApellidoUser.Text = "";
            TBDniUser.Text = "";
            TBUsuarioUser.Text = "";
            TBContraseñaUser.Text = "";
            TBEmailUser.Text = "";
            TBDireccionUser.Text = "";
            TBTelefonoUser.Text = "";

            // Limpiar el ComboBox
            CBPerfilUser.SelectedIndex = -1;
        }
        private void TBNombreUser_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (!TBNombreUser.Text.All(char.IsLetter) || TBNombreUser.Text.Length < 2 || TBNombreUser.Text.Length > 20)
            {
                MessageBox.Show("El nombre debe contener solo letras, tener entre 2 y 20 caracteres.");
                TBNombreUser.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBNombreUser.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBNombreUser.Text = char.ToUpper(TBNombreUser.Text[0]) + TBNombreUser.Text.Substring(1).ToLower();
                }
            }
        }
        private void TBApellidoUser_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras, al menos 2 caracteres y no más de 20 caracteres
            if (!TBApellidoUser.Text.All(char.IsLetter) || TBApellidoUser.Text.Length < 2 || TBApellidoUser.Text.Length > 20)
            {
                MessageBox.Show("El apellido debe contener solo letras, tener entre 2 y 20 caracteres.");
                TBApellidoUser.Focus();  // Enfoca el campo para corrección
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBApellidoUser.Text))
                {
                    // Convertir el texto a formato Título (Primera letra mayúscula y resto minúscula)
                    TBApellidoUser.Text = char.ToUpper(TBApellidoUser.Text[0]) + TBApellidoUser.Text.Substring(1).ToLower();
                }
            }
        }

        // Validación del DNI (sólo números y entre 7 y 8 dígitos)
        private void TBDniUser_Leave(object sender, EventArgs e)
        {
            if (!TBDniUser.Text.All(char.IsDigit) || TBDniUser.Text.Length < 7 || TBDniUser.Text.Length > 8)
            {
                MessageBox.Show("El DNI debe ser un número entre 7 y 8 dígitos.");
                TBDniUser.Focus();
            }
        }

        private void TBUsuarioUser_Leave(object sender, EventArgs e)
        {
            // Validación de que el usuario tenga entre 4 y 30 caracteres
            if (TBUsuarioUser.Text.Length < 4 || TBUsuarioUser.Text.Length > 30)
            {
                MessageBox.Show("El nombre de usuario debe tener entre 4 y 30 caracteres.");
                TBUsuarioUser.Focus();
            }

            // Validación para que no contenga espacios en blanco
            if (TBUsuarioUser.Text.Contains(" "))
            {
                MessageBox.Show("El nombre de usuario no debe contener espacios en blanco.");
                TBUsuarioUser.Focus();
            }
            else
            {
                // Asegura que el texto no esté vacío antes de aplicar los cambios
                if (!string.IsNullOrWhiteSpace(TBUsuarioUser.Text))
                {
                    TBUsuarioUser.Text = TBUsuarioUser.Text.ToLower();
                }
            }
        }
        private void TBContraseñaUser_Leave(object sender, EventArgs e)
        {
            // Validación de que la contraseña tenga entre 4 y 40 caracteres
            if (TBContraseñaUser.Text.Length < 4 || TBContraseñaUser.Text.Length > 40)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 40 caracteres.");
                TBContraseñaUser.Focus();  
            }
        }

        private void TBEmailUser_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TBEmailUser.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del email no es válido.");
                TBEmailUser.Focus();
            }
        }
        private void TBDireccionUser_Leave(object sender, EventArgs e)
        {
            // Validación de que la dirección no esté vacía y tenga al menos 5 caracteres
            if (string.IsNullOrWhiteSpace(TBDireccionUser.Text) || TBDireccionUser.Text.Length < 5)
            {
                MessageBox.Show("La dirección debe contener al menos 5 caracteres.");
                TBDireccionUser.Focus();
            }

        }
        private void CBPerfilUser_Leave(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una opción en el ComboBox (Admin / Vendedor / Repositor)
            if (CBPerfilUser.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un perfil de usuario.");
                CBPerfilUser.Focus(); 
            }
        }

        private void TBTelefonoUser_Leave(object sender, EventArgs e)
        {
            if (!TBTelefonoUser.Text.All(char.IsDigit) || TBTelefonoUser.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos y solo contener números.");
                TBTelefonoUser.Focus();
            }
        }
        private void BGuardarUsuario_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            
            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBNombreUser.Text) &&
                !string.IsNullOrWhiteSpace(TBApellidoUser.Text) &&
                !string.IsNullOrWhiteSpace(TBDniUser.Text) &&
                !string.IsNullOrWhiteSpace(TBUsuarioUser.Text) &&
                !string.IsNullOrWhiteSpace(TBContraseñaUser.Text) &&
                !string.IsNullOrWhiteSpace(TBEmailUser.Text) &&
                !string.IsNullOrWhiteSpace(TBDireccionUser.Text) &&
                !string.IsNullOrWhiteSpace(CBPerfilUser.Text) &&
                !string.IsNullOrWhiteSpace(TBTelefonoUser.Text) &&
                DTPFechaNacimiento.Value != null)
            {
                Usuario objUsuario = new Usuario()
                {
                    Nombre = TBNombreUser.Text,
                    Apellido = TBApellidoUser.Text,
                    DNI = TBDniUser.Text,
                    User = TBUsuarioUser.Text,
                    Contraseña = TBContraseñaUser.Text,
                    Correo = TBEmailUser.Text,
                    Direccion = TBDireccionUser.Text,
                    Telefono = TBTelefonoUser.Text,
                    oPerfil = new Perfil() { Perfil_id = Convert.ToInt32(((OpcionCombo)CBPerfilUser.SelectedItem).Valor) },
                    Baja = false,
                    //Fecha_nacimiento = "2000-04-02"
                    Fecha_nacimiento = DTPFechaNacimiento.Value.ToString("yyyy-MM-dd")
                };

                int IdUsuarioGenerado = new CN_Usuario().Registrar(objUsuario, out Mensaje);

                if(IdUsuarioGenerado != 0)
                {
                    // Adicionar nuevo renglón en el DataGridView
                    int n = DGVUsuarios.Rows.Add();

                    // Colocar la información en las celdas correspondientes
                    DGVUsuarios.Rows[n].Cells[0].Value = IdUsuarioGenerado;
                    DGVUsuarios.Rows[n].Cells[1].Value = TBNombreUser.Text;
                    DGVUsuarios.Rows[n].Cells[2].Value = TBApellidoUser.Text;
                    DGVUsuarios.Rows[n].Cells[3].Value = TBDniUser.Text;
                    DGVUsuarios.Rows[n].Cells[4].Value = TBUsuarioUser.Text;
                    DGVUsuarios.Rows[n].Cells[5].Value = TBContraseñaUser.Text;  
                    DGVUsuarios.Rows[n].Cells[6].Value = TBEmailUser.Text;
                    DGVUsuarios.Rows[n].Cells[7].Value = TBDireccionUser.Text;
                    DGVUsuarios.Rows[n].Cells[8].Value = CBPerfilUser.Text;
                    DGVUsuarios.Rows[n].Cells[9].Value = TBTelefonoUser.Text;
                    DGVUsuarios.Rows[n].Cells[10].Value = DTPFechaNacimiento.Value.ToString("yyyy-MM-dd"); 

                    Limpiar();

                    MessageBox.Show("Usuario guardado exitosamente.");
                } else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void BCancelarUsuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_usuario = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells[0].Value);
            string Mensaje = string.Empty;

            // Verificar si la celda clickeada es el botón "bajaUsuario"
            if (e.ColumnIndex == DGVUsuarios.Columns["bajaUsuario"].Index && e.RowIndex >= 0)
            {
                // Verificar que la fila no sea la nueva fila sin confirmar
                if (!DGVUsuarios.Rows[e.RowIndex].IsNewRow)
                {
                    // Mostrar mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario presiona 'Sí', dar de baja el usuario
                    if (result == DialogResult.Yes)
                    {
                        bool respuesta = new CN_Usuario().DarBaja(Id_usuario, out Mensaje);
                        if (respuesta)
                        {
                            MessageBox.Show("Usuario dado de baja del sistema!");
                            // Faltaria cambiar el valor del estado dentro de la tabla
                        } else
                        {
                            MessageBox.Show(Mensaje);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede dar de baja al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // Verificar si la celda clickeada es el botón "Modificar"
            else if (e.ColumnIndex == DGVUsuarios.Columns["editarUsuario"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores actuales de la fila seleccionada
                string id = DGVUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nombre = DGVUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                string apellido = DGVUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                string dni = DGVUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                string usuario = DGVUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                string contraseña = DGVUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                string email = DGVUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                string direccion = DGVUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                string perfil = DGVUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                string telefono = DGVUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(DGVUsuarios.Rows[e.RowIndex].Cells[10].Value); 


                // Crear y abrir el formulario de edición con los datos
                UsuariosFormEditar editarForm = new UsuariosFormEditar(
                    nombre, apellido, dni, usuario, contraseña, email, direccion, perfil, telefono, e.RowIndex, this
                );

                // Establecer la propiedad Owner (propietario del formulario)
                editarForm.Owner = this; // 'this' es el formulario principal UsuariosForm

                // Mostrar el formulario de edición como un cuadro de diálogo modal
                editarForm.ShowDialog();
            }
        }

        public void ActualizarUsuario(int rowIndex, string nombre, string apellido, string dni,
        string usuario, string contraseña, string email, string direccion, string perfil, string telefono)
        {
            DGVUsuarios.Rows[rowIndex].Cells[0].Value = id;
            DGVUsuarios.Rows[rowIndex].Cells[1].Value = nombre;
            DGVUsuarios.Rows[rowIndex].Cells[2].Value = apellido;
            DGVUsuarios.Rows[rowIndex].Cells[3].Value = dni;
            DGVUsuarios.Rows[rowIndex].Cells[4].Value = usuario;
            DGVUsuarios.Rows[rowIndex].Cells[5].Value = contraseña;
            DGVUsuarios.Rows[rowIndex].Cells[6].Value = email;
            DGVUsuarios.Rows[rowIndex].Cells[7].Value = direccion;
            DGVUsuarios.Rows[rowIndex].Cells[8].Value = perfil;
            DGVUsuarios.Rows[rowIndex].Cells[9].Value = telefono;
            DGVUsuarios.Rows[rowIndex].Cells[10].Value = fechaNacimiento.ToShortDateString(); 

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            List<Perfil> listaPerfil = new CN_Perfil().Listar();

            foreach (Perfil item in listaPerfil)
            {
                CBPerfilUser.Items.Add(new OpcionCombo() { Valor = item.Perfil_id, Texto = item.NombreRol });
                CBPerfilUser.DisplayMember = "Texto";
                CBPerfilUser.ValueMember = "Valor";
                CBPerfilUser.SelectedIndex = 0;
            }

            // Mostrar todos los usuarios en la tabla
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                DGVUsuarios.Rows.Add(new object[] {
                    item.Id_usuario,
                    item.Nombre,
                    item.Apellido,
                    item.DNI,
                    item.User,
                    item.Contraseña,
                    item.Correo,
                    item.Direccion,
                    item.oPerfil.NombreRol,
                    item.Telefono,
                    item.Fecha_nacimiento,
                });
            }
        }

        //private void BGuardarUser_Click(object sender, EventArgs e)
        //{
        //    DGVUsuarios.Rows.Add(new object[] {
        //        TBNombreUser.Text,
        //        TBApellidoUser.Text,
        //        TBDniUser.Text,
        //        TBDniUser,
        //        TBContraseñaUser,
        //        TBEmailUser,
        //        TBDireccionUser.Text,
        //        ((OpcionCombo)CBPerfilUser.SelectedItem).Valor.ToString(),
        //        ((OpcionCombo)CBPerfilUser.SelectedItem).Texto.ToString(),
        //        TBTelefonoUser.Text
        //    });
        //}

        private void DGVUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 12)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.deletepng.Width;
                var h = Properties.Resources.deletepng.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.deletepng, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 11)
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


    }
}
