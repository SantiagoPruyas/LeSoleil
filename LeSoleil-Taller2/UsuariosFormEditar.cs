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
    public partial class UsuariosFormEditar : Form
    {
        private int rowIndex;
        private UsuariosForm usuariosForm;  // Referencia al formulario principal

        public UsuariosFormEditar(string nombre, string apellido, string dni, string usuario, string contraseña,
            string email, string direccion, string perfil, string telefono, DateTime fechaNacimiento, int rowIndex, UsuariosForm usuariosForm)
        {
            InitializeComponent();
            this.usuariosForm = usuariosForm;
            this.rowIndex = rowIndex;

            // Cargar los valores actuales en los TextBox y demás controles
            TBNombreUser.Text = nombre;
            TBApellidoUser.Text = apellido;
            TBDniUser.Text = dni;
            TBUsuarioUser.Text = usuario;
            TBContraseñaUser.Text = contraseña;
            TBEmailUser.Text = email;
            TBDireccionUser.Text = direccion;
            CBPerfilUser.Text = perfil;
            TBTelefonoUser.Text = telefono;
            DTPFechaNacimiento.Value = fechaNacimiento;
        }

        private void BEditarGuardar_Click(object sender, EventArgs e)
        {
            UsuariosForm usuariosForm = (UsuariosForm)this.Owner;
            usuariosForm.ActualizarUsuario(rowIndex, TBNombreUser.Text, TBApellidoUser.Text, TBDniUser.Text,
                TBUsuarioUser.Text, TBContraseñaUser.Text, TBEmailUser.Text, TBDireccionUser.Text, CBPerfilUser.Text,
                TBTelefonoUser.Text, DTPFechaNacimiento.Value);

            this.Close();
        }

        private void BEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
