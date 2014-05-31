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
    /// Lógica de interacción para ProductosWindow.xaml
    /// </summary>
    public partial class ProductosWindow : Window
    {
        public ProductosWindow()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnIngresarProducto_Click(object sender, RoutedEventArgs e)
        {
            IngresarProductoWindow window = new IngresarProductoWindow();
            window.Show();
            this.Close();
        }

        private void btnListarProductos_Click(object sender, RoutedEventArgs e)
        {
            ListarProductosWindow window = new ListarProductosWindow();
            window.Show();
            this.Close();
        }
    }
}
