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
using System.Windows.Media;

namespace LeSoleil_Taller2.Modales
{
    public partial class mdClientes : Form
    {
        public Cliente pCliente { get; set; }
        public mdClientes()
        {
            InitializeComponent();
        }

        private void mdClientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DGVClientes.Columns)
            {
                CBBusquedaCliente.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }

            CBBusquedaCliente.DisplayMember = "Texto";
            CBBusquedaCliente.ValueMember = "Valor";
            CBBusquedaCliente.SelectedIndex = 0;

            List<Cliente> listaCliente = new CN_Cliente().Listar().Where(u => u.Baja == false).ToList();

            foreach (Cliente item in listaCliente)
            {
                DGVClientes.Rows.Add(new object[] {
                    item.Id_cliente,
                    item.DNI,
                    item.Nombre,
                    item.Apellido,
                });
            }
        }

        private void DGVClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum >= 0)
            {
                pCliente = new Cliente()
                {
                    Id_cliente = Convert.ToInt32(DGVClientes.Rows[iRow].Cells["IdCliente"].Value.ToString()),
                    DNI = DGVClientes.Rows[iRow].Cells["DNI"].Value.ToString(),
                    Nombre = DGVClientes.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Apellido = DGVClientes.Rows[iRow].Cells["Apellido"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBusquedaCliente.Text = "";
            foreach (DataGridViewRow row in DGVClientes.Rows )
            {
                row.Visible = true;
            }
        }

        private void BTBuscarCliente_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CBBusquedaCliente.SelectedItem).Valor.ToString();

            if (DGVClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVClientes.Rows)
                {
                    // Ignorar la fila si es la fila de inserción nueva
                    if (row.IsNewRow)
                        continue;

                    // Verificar si el valor de la celda es null antes de acceder a ToString()
                    if (row.Cells[columnaFiltro].Value != null &&
                        row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TBusquedaCliente.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
    }
}
