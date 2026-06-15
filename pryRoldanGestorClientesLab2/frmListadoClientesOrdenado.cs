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
    public partial class frmListadoClientesOrdenado : Form
    {
        public frmListadoClientesOrdenado()
        {
            InitializeComponent();
        }
        clsArchivoCliente x = new clsArchivoCliente();

        private void frmListadoClientesOrdenado_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable tabla = x.ObtenerTabla();

            DataView vista = tabla.DefaultView;

            string orden =
                cmbModo.Text == "Ascendente"
                ? "ASC"
                : "DESC";

            vista.Sort = cmbCampo.Text + " " + orden;

            dataGridView1.Rows.Clear();

            foreach (DataRow fila in vista.ToTable().Rows)
            {
                dataGridView1.Rows.Add(
                    fila["Codigo"],
                    fila["Nombre"],
                    fila["Deuda"],
                    fila["Limite"]);
            }
        }


        

    }
}
