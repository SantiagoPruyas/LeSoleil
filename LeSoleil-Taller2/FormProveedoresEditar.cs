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
    public partial class FormProveedoresEditar : Form
    {

        private int rowIndex;
        private FormProveedores FormProveedores;  // Referencia al formulario principal

        public FormProveedoresEditar(int id, string CUIT, string nombre, string direccion, string telefono, 
            string email, string razonSocial, string ciudad, string pais, string descripcion, int rowIndex, FormProveedores FormProveedores)
        {
            InitializeComponent();
            this.FormProveedores = FormProveedores;
            this.rowIndex = rowIndex;

            // Cargar los valores actuales en los TextBox y demás controles
            LIDProveedor.Text = id.ToString();
            TBCUITProveedor.Text = CUIT;
            TBNombreProveedor.Text = nombre;
            TBDireccionProveedor.Text = direccion;
            TBTelefonoProveedor.Text = telefono;
            TBEmailProveedor.Text = email;
            TBRazonSocialProveedor.Text = razonSocial;
            TBCiudadProveedor.Text = ciudad;
            TBPaisProveedor.Text = pais;
            TBDescripcionProveedor.Text = descripcion;
        }

        private void BEditarGuardar_Click(object sender, EventArgs e)
        {
            FormProveedores FormProveedores = (FormProveedores)this.Owner;

            string Mensaje = string.Empty;
            int IdProveedor = Convert.ToInt32(LIDProveedor.Text);

            Proveedor objProveedor = new Proveedor()
            {
                Id_Proveedor = IdProveedor,
                Descripcion = TBDescripcionProveedor.Text,
                Nombre = TBNombreProveedor.Text,
                Direccion = TBDireccionProveedor.Text,
                Telefono = TBTelefonoProveedor.Text,
                Email = TBEmailProveedor.Text,
                CUIT = TBCUITProveedor.Text,
                Razon_social = TBRazonSocialProveedor.Text,
                Ciudad = TBCiudadProveedor.Text,
                Pais = TBPaisProveedor.Text,
                Baja = false
            };

            bool resultado = new CN_Proveedor().Editar(objProveedor, out Mensaje);

            if (resultado)
            {
                FormProveedores.ActualizarProveedor(rowIndex, IdProveedor, TBCUITProveedor.Text, TBNombreProveedor.Text,
                TBDireccionProveedor.Text, TBTelefonoProveedor.Text, TBEmailProveedor.Text, TBRazonSocialProveedor.Text,
                TBCiudadProveedor.Text, TBPaisProveedor.Text, TBDescripcionProveedor.Text);
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


    }
}
