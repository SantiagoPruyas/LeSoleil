using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using CapaNegocio;
//using CapaEntidad;

namespace LeSoleil_Taller2
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BIngresar_Click(object sender, EventArgs e)
        {

            // List<Usuario> TEST = new CN_Usuario().Listar();

            // Usuario oUsuario = new CN_Usuario().Listar().Where(u => u.User == TBUsuario.Text && u.Contraseña == TBContraseña.Text).FirstOrDefault();

            Menu form = new Menu();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;

        }

        private void frm_closing(object sender , FormClosingEventArgs e)
        {
            TBUsuario.Text = "";
            TBContraseña.Text = "";

            this.Show(); // Muestra de nuevo el formulario actual cuando el formulario de inicio de sesión se cierra.
        }
    }
}
