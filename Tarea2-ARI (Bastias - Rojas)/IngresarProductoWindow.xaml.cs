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

            ComboBoxItem cboxitem1 = new ComboBoxItem();
            cboxitem1.Content = "Bebestible";
            comboTipo.Items.Add(cboxitem1);

            ComboBoxItem cboxitem2 = new ComboBoxItem();
            cboxitem2.Content = "Confiteria";
            comboTipo.Items.Add(cboxitem2);

            ComboBoxItem cboxitem3 = new ComboBoxItem();
            cboxitem3.Content = "Lacteos";
            comboTipo.Items.Add(cboxitem3);

            ComboBoxItem cboxitem4 = new ComboBoxItem();
            cboxitem4.Content = "Cigarros";
            comboTipo.Items.Add(cboxitem4);

            ComboBoxItem cboxitem5 = new ComboBoxItem();
            cboxitem5.Content = "Masas";
            comboTipo.Items.Add(cboxitem5);
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
