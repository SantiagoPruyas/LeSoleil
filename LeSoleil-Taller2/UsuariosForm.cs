﻿using System;
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

        private void BGuardarUser_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos necesarios tienen datos
            if (!string.IsNullOrWhiteSpace(TBNombreUser.Text) &&
                !string.IsNullOrWhiteSpace(TBApellidoUser.Text) &&
                !string.IsNullOrWhiteSpace(TBDniUser.Text) &&
                !string.IsNullOrWhiteSpace(TBUsuarioUser.Text) &&
                !string.IsNullOrWhiteSpace(TBContraseñaUser.Text) &&
                !string.IsNullOrWhiteSpace(TBEmailUser.Text) &&
                !string.IsNullOrWhiteSpace(TBDireccionUser.Text) &&
                !string.IsNullOrWhiteSpace(CBPerfilUser.Text) &&
                !string.IsNullOrWhiteSpace(TBTelefonoUser.Text))
            {
                // Adicionar nuevo renglón en el DataGridView
                int n = DGVUsuarios.Rows.Add();

                // Colocar la información en las celdas correspondientes
                DGVUsuarios.Rows[n].Cells[0].Value = TBNombreUser.Text;
                DGVUsuarios.Rows[n].Cells[1].Value = TBApellidoUser.Text;
                DGVUsuarios.Rows[n].Cells[2].Value = TBDniUser.Text;
                DGVUsuarios.Rows[n].Cells[3].Value = TBUsuarioUser.Text;
                DGVUsuarios.Rows[n].Cells[4].Value = TBContraseñaUser.Text;  // Asegúrate de que la contraseña esté cifrada en un entorno real.
                DGVUsuarios.Rows[n].Cells[5].Value = TBEmailUser.Text;
                DGVUsuarios.Rows[n].Cells[6].Value = TBDireccionUser.Text;
                DGVUsuarios.Rows[n].Cells[7].Value = CBPerfilUser.Text;
                DGVUsuarios.Rows[n].Cells[8].Value = TBTelefonoUser.Text;

                // Limpiar los campos después de agregar la fila
                TBNombreUser.Clear();
                TBApellidoUser.Clear();
                TBDniUser.Clear();
                TBUsuarioUser.Clear();
                TBContraseñaUser.Clear();
                TBEmailUser.Clear();
                TBDireccionUser.Clear();
                CBPerfilUser.SelectedIndex = -1; // Restablece el valor seleccionado
                TBTelefonoUser.Clear();

                MessageBox.Show("Usuario guardado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }
        
    }
}
