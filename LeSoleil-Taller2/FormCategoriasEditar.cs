using CapaEntidad;
using CapaNegocio;
using LeSoleil_Taller2.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LeSoleil_Taller2
{
    public partial class FormCategoriasEditar : Form
    {
        private int rowIndex;
        private FormCategoria categoriasForm;  // Referencia al formulario principal
        public FormCategoriasEditar(int id, string nombre, string descripcion, int rowIndex, FormCategoria categoriasForm)
        {
            InitializeComponent();
            this.categoriasForm = categoriasForm;
            this.rowIndex = rowIndex;

            // Cargar los valores actuales en los TextBox y demás controles
            LIDCategory.Text = id.ToString();
            TBNombre.Text = nombre;
            TBDescripcion.Text = descripcion;
        }

        private void BEditarGuardar_Click(object sender, EventArgs e)
        {
            FormCategoria categoriasForm = (FormCategoria)this.Owner;

            string Mensaje = string.Empty;
            int IdCategoria = Convert.ToInt32(LIDCategory.Text);

            Categoria objCategoria = new Categoria()
            {
                Id_Categoria = IdCategoria,
                Nombre = TBNombre.Text,
                Descripcion = TBDescripcion.Text
            };

            bool resultado = new CN_Categoria().Editar(objCategoria, out Mensaje);

            if (resultado)
            {
                categoriasForm.ActualizarCategoria(rowIndex, IdCategoria, TBNombre.Text, TBDescripcion.Text);
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

        //Validación del nombre de la categoria
        private void TBNombre_Leave(object sender, EventArgs e)
        {
            // Validación de que solo contenga letras y espacios, al menos 2 caracteres y no más de 50 caracteres
            if (!TBNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || TBNombre.Text.Length < 2 || TBNombre.Text.Length > 50)
            {
                MessageBox.Show("El nombre debe contener solo letras, y tener entre 2 y 50 caracteres.");
                TBNombre.Focus();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(TBNombre.Text))
                {
                    TBNombre.Text = char.ToUpper(TBNombre.Text[0]) + TBNombre.Text.Substring(1).ToLower();
                }
            }
        }

        //Validación de la descripcion de la categoria
        private void TBDescripcion_Validating(object sender, CancelEventArgs e)
        {
            string descripcion = TBDescripcion.Text.Trim();

            if (!string.IsNullOrEmpty(descripcion))
            {
                // Permitir letras, espacios, comas y puntos, y limitar la longitud a 150 caracteres
                if (descripcion.Length > 150 || !descripcion.All(c => char.IsLetter(c) || c == ' ' || c == ',' || c == '.'))
                {
                    MessageBox.Show("La descripción solo puede contener letras, comas, espacios, puntos y hasta 150 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true; // Cancela el evento de salida del control
                }
            }
        }


    }
}
