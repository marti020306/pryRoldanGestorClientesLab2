using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryRoldanGestorClientesLab2
{
    internal class clsArchivoCliente
    {
        public String NombreArchivo = "Clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim )
        {
           StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);
            AD.Close();
            AD.Dispose();

        }

        public void Listar(DataGridView Grilla)   
        {

            string DatoLeido;
            string[] VecDatos = new string[4];



            StreamReader AD = new StreamReader(NombreArchivo);
            DatoLeido = AD.ReadLine();
            Grilla.Rows.Clear();
            while (DatoLeido != null)
            {
               VecDatos = DatoLeido.Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        

    }
}
