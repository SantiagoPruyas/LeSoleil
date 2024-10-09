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
    public partial class UsuariosFormEditar : Form
    {
        private int rowIndex;
        private UsuariosForm usuariosForm;  // Referencia al formulario principal

        public UsuariosFormEditar(string id, string nombre, string apellido, string dni, string usuario, string contraseña,
            string email, string direccion, string perfil, string telefono, int rowIndex, UsuariosForm usuariosForm)
        {
            InitializeComponent();
            this.usuariosForm = usuariosForm;
            this.rowIndex = rowIndex;

            // Cargar los valores actuales en los TextBox y demás controles
            LIDUser.Text = id;
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

            string Mensaje = string.Empty;
            int IdUsuario = Convert.ToInt32(LIDUser.Text);

            Usuario objUsuario = new Usuario() { 
                Id_usuario = IdUsuario,
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
                Fecha_nacimiento = "2000-04-02"
            };

            bool resultado = new CN_Usuario().Editar(objUsuario, out Mensaje);

            if (resultado)
            {
                usuariosForm.ActualizarUsuario(rowIndex, IdUsuario, TBNombreUser.Text, TBApellidoUser.Text, TBDniUser.Text,
                TBUsuarioUser.Text, TBContraseñaUser.Text, TBEmailUser.Text, TBDireccionUser.Text, CBPerfilUser.Text,
                TBTelefonoUser.Text);
                this.Close();
            } else
            {
                MessageBox.Show(Mensaje);
            }
        }

        private void BEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuariosFormEditar_Load(object sender, EventArgs e)
        {
            List<Perfil> listaPerfil = new CN_Perfil().Listar();

            foreach (Perfil item in listaPerfil)
            {
                CBPerfilUser.Items.Add(new OpcionCombo() { Valor = item.Perfil_id, Texto = item.NombreRol });
                CBPerfilUser.DisplayMember = "Texto";
                CBPerfilUser.ValueMember = "Valor";
                CBPerfilUser.SelectedIndex = 0;
            }
        }
    }
}
