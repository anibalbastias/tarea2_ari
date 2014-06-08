using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

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
        public MainWindow mw = new MainWindow();

        public HashLineal()
        {

        }

        public string listaProductos()
        {
            string arreglo = "";

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_lineal\lineal" + i + ".txt");
                    arreglo = leer.ReadToEnd();
                    leer.Close();

                    StreamReader leer1 = new StreamReader(mw.path + @"\assets\hashing_lineal\overflow" + i + ".txt");

                    if (leer1.ReadLine() != null)
                    {
                        arreglo = arreglo + "\n" + leer1.ReadToEnd();
                        leer1.Close();
                    }
                }
                else
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_lineal\lineal" + i + ".txt");
                    arreglo = arreglo + "\n" + leer.ReadToEnd();
                    leer.Close();

                    StreamReader leer1 = new StreamReader(mw.path + @"\assets\hashing_lineal\overflow" + i + ".txt");

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
