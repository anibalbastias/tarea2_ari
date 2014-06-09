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
        public MainWindow mw = new MainWindow();
        public HashLineal hl = new HashLineal();
        public HashEstatico he = new HashEstatico();
        public Secuencial se = new Secuencial();

        string rut_venta = "";
        int cont = 1;
        int total=0;
        List<string> id_producto = new List<string>();
        List<string> listaVenta = new List<string>();
        
        public VentasWindow()
        {
            InitializeComponent();

            // Instanciar Tabla para Productos
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
                    items.Add(new Product() {Id = arr2[0], Num = j, Producto = arr2[1], Tipo = arr2[2], Precio = "$ " + arr2[3], Stock = arr2[4].Replace("\r", ""), Opciones = b });
                    j++;
                }
            }
            listViewProductos.ItemsSource = items;

            // Instanciar Tabla para Funcionarios
            // Instanciar Tabla 
            string arreglo1 = he.listaFuncionarios();
            string[] arr3 = arreglo1.Split('\n');
            List<User> items1 = new List<User>();

            int k = 1;
            
            for (int i = 0; i < arr3.Length; i++)
            {
                Button b1 = new Button();
                b1.Name = "Ver";

                if (!arr3[i].Equals(""))
                {
                    string[] arr4 = arr3[i].Split('&');
                    items1.Add(new User() { Num = k, Rut = arr4[0], Nombre = arr4[1] + " " + arr4[2] + " " + arr4[3], Opciones = b1});
                    k++;
                } 
            }
            listViewFuncionarios.ItemsSource = items1;
        }

        public class User
        {
            public int Num { get; set; }
            public string Rut { get; set; }
            public string Nombre { get; set; }
            public Button Opciones { get; set; }
        }

        public class Product
        {
            public string Id { get; set; }
            public int Num { get; set; }
            public string Producto { get; set; }
            public string Tipo { get; set; }
            public string Precio { get; set; }
            public string Stock { get; set; }
            public Button Opciones { get; set; }
        }

        public class Venta
        {
            public string Id { get; set; }
            public string Num { get; set; }
            public string Producto { get; set; }
            public string Precio { get; set; }
            public Button Opciones { get; set; }
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Product producto = b.CommandParameter as Product;
            List<Venta> items_total = new List<Venta>();

            id_producto.Add(producto.Id);

            total += Int32.Parse(producto.Precio.ToString().Replace("$ ",""));

            txtTotal.Text = " Total: $ " + total;

            // Instanciar Tabla para Ventas
            items_total.Add(new Venta() { Id = producto.Id, Num = ""+cont, Producto = producto.Producto, Precio = producto.Precio, Opciones = b });
            listaVenta.Add("");

            DateTime now = DateTime.Now;
            string[] fecha = now.ToString("dd/MM/yyyy h:mm:ss").Split(' ');
            string lista_venta = listaVentas.Text.ToString();

            lista_venta += producto.Id + "&" + rut_venta + "&" + total + "&" + fecha[0] + "&" + fecha[1];

            se.insertarVentas(lista_venta);

            MessageBox.Show("Producto Agregado a Venta");

            cont++;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            User funcionario = b.CommandParameter as User;

            string[] rut1 = funcionario.Rut.Split('-');

            txtBlockFuncionario.Text = funcionario.Nombre;
            rut_venta = rut1[0];
        }
    }
}
