using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tarea2_ARI__Bastias___Rojas_
{
    class HashEstatico
    {
        private FileStream stream;
        private String filename ="estatico0.txt";
        private bool abierto = false;
        public MainWindow mw = new MainWindow();

        public HashEstatico()
        {

        }

        //Sobrecarga del metodo.
        public void insertarFuncionario(Funcionario funcionario)
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
            registro = funcionario.getRut() + "-" + funcionario.getDV() + "&" + funcionario.getNombre() + "&" + 
                funcionario.getApellidoPat() + "&" + funcionario.getCarrera();

            //Escribimos la persona en el archivo
            sw.WriteLine(registro);
            sw.Close();
            stream.Close();

            int hashing = funcionario.getRut();
            hashing = hashing % 10;
            //String saveNow = DateTime.Now.ToString();
            String line = funcionario.getRut() + "-" + funcionario.getDV() + "&" + funcionario.getNombre() + "&" + 
                funcionario.getApellidoPat() + "&" + funcionario.getApellidoMat() + "&" + funcionario.getCarrera();

            if (hashing == 0)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico0.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico0.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 1)
            {

                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico1.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico1.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 2)
            {
                //FileStream fs = new FileStream((@"C:\Users\Marcos\Desktop\2.txt"));

                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico2.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico2.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 3)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico3.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico3.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 4)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico4.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico4.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 5)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico5.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico5.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 6)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico6.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico6.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 7)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico7.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico7.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 8)
            {
                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico8.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico9.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }

            if (hashing == 9)
            {

                StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico9.txt");
                line = leer.ReadToEnd() + line;
                leer.Close();
                StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico9.txt");
                escribir.WriteLine(line);
                escribir.Close();

            }
        }

        public string listaFuncionarios()
        {
            string arreglo = "";

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + i + ".txt");
                    if (!leer.ReadToEnd().Equals(""))
                        arreglo = leer.ReadToEnd();
                    leer.Close();
                }
                else
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + i + ".txt");

                    if(!leer.ReadToEnd().Equals(""))
                        arreglo = arreglo+"\n"+leer.ReadToEnd();
                    leer.Close();
                }
            }

            return arreglo;
        }
    }
}
