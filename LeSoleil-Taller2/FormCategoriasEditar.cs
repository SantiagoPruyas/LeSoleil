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
    }
}
