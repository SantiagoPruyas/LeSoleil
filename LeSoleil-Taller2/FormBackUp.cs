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
    public partial class FormBackUp : Form
    {
        Usuario usuarioActual = new Usuario();
        public FormBackUp(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario; 
        }

        private void FormBackUp_Load(object sender, EventArgs e)
        {
            // Mostrar todos las categorias activos en la tabla
            List<Auditoria> listaBackUp = new CN_Auditoria().Listar().ToList();

            foreach (Auditoria item in listaBackUp)
            {
                DGVBackUps.Rows.Add(new object[] {
                    item.Id_auditoria,
                    item.oUsuario.Nombre,
                    item.Estado,
                    item.Fecha,
                    item.Ubicacion,
                });
            }
        }

        private void BBackUp_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            CN_Auditoria nuevo_registro = new CN_Auditoria();

            bool respuesta = nuevo_registro.Registrar(usuarioActual.Id_usuario, out Mensaje);

            if (respuesta)
            {
                MessageBox.Show("Back Up generado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }
    }
}
