using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Tarea2_ARI__Bastias___Rojas_
{
    /// <summary>
    /// A Linear Hash Table Implementation.
    /// Author: Carl Laufer
    /// Date: 18 February 2010
    /// Last Updated: 18 February 2010
    /// 
    /// NOTE: Almost IDictionary Compliant
    /// </summary>
    /// <typeparam name="Tkey"></typeparam>
    /// <typeparam name="Tvalue"></typeparam>

    public class HashLineal
    {
        //private FileStream stream;
        //private String filename = "lineal0.txt";
        //private bool abierto = false;
        private FileStream stream;
        private String filename = "estatico0.txt";
        private bool abierto = false;
        public MainWindow mw = new MainWindow();

        public HashLineal()
        {

        }

        public void insertarProducto(Producto producto)
        {
            try //Util para manejar exepciones
            {
                //Abre o crea el archivo en modo lectura-escritura
                stream = new FileStream(this.filename, FileMode.Append, FileAccess.Write);
                this.abierto = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la apertura de \"{0}\": {1}", filename, e.ToString());
            }

            if (!abierto)
            {
                // Si no esta abierto, no hay que escribir.
                return;
            }

            StreamWriter sw = new StreamWriter(stream);
            String registro;
            registro = producto.getId() + "&" + producto.getNombre() + "&" + producto.getTipo() + "&" +
                producto.getPrecio() + "&" + producto.getStock();

            //Escribimos la persona en el archivo
            sw.WriteLine(registro);
            sw.Close();
            stream.Close();

            //int hashing = producto.getRut();
            //hashing = hashing % 10;
            //String saveNow = DateTime.Now.ToString();

            // Insercion de Id Producto en ids.txt
            StreamReader leer1 = new StreamReader(mw.path + @"\assets\hashing_lineal\ids.txt");
            string registro1 = leer1.ReadToEnd();
            leer1.Close();

            string last_id1 = registro1.Substring(registro1.Length - 2);
            int last_id2 = Int32.Parse(last_id1) + 1;
            
            // Verificar en que archivo va last_id2 en Hashing Lineal

            //MessageBox.Show("" + last + "\n"+ registro1);

            /*
            StreamWriter escribir1 = new StreamWriter(mw.path + @"\assets\hashing_lineal\ids.txt");
            escribir1.WriteLine(registro1);
            escribir1.Close();
             */ 

            // Realizacion de Insercion en Hashing Lineal
            /*
            StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_lineal\lineal" + hashing + ".txt");
            registro = leer.ReadToEnd() + registro;
            leer.Close();
            StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_lineal\lineal" + hashing + ".txt");
            escribir.WriteLine(registro);
            escribir.Close();
            */
        }

        public string listaProductos()
        {
            string arreglo = "";

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_lineal\backup\lineal" + i + ".txt");
                    arreglo = leer.ReadToEnd();
                    leer.Close();

                    StreamReader leer1 = new StreamReader(mw.path + @"\assets\hashing_lineal\backup\overflow" + i + ".txt");

                    if (leer1.ReadLine() != null)
                    {
                        arreglo = arreglo + "\n" + leer1.ReadToEnd();
                        leer1.Close();
                    }
                }
                else
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_lineal\backup\lineal" + i + ".txt");
                    arreglo = arreglo + "\n" + leer.ReadToEnd();
                    leer.Close();

                    StreamReader leer1 = new StreamReader(mw.path + @"\assets\hashing_lineal\backup\overflow" + i + ".txt");

                    if (leer1.ReadLine() != null)
                    {
                        arreglo = arreglo + "\n" + leer1.ReadToEnd();
                        leer1.Close();
                    }
                }
            }

            return arreglo;
        }

    }
}
