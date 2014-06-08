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
    /// Lógica de interacción para ListarProductosWindow.xaml
    /// </summary>
    public partial class ListarProductosWindow : Window
    {
        HashLineal hl = new HashLineal();

        public ListarProductosWindow()
        {
            InitializeComponent();

            // Instanciar Tabla 
            string arreglo = hl.listaProductos();
            string[] arr1 = arreglo.Split('\n');
            List<Product> items = new List<Product>();

            int j = 1;

            for (int i = 0; i < arr1.Length; i++)
            {
                Button b = new Button();
                b.Name = "Ver";

                if (!arr1[i].Equals(""))
                {
                    string[] arr2 = arr1[i].Split('&');
                    items.Add(new Product() { Num = j, Nombre = arr2[1], Tipo = arr2[2], Precio = "$ " + arr2[3], Stock = arr2[4].Replace("\r", ""), Opciones = b });
                    j++;
                }
            }
            listViewUsuarios.ItemsSource = items;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            ProductosWindow window = new ProductosWindow();
            window.Show();
            this.Close();
        }

        public class Product
        {
            public int Num { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Precio { get; set; }
            public string Stock { get; set; }
            public Button Opciones { get; set; }
        }

        private void verProducto(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Product prod = b.CommandParameter as Product;
            MessageBox.Show("Nombre:\t" + prod.Nombre + "\n" +
                            "Tipo:\t" + prod.Tipo + "\n" +
                            "Precio:\t" + prod.Precio + "\n" +
                            "Stock:\t" + prod.Stock + " unidades\n"
                            );
        }

        private void editarProducto(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Product prod = b.CommandParameter as Product;

            EditarProductoWindow window = new EditarProductoWindow(prod.Nombre, prod.Tipo, prod.Precio.Replace("$ ",""), prod.Stock);
            window.Show();
            this.Close();
        }
    }
}
