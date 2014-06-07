using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tarea2_ARI__Bastias___Rojas_
{
    class Secuencial
    {
        // Atributos de la clase
        private FileStream stream;
        private string filename;
        private bool abierto = false;
        private int i;

        // Constructor: Recibe el nombre del archivo e inicia apertura (con control de errores)
        public Secuencial(string filename)
        {
            this.filename = filename;
            this.i = 0;
        }

        // Metodo para mostrar el contenido del archivo
        public void Mostrar(ref System.Windows.Forms.ListBox lista)
        {
            string sLine;
            StreamReader sr;

            // Manejo de excepciones
            try
            {
                stream = new System.IO.FileStream(filename, FileMode.Open, FileAccess.Read);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Archivo no encontrado");
                throw new FileNotFoundException();
            }

            sr = new StreamReader(stream);

            for (sLine = sr.ReadLine(); sLine != null; sLine = sr.ReadLine())
            {
                lista.Items.Add(sLine);
                i++;
            }

            sr.Close();
            stream.Close();
        }

        // Contador
        public int contador()
        {
            return i;
        }

        // Metodo para escribir archivo
        public void Escribir(string active)
        {
            try
            {
                // Abre o crea el archivo en modo de lectura y escritura
                stream = new FileStream(this.filename, FileMode.Append, FileAccess.Write);
                this.abierto = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de apertura de \"{0}\": {1}", filename, e.ToString());
            }

            if (!abierto)
            {
                // Si no esta abierto, no se escribe en el archivo
                return;
            }

            StreamWriter sw = new StreamWriter(stream);

            // Se escribe el string en el archivo
            sw.WriteLine(active);
            sw.Close();
            stream.Close();

        }
    }
}
