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
    /// Lógica de interacción para EditarProductoWindow.xaml
    /// </summary>
    public partial class EditarProductoWindow : Window
    {

        public EditarProductoWindow()
        {
            InitializeComponent();
            llenarTipoProducto();
        }

        // Sobrecarga de metodo
        public EditarProductoWindow(string nombre, string tipo, string precio, string stock)
        {
            InitializeComponent();
            llenarTipoProducto();

            txtBlockNombre.Text = nombre;
            comboTipo.Text = tipo;
            txtBoxPrecio.Text = precio;
            txtBoxStock.Text = stock;
        }

        private void llenarTipoProducto()
        {
            ComboBoxItem cboxitem1 = new ComboBoxItem();
            cboxitem1.Content = "Bebestible".ToUpper();
            comboTipo.Items.Add(cboxitem1);

            ComboBoxItem cboxitem2 = new ComboBoxItem();
            cboxitem2.Content = "Confiteria".ToUpper();
            comboTipo.Items.Add(cboxitem2);

            ComboBoxItem cboxitem3 = new ComboBoxItem();
            cboxitem3.Content = "Lacteo".ToUpper();
            comboTipo.Items.Add(cboxitem3);

            ComboBoxItem cboxitem4 = new ComboBoxItem();
            cboxitem4.Content = "Cigarros".ToUpper();
            comboTipo.Items.Add(cboxitem4);

            ComboBoxItem cboxitem5 = new ComboBoxItem();
            cboxitem5.Content = "Masas".ToUpper();
            comboTipo.Items.Add(cboxitem5);
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBlockNombre.Text) &&
                !String.IsNullOrEmpty(comboTipo.Text) &&
                !String.IsNullOrEmpty(txtBoxPrecio.Text) &&
                !String.IsNullOrEmpty(txtBoxStock.Text)
                )
            {
                Producto prod1 = new Producto(txtBlockNombre.Text.ToString(), comboTipo.Text.ToString(),
                    Int32.Parse(txtBoxPrecio.Text.ToString()), Int32.Parse(txtBoxStock.Text.ToString()));

                //hl.editarProducto(prod1);

                ProductosWindow window = new ProductosWindow();
                window.Show();
                this.Close();

                MessageBox.Show("Producto actualizado correctamente");
            }
            else
            {
                if (txtBlockNombre.Text.Trim().Length == 0)
                {
                    imageError1.Visibility = Visibility.Visible;
                    txtError1.Visibility = Visibility.Visible;
                }
                else
                {
                    imageError1.Visibility = Visibility.Hidden;
                    txtError1.Visibility = Visibility.Hidden;
                }

                if (comboTipo.Text.Trim().Length == 0)
                {
                    imageError2.Visibility = Visibility.Visible;
                    txtError2.Visibility = Visibility.Visible;
                }
                else
                {
                    imageError2.Visibility = Visibility.Hidden;
                    txtError2.Visibility = Visibility.Hidden;
                }

                if (txtBoxPrecio.Text.Trim().Length == 0)
                {
                    imageError3.Visibility = Visibility.Visible;
                    txtError3.Visibility = Visibility.Visible;
                }
                else
                {
                    imageError3.Visibility = Visibility.Hidden;
                    txtError3.Visibility = Visibility.Hidden;
                }

                if (txtBoxStock.Text.Trim().Length == 0)
                {
                    imageError4.Visibility = Visibility.Visible;
                    txtError4.Visibility = Visibility.Visible;
                }
                else
                {
                    imageError4.Visibility = Visibility.Hidden;
                    txtError4.Visibility = Visibility.Hidden;
                }
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            ListarProductosWindow window = new ListarProductosWindow();
            window.Show();
            this.Close();
        }

        private void txtBlockNombre_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtBlockNombre.Text.Trim().Length == 0)
            {
                imageError1.Visibility = Visibility.Visible;
                txtError1.Visibility = Visibility.Visible;
            }
            else
            {
                imageError1.Visibility = Visibility.Hidden;
                txtError1.Visibility = Visibility.Hidden;
            }
        }

        private void txtBlockNombre_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void comboTipo_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (comboTipo.Text.Trim().Length == 0)
            {
                imageError2.Visibility = Visibility.Visible;
                txtError2.Visibility = Visibility.Visible;
            }
            else
            {
                imageError2.Visibility = Visibility.Hidden;
                txtError2.Visibility = Visibility.Hidden;
            }
        }

        private void comboTipo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (comboTipo.Text.Trim().Length == 0)
            {
                imageError2.Visibility = Visibility.Visible;
                txtError2.Visibility = Visibility.Visible;
            }
            else
            {
                imageError2.Visibility = Visibility.Hidden;
                txtError2.Visibility = Visibility.Hidden;
            }
        }

        private void txtBoxPrecio_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtBoxPrecio.Text.Trim().Length == 0)
            {
                imageError3.Visibility = Visibility.Visible;
                txtError3.Visibility = Visibility.Visible;
            }
            else
            {
                imageError3.Visibility = Visibility.Hidden;
                txtError3.Visibility = Visibility.Hidden;
            }
        }

        private void txtBoxPrecio_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxStock_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (txtBoxStock.Text.Trim().Length == 0)
            {
                imageError4.Visibility = Visibility.Visible;
                txtError4.Visibility = Visibility.Visible;
            }
            else
            {
                imageError4.Visibility = Visibility.Hidden;
                txtError4.Visibility = Visibility.Hidden;
            }
        }

        private void txtBoxStock_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
