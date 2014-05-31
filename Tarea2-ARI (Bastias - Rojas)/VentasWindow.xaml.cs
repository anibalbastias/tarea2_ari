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
    /// Lógica de interacción para VentasWindow.xaml
    /// </summary>
    public partial class VentasWindow : Window
    {
        public VentasWindow()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnPagar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Venta Confirmada");
        }

        private void btnFuncionariosDestacados_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
