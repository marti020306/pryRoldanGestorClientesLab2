using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRoldanGestorClientesLab2
{
    public partial class frmGestorDeClientes : Form
    {
        public frmGestorDeClientes()
        {
            InitializeComponent();
        }

        private void acercaDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador datosDesarrollador = new frmDatosDesarrollador();
            datosDesarrollador.ShowDialog();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaClientes cargaClientes = new frmCargaClientes();
            cargaClientes.ShowDialog();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes listadoClientes = new frmListadoClientes();
            listadoClientes.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesOrdenado listadoClientesOrdenado = new frmListadoClientesOrdenado();
            listadoClientesOrdenado.ShowDialog();
        }

        private void clientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientesOrdenado listadoClientesDeudores = new frmListadoClientesOrdenado();
            listadoClientesDeudores.ShowDialog();
        }

        private void frmGestorDeClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("Clientes.csv"))
            {
                File.WriteAllText("Clientes.csv", "");
            }

        }
    }
}
