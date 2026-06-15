using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRoldanGestorClientesLab2
{
    internal class clsArchivoCliente
    {
        public String NombreArchivo = "Clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);

            AD.Write(cod + ";");
            AD.Write(nom + ";");
            AD.Write(deu + ";");
            AD.WriteLine(lim);

            AD.Close();
        }

        public void Listar(DataGridView grilla)
        {
            if (!File.Exists(NombreArchivo))
                return;

            grilla.Rows.Clear();

            foreach (string linea in File.ReadAllLines(NombreArchivo))
            {
                string[] datos = linea.Split(';');
                grilla.Rows.Add(datos[0], datos[1], datos[2], datos[3]);
            }
        }

        public void ListarDeudores(DataGridView grilla)
        {
            if (!File.Exists(NombreArchivo))
                return;

            grilla.Rows.Clear();

            foreach (string linea in File.ReadAllLines(NombreArchivo))
            {
                string[] datos = linea.Split(';');

                if (Convert.ToDouble(datos[2]) > 0)
                {
                    grilla.Rows.Add(datos[0], datos[1], datos[2], datos[3]);
                }
            }
        }

        public int CantidadClientes()
        {
            if (!File.Exists(NombreArchivo))
                return 0;

            return File.ReadAllLines(NombreArchivo).Length;
        }

        public double TotalDeuda()
        {
            double total = 0;

            if (!File.Exists(NombreArchivo))
                return 0;

            foreach (string linea in File.ReadAllLines(NombreArchivo))
            {
                string[] datos = linea.Split(';');
                total += Convert.ToDouble(datos[2]);
            }

            return total;
        }

        public double PromedioDeuda()
        {
            int cantidad = CantidadClientes();

            if (cantidad == 0)
                return 0;

            return TotalDeuda() / cantidad;
        }

        public DataTable ObtenerTabla()
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Deuda");
            tabla.Columns.Add("Limite");

            if (!File.Exists(NombreArchivo))
                return tabla;

            foreach (string linea in File.ReadAllLines(NombreArchivo))
            {
                tabla.Rows.Add(linea.Split(';'));
            }

            return tabla;
        }




    }
}
