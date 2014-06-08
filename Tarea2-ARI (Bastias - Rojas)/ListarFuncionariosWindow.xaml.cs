using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Tarea2_ARI__Bastias___Rojas_
{
    /// <summary>
    /// Lógica de interacción para ListarFuncionariosWindow.xaml
    /// </summary>
    public partial class ListarFuncionariosWindow : Window
    {
        HashEstatico he = new HashEstatico();

        public ListarFuncionariosWindow()
        {
            InitializeComponent();

            // Instanciar Tabla 

            /*
            List<User> items = new List<User>();
            items.Add(new User() { Num = "1", Rut = "16846047-3", Nombre = "Anibal Bastias Soto", Carrera = "Ingenieria Informatica"});
            items.Add(new User() { Num = "2", Rut = "7271029-0", Nombre = "Morelia Soto Ahumada", Carrera = "Pedagogia General Basica"});
            items.Add(new User() { Num = "3", Rut = "19017217-1", Nombre = "Sandra Orellana Rivera", Carrera ="Trabajo Social" });
            listViewUsuarios.ItemsSource = items;
            */

            string arreglo = he.listaFuncionarios();
            string[] arr1 = arreglo.Split('\n');
            List<User> items = new List<User>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1[i].Equals(""))
                {
                    string[] arr2 = arr1[i].Split('&');
                    items.Add(new User() { Num = i + 1, Rut = arr2[0], Nombre = arr2[1] + " " + arr2[2] + " " + arr2[3], Carrera = arr2[4] });
                }
                
            }
            listViewUsuarios.ItemsSource = items;

            MessageBox.Show(arreglo);

        }

        public class User
        {
            public int Num { get; set; }
            public string Rut { get; set; }
            public string Nombre { get; set; }
            public string Carrera { get; set; }
            public string Opciones { get; set; }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosWindow window = new FuncionariosWindow();
            window.Show();
            this.Close();
        }

    }
}
