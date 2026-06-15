using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRoldanGestorClientesLab2
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        clsArchivoCliente x = new clsArchivoCliente();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblBlancoCantidad.Text = x.CantidadClientes().ToString();
            lblBlancoTotal.Text = x.TotalDeuda().ToString("0.00");
            lblBlancoPromedio.Text = x.PromedioDeuda().ToString("0.00");

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblBlancoCantidad.Text = x.CantidadClientes().ToString();
            lblBlancoTotal.Text = x.TotalDeuda().ToString("0.00");
            lblBlancoPromedio.Text = x.PromedioDeuda().ToString("0.00");

            MessageBox.Show(
                "Reporte generado correctamente",
                "Reporte",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dgvClientes.Rows.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvClientes.Rows.Count - 1; i++)
            {
                for (int j = i + 1; j < dgvClientes.Rows.Count - 1; j++)
                {
                    int codigo1 = Convert.ToInt32(dgvClientes.Rows[i].Cells[0].Value);
                    int codigo2 = Convert.ToInt32(dgvClientes.Rows[j].Cells[0].Value);

                    if (codigo1 > codigo2)
                    {
                        for (int k = 0; k < dgvClientes.Columns.Count; k++)
                        {
                            object aux = dgvClientes.Rows[i].Cells[k].Value;
                            dgvClientes.Rows[i].Cells[k].Value =
                                dgvClientes.Rows[j].Cells[k].Value;
                            dgvClientes.Rows[j].Cells[k].Value = aux;
                        }
                    }
                }
            }

            MessageBox.Show("Listado ordenado correctamente");





        }
    }
}
