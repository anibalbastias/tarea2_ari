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
                funcionario.getApellidoPat() + "&" + funcionario.getApellidoMat() + "&" + funcionario.getCarrera();

            //Escribimos la persona en el archivo
            sw.WriteLine(registro);
            sw.Close();
            stream.Close();

            int hashing = funcionario.getRut();
            hashing = hashing % 10;
            //String saveNow = DateTime.Now.ToString();

            // Realizacion de Insercion en Hashing

            StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + hashing + ".txt");
            registro = leer.ReadToEnd() + registro;
            leer.Close();
            StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico" + hashing + ".txt");
            escribir.WriteLine(registro);
            escribir.Close();
        }

        public string listaFuncionarios()
        {
            string arreglo = "";

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + i + ".txt");
                    arreglo = leer.ReadToEnd();
                    leer.Close();
                }
                else
                {
                    StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + i + ".txt");
                    arreglo = arreglo+"\n"+leer.ReadToEnd();
                    leer.Close();
                }
            }

            return arreglo;
        }

        internal void modificarFuncionario(Funcionario funcionario)
        {
            try //Util para manejar exepciones
            {
                //Abre o crea el archivo en modo lectura-escritura
                stream = new FileStream(this.filename, FileMode.Create, FileAccess.Write);
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
                funcionario.getApellidoPat() + "&" + funcionario.getApellidoMat() + "&" + funcionario.getCarrera();

            //Escribimos la persona en el archivo
            sw.WriteLine(registro);
            sw.Close();
            stream.Close();

            int hashing = funcionario.getRut();
            hashing = hashing % 10;
            
            // Realizacion de Insercion en Hashing

            StreamReader leer = new StreamReader(mw.path + @"\assets\hashing_estatico\estatico" + hashing + ".txt");
            registro = leer.ReadToEnd() + registro;
            leer.Close();

            StreamWriter escribir = new StreamWriter(mw.path + @"\assets\hashing_estatico\estatico" + hashing + ".txt");
            escribir.WriteLine(registro);
            escribir.Close();

        }
    }
}
