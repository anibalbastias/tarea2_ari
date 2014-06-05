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


namespace Tarea2_ARI__Bastias___Rojas_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInicializar_Click(object sender, RoutedEventArgs e)
        {

            //Lee archivo 

            /*
            const string fic = @"C:\Users\casa\Desktop\universidad\2014-1 sem\ari\tarea2\t_anibal\tarea2_ari\Tarea2-ARI (Bastias - Rojas)\productos.txt";
            string texto;

            System.IO.StreamReader sr = new System.IO.StreamReader(fic);
            texto = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(texto);
            Console.WriteLine(texto);
            Console.Read();


            //Escribe archivo

            // Compose a string that consists of three lines.
            string lines = texto;

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\casa\Desktop\universidad\2014-1 sem\ari\tarea2\t_anibal\tarea2_ari\Tarea2-ARI (Bastias - Rojas)\resultado.txt");
            file.WriteLine(lines);

            file.Close();

            */
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
