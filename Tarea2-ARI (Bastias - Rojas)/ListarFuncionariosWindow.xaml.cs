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
    /// Lógica de interacción para ListarFuncionariosWindow.xaml
    /// </summary>
    public partial class ListarFuncionariosWindow : Window
    {
        public ListarFuncionariosWindow()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosWindow window = new FuncionariosWindow();
            window.Show();
            this.Close();
        }
    }
}
