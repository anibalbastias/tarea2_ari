using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Tarea2_ARI__Bastias___Rojas_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string path = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public static int Contador(string RUTA){


            string fic = RUTA;            
            System.IO.StreamReader sr = new System.IO.StreamReader(fic);  //carga el fichero en la variable sr para poder manipularlo

            int count = 0;
            string lineas;
            
            // recorre las lineas del archivo productos.txt
            while ((lineas = sr.ReadLine()) != null)
            {
                count++;

            }
            // fin recorrido de lineas del archivo productos.txt


            sr.Close();
            Console.WriteLine(count);

            return count;
        }

        private void btnInicializar_Click(object sender, RoutedEventArgs e)
        {
            
            string fic = path+@"\assets\hashing_lineal\productos.txt";  //lee el archivo productos.txt               

            System.IO.StreamReader sr = new System.IO.StreamReader(fic);  //carga el fichero en la variable sr para poder manipularlo

            // inicializacion de variables
            int i = 0;
            string texto;
            int ocurrencia = 0;
            int valor;
            int j = 0;
            string binary;
            string sub_string;
            int capacidad = 3;
            // fin inicializacion de variables


            //creacion de archivos estaticos

            FileInfo est;
            StreamWriter writer_estatico;
            for (int var = 1; var <= 10; var++)
            {
                est = new FileInfo(path + @"\assets\hashing_estatico\estatico" + var + ".txt");
                writer_estatico = est.AppendText();
                writer_estatico.Close();
            }

            //fin creacion de archivos estaticos


            //Console.WriteLine("cantidad de lineas - " + Contador(@"C:\Users\casa\Desktop\universidad\2014-1 sem\ari\tarea2\t_anibal\tarea2_ari\Tarea2-ARI (Bastias - Rojas)\assets\productos.txt"));


            // System.IO.StreamWriter file;

            FileInfo f;
            StreamWriter writer;

            // recorre las lineas del archivo productos.txt
            while ((texto = sr.ReadLine()) != null)
            {

                ocurrencia = texto.IndexOf("&"); // obtiene la primera ocurrencia de '&'
                sub_string = texto.Substring(0, ocurrencia); // obtiene el sub string hasta la primera ocurrencia de '&'
                valor = Convert.ToInt32(sub_string); // convierte el numero string a numero int
                binary = Convert.ToString(valor, 2); // convierte el entero a binario

                if (System.IO.File.Exists(path + @"\assets\hashing_lineal\resultado" + j + ".txt"))
                {


                    if (Contador(path + @"\assets\hashing_lineal\resultado" + j + ".txt") < capacidad)
                    {

                        f = new FileInfo(path + @"\assets\hashing_lineal\resultado" + j + ".txt");

                        writer = f.AppendText();
                        writer.WriteLine(texto);
                        writer.Close();

                    }
                    else
                    {

                        f = new FileInfo(path + @"\assets\hashing_lineal\resultado" + j + ".txt");



                        writer = f.AppendText();
                        writer.WriteLine(texto);
                        writer.Close();

                        j++;
                    }

                }
                else
                {
                    f = new FileInfo(path + @"\assets\hashing_lineal\resultado" + j + ".txt");


                    writer = f.AppendText();
                    writer.WriteLine(texto);
                    writer.Close();

                }


                //Console.WriteLine(sub_string+" - "+binary+" - "+binary.Length);
            }
            // fin recorrido de lineas del archivo productos.txt


            sr.Close();
        }

        private void btnVentas_Click(object sender, RoutedEventArgs e)
        {
            VentasWindow window = new VentasWindow();
            window.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            ProductosWindow window = new ProductosWindow();
            window.Show();
            this.Close();
        }

        private void btnFuncionarios_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosWindow window = new FuncionariosWindow();
            window.Show();
            this.Close();
        }
    }
}
