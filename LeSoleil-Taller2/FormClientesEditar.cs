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
    public partial class FormClientesEditar : Form
    {
            private int rowIndex;
            private FormClientes FormClientes;  // Referencia al formulario principal

            public FormClientesEditar(int id, string dni, string nombre, string apellido, string direccion, string telefono, 
                string email, DateTime fechaNacimiento, int rowIndex, FormClientes FormClientes)
            {
                InitializeComponent();
                this.FormClientes = FormClientes;
                this.rowIndex = rowIndex;

                // Cargar los valores actuales en los TextBox y demás controles
                LIDCliente.Text = id.ToString();
                TBDNICliente.Text = dni;
                TBNombreCliente.Text = nombre;
                TBApellidoCliente.Text = apellido;
                TBDireccionCliente.Text = direccion;
                TBTelefonoCliente.Text = telefono;
                TBEmailCliente.Text = email;
                DTPFechaNacCliente.Value = fechaNacimiento;
            }

            private void BEditarGuardar_Click(object sender, EventArgs e)
            {
                FormClientes FormClientes = (FormClientes)this.Owner;

                string Mensaje = string.Empty;
                int IdCliente = Convert.ToInt32(LIDCliente.Text);

                Cliente objCliente = new Cliente()
                {
                    Id_cliente = IdCliente,
                    Nombre = TBNombreCliente.Text,
                    Apellido = TBApellidoCliente.Text,
                    DNI = TBDNICliente.Text,
                    Direccion = TBDireccionCliente.Text,
                    Telefono = TBTelefonoCliente.Text,
                    Email = TBEmailCliente.Text,
                    //Fecha_nacimiento = DTPFechaNacimiento.Value
                    Fecha_nacimiento = DTPFechaNacCliente.Value.ToString("yyyy-MM-dd"),
                    Baja = false
                };

                bool resultado = new CN_Cliente().Editar(objCliente, out Mensaje);

                if (resultado)
                {
                    FormClientes.ActualizarCliente(rowIndex, IdCliente, TBDNICliente.Text, TBNombreCliente.Text, TBApellidoCliente.Text,
                    TBDireccionCliente.Text, TBTelefonoCliente.Text, TBEmailCliente.Text, DTPFechaNacCliente.Value);
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

        //VALIDACIONES

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

    }
    
}
