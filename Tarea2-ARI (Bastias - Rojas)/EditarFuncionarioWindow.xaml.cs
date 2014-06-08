using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para IngresarFuncionarioWindow.xaml
    /// </summary>
    public partial class EditarFuncionarioWindow : Window
    {
        Funcionario func = new Funcionario();
        HashEstatico he = new HashEstatico();

        // SobreCarga de Metodo para Editar Funcionario
        public EditarFuncionarioWindow(string rut, string nombre, string carrera)
        {
            InitializeComponent();
            loadCarreras();

            // Split Rut
            string[] rut1 = rut.Split('-');
            string[] nombre1 = nombre.Split(' ');

            txtBoxRut.Text = rut1[0];
            txtBoxRut.IsEnabled = false;

            txtBoxRutDV.Text = rut1[1];
            txtBoxRutDV.IsEnabled = false;

            txtBoxNombre.Text = nombre1[0];
            txtBoxApPaterno.Text = nombre1[1];
            txtBoxApMaterno.Text = nombre1[2];

            comboCarrera.Text = carrera;
        }

        public EditarFuncionarioWindow()
        {
            InitializeComponent();
            loadCarreras();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            ListarFuncionariosWindow window = new ListarFuncionariosWindow();
            window.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            // Comparar Digitos verificadores como char
            char dv, dv1;

            try
            {
                dv = func.calcula_dvrut(Int32.Parse(txtBoxRut.Text.ToString()));
                dv1 = Convert.ToChar(txtBoxRutDV.Text.ToString());

                if (!String.IsNullOrEmpty(txtBoxRut.Text) &&
                !String.IsNullOrEmpty(txtBoxRutDV.Text) &&
                !String.IsNullOrEmpty(txtBoxNombre.Text) &&
                !String.IsNullOrEmpty(txtBoxApPaterno.Text) &&
                !String.IsNullOrEmpty(txtBoxApMaterno.Text) &&
                !String.IsNullOrEmpty(comboCarrera.Text) &&
                dv == dv1
                )
                {
                    Funcionario func1 = new Funcionario(Int32.Parse(txtBoxRut.Text.ToString()), txtBoxRutDV.Text.ToString(),
                        txtBoxNombre.Text.ToString(), txtBoxApPaterno.Text.ToString(),
                        txtBoxApMaterno.Text.ToString(), comboCarrera.Text.ToString());

                    //he.modificarFuncionario(func1);
                    he.modificarFuncionario(func1);

                    FuncionariosWindow window = new FuncionariosWindow();
                    window.Show();
                    this.Close();

                    MessageBox.Show("Funcionario actualizado correctamente");

                }
                else
                {
                    // Rut
                    if (txtBoxRut.Text.Trim().Length == 0)
                    {
                        imageError1.Visibility = Visibility.Visible;
                        txtError1.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        imageError1.Visibility = Visibility.Hidden;
                        txtError1.Visibility = Visibility.Hidden;
                    }

                    // RutDV
                    if (txtBoxRutDV.Text.Trim().Length == 0)
                    {
                        imageError1.Visibility = Visibility.Visible;
                        txtError1.Visibility = Visibility.Visible;
                        txtError1.Text = "Digito Verificador Requerido";
                    }
                    else
                    {
                        imageError1.Visibility = Visibility.Hidden;
                        txtError1.Visibility = Visibility.Hidden;
                    }

                    if (dv != dv1)
                    {
                        imageError1.Visibility = Visibility.Visible;
                        txtError1.Visibility = Visibility.Visible;
                        txtError1.Text = "Digito Verificador Incorrecto";
                    }


                    // Nombre
                    if (txtBoxNombre.Text.Trim().Length == 0)
                    {
                        imageError2.Visibility = Visibility.Visible;
                        txtError2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        imageError2.Visibility = Visibility.Hidden;
                        txtError2.Visibility = Visibility.Hidden;
                    }

                    // Apellido Paterno
                    if (txtBoxApPaterno.Text.Trim().Length == 0)
                    {
                        imageError3.Visibility = Visibility.Visible;
                        txtError3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        imageError3.Visibility = Visibility.Hidden;
                        txtError3.Visibility = Visibility.Hidden;
                    }

                    // Apellido Materno
                    if (txtBoxApMaterno.Text.Trim().Length == 0)
                    {
                        imageError4.Visibility = Visibility.Visible;
                        txtError4.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        imageError4.Visibility = Visibility.Hidden;
                        txtError4.Visibility = Visibility.Hidden;
                    }

                    // Carrera

                    if (String.IsNullOrEmpty(comboCarrera.Text))
                    {
                        imageError5.Visibility = Visibility.Visible;
                        txtError5.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        imageError5.Visibility = Visibility.Hidden;
                        txtError5.Visibility = Visibility.Hidden;
                    }
                }
            }
            catch (FormatException e1)
            {
                MessageBox.Show("Debe ingresar Digito Verficador de RUT");
                String e2 = e1.ToString();
            }
        }

        private void txtBoxRut_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Form Validation

            // Rut
            if (txtBoxRut.Text.Trim().Length == 0)
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

        private void txtBoxNombre_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Nombre
            if (txtBoxNombre.Text.Trim().Length == 0)
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

        private void txtBoxApPaterno_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Apellido Paterno
            if (txtBoxApPaterno.Text.Trim().Length == 0)
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

        private void txtBoxApMaterno_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Apellido Materno
            if (txtBoxApMaterno.Text.Trim().Length == 0)
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

        private void txtBoxRut_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxRutDV_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Rut
            if (txtBoxRut.Text.Trim().Length == 0)
            {
                imageError1.Visibility = Visibility.Visible;
                txtError1.Visibility = Visibility.Visible;
                txtError1.Text = "Digito Verificador Requerido";
            }
            else
            {
                imageError1.Visibility = Visibility.Hidden;
                txtError1.Visibility = Visibility.Hidden;
            }
        }

        private void txtBoxRutDV_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            //if (!char.IsDigit(e.Text, e.Text.Length - 1))
            if (System.Text.RegularExpressions.Regex.IsMatch(e.Text, @"[^0-9^+^K^k]"))
            {
                e.Handled = true;
            }
        }

        private void comboCarrera_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            // Carrera
            if (comboCarrera.Text.Trim().Length == 0)
            {
                imageError5.Visibility = Visibility.Visible;
                txtError5.Visibility = Visibility.Visible;
            }
            else
            {
                imageError5.Visibility = Visibility.Hidden;
                txtError5.Visibility = Visibility.Hidden;
            }
        }

        private void comboCarrera_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Carrera
            if (comboCarrera.Text.Trim().Length == 0)
            {
                imageError5.Visibility = Visibility.Visible;
                txtError5.Visibility = Visibility.Visible;
            }
            else
            {
                imageError5.Visibility = Visibility.Hidden;
                txtError5.Visibility = Visibility.Hidden;
            }
        }

        private void txtBoxNombre_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxApPaterno_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxApMaterno_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void loadCarreras()
        {
            // Elementos Combobox comboCarrera
            ComboBoxItem cboxitem1 = new ComboBoxItem();
            cboxitem1.Content = "Ingenieria Civil";
            comboCarrera.Items.Add(cboxitem1);

            ComboBoxItem cboxitem2 = new ComboBoxItem();
            cboxitem2.Content = "Ingenieria Civil Ambiental";
            comboCarrera.Items.Add(cboxitem2);

            ComboBoxItem cboxitem3 = new ComboBoxItem();
            cboxitem3.Content = "Ingenieria Civil Electrica";
            comboCarrera.Items.Add(cboxitem3);

            ComboBoxItem cboxitem4 = new ComboBoxItem();
            cboxitem4.Content = "Ingenieria Civil Electronica";
            comboCarrera.Items.Add(cboxitem4);

            ComboBoxItem cboxitem5 = new ComboBoxItem();
            cboxitem5.Content = "Ingenieria Civil Industrial";
            comboCarrera.Items.Add(cboxitem5);

            ComboBoxItem cboxitem6 = new ComboBoxItem();
            cboxitem6.Content = "Ingenieria Civil Informatica";
            comboCarrera.Items.Add(cboxitem6);

            ComboBoxItem cboxitem7 = new ComboBoxItem();
            cboxitem7.Content = "Ingenieria Civil Matematica";
            comboCarrera.Items.Add(cboxitem7);

            ComboBoxItem cboxitem8 = new ComboBoxItem();
            cboxitem8.Content = "Ingenieria Civil Mecanica";
            comboCarrera.Items.Add(cboxitem8);

            ComboBoxItem cboxitem9 = new ComboBoxItem();
            cboxitem9.Content = "Ingenieria Civil Metalurgica";
            comboCarrera.Items.Add(cboxitem9);

            ComboBoxItem cboxitem10 = new ComboBoxItem();
            cboxitem10.Content = "Ingenieria Civil Quimica";
            comboCarrera.Items.Add(cboxitem10);

            ComboBoxItem cboxitem11 = new ComboBoxItem();
            cboxitem11.Content = "Ingenieria Civil Telematica";
            comboCarrera.Items.Add(cboxitem11);

            ComboBoxItem cboxitem12 = new ComboBoxItem();
            cboxitem12.Content = "Arquitectura";
            comboCarrera.Items.Add(cboxitem12);

            ComboBoxItem cboxitem13 = new ComboBoxItem();
            cboxitem13.Content = "Construccion Civil";
            comboCarrera.Items.Add(cboxitem13);

            ComboBoxItem cboxitem14 = new ComboBoxItem();
            cboxitem14.Content = "Ingenieria Comercial";
            comboCarrera.Items.Add(cboxitem14);

            ComboBoxItem cboxitem15 = new ComboBoxItem();
            cboxitem15.Content = "Ingenieria en Diseño de Productos";
            comboCarrera.Items.Add(cboxitem15);

            ComboBoxItem cboxitem16 = new ComboBoxItem();
            cboxitem16.Content = "Licenciatura en Fisica";
            comboCarrera.Items.Add(cboxitem16);

            ComboBoxItem cboxitem17 = new ComboBoxItem();
            cboxitem17.Content = "Licenciatura en Quimica";
            comboCarrera.Items.Add(cboxitem17);

            ComboBoxItem cboxitem18 = new ComboBoxItem();
            cboxitem18.Content = "Licenciatura en Matematicas";
            comboCarrera.Items.Add(cboxitem18);

            ComboBoxItem cboxitem19 = new ComboBoxItem();
            cboxitem19.Content = "Ingenieria Civil Plan Comun";
            comboCarrera.Items.Add(cboxitem19);

            ComboBoxItem cboxitem20 = new ComboBoxItem();
            cboxitem20.Content = "Ingenieria Electrica";
            comboCarrera.Items.Add(cboxitem20);

            ComboBoxItem cboxitem21 = new ComboBoxItem();
            cboxitem21.Content = "Ingenieria Informatica";
            comboCarrera.Items.Add(cboxitem21);

            ComboBoxItem cboxitem22 = new ComboBoxItem();
            cboxitem22.Content = "Ingenieria Mecanica Industrial";
            comboCarrera.Items.Add(cboxitem22);

            ComboBoxItem cboxitem23 = new ComboBoxItem();
            cboxitem23.Content = "Quimico";
            comboCarrera.Items.Add(cboxitem23);

            ComboBoxItem cboxitem24 = new ComboBoxItem();
            cboxitem24.Content = "Ingenieria de Ejecucion Electronica";
            comboCarrera.Items.Add(cboxitem24);

            ComboBoxItem cboxitem25 = new ComboBoxItem();
            cboxitem25.Content = "Ingenieria de Ejecucion Informatica";
            comboCarrera.Items.Add(cboxitem25);
        }
    }
}
