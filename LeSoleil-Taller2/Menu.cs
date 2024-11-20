using CapaEntidad;
using CapaNegocio;
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

        private static Usuario usuarioActual;
        public Menu(Usuario objusuario)
        {
            usuarioActual = objusuario;
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
            abrirFormulario((ToolStripMenuItem)sender, new FormBackUp(usuarioActual));
        }

        /*private void MenuVentas_Click(object sender, EventArgs e)
        /{
            abrirFormulario((ToolStripMenuItem)sender, new FormVentas());
        }*/

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormClientes(usuarioActual));
        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormProductos());
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.Id_usuario);

            foreach (ToolStripMenuItem iconmenu in MSMenu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.Nombre == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            MN_nombreUsuario.Text = usuarioActual.User;
        }

        private void MenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormVentas(usuarioActual));
        }

        private void MenuDetalleVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormVentasDetalle());
        }

        private void MenuCategorias_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormCategoria());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormProveedores());
        }

        private void MenuReportesVendedor_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormReporteVendedor(usuarioActual));
        }

        private void productosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormReporteGerente2());
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario((ToolStripMenuItem)sender, new FormReporteGerente());
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
