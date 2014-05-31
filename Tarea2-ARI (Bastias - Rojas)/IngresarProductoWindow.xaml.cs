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
    /// Lógica de interacción para IngresarProductoWindow.xaml
    /// </summary>
    public partial class IngresarProductoWindow : Window
    {
        public IngresarProductoWindow()
        {
            InitializeComponent();

            ComboBoxItem cboxitem = new ComboBoxItem();
            cboxitem.Content = "-- Seleccione Tipo Producto --";

            comboTipo.Items.Add(cboxitem);
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            ProductosWindow window = new ProductosWindow();
            window.Show();
            this.Close();
        }
    }
}
