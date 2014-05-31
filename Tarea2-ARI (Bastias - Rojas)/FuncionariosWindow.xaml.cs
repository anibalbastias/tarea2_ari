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
using System.Windows.Shapes;

namespace Tarea2_ARI__Bastias___Rojas_
{
    /// <summary>
    /// Lógica de interacción para FuncionariosWindow.xaml
    /// </summary>
    public partial class FuncionariosWindow : Window
    {
        public FuncionariosWindow()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnIngresarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            IngresarFuncionarioWindow window = new IngresarFuncionarioWindow();
            window.Show();
            this.Close();
        }

        private void btnListarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionariosWindow window = new ListarFuncionariosWindow();
            window.Show();
            this.Close();
        }
    }
}
