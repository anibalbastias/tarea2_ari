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
            string arreglo = he.listaFuncionarios();
            string[] arr1 = arreglo.Split('\n');
            List<User> items = new List<User>();

            int j = 1;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                Button b = new Button();
                b.Name = "Ver";

                if (!arr1[i].Equals(""))
                {
                    string[] arr2 = arr1[i].Split('&');
                    items.Add(new User() { Num = j, Rut = arr2[0], Nombre = arr2[1] + " " + arr2[2] + " " + arr2[3], Carrera = arr2[4].Replace("\r",""), Opciones = b});
                    j++;
                }
                
            }
            listViewUsuarios.ItemsSource = items;
        }

        public class User
        {
            public int Num { get; set; }
            public string Rut { get; set; }
            public string Nombre { get; set; }
            public string Carrera { get; set; }
            public Button Opciones { get; set; }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosWindow window = new FuncionariosWindow();
            window.Show();
            this.Close();
        }

        private void verFuncionario(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            User funcionario = b.CommandParameter as User;
            MessageBox.Show("RUT:\t"+funcionario.Rut+"\n"+
                            "Nombre:\t"+funcionario.Nombre+"\n"+
                            "Carrera:\t"+funcionario.Carrera+"\n"
                            );
        }

        private void editarFuncionario(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            User funcionario = b.CommandParameter as User;
            
            EditarFuncionarioWindow window = new EditarFuncionarioWindow(funcionario.Rut,funcionario.Nombre, funcionario.Carrera);
            window.Show();
            this.Close();
        }
    }
}
