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
    public partial class Menu : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        // Form activo que se muestra actualmente en el panel
        private static Form formularioActivo = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.DarkSalmon;
            }
            menu.BackColor = Color.IndianRed;
            menuActivo = menu;

            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Beige;
            PContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new UsuariosForm());
        }

        private void MenuBackup_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormBackUp());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormVentas());
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormClientes());
        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormProductos());
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormReportes());
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    // Clase para el renderizado personalizado de los ítems del menú
    public class CustomRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                // Cambiar el color cuando está seleccionado
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.IndianRed, e.Item.ContentRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Coral, e.Item.ContentRectangle);  // Color original
                }

                // Llamar al método base para renderizar el resto del ítem correctamente
                base.OnRenderMenuItemBackground(e);
            }
        }


    }
