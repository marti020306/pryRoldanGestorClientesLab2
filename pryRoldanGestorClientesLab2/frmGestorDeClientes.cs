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
    }
}
