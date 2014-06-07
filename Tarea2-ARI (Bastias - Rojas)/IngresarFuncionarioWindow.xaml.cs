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
    /// Lógica de interacción para IngresarFuncionarioWindow.xaml
    /// </summary>
    public partial class IngresarFuncionarioWindow : Window
    {
        public IngresarFuncionarioWindow()
        {
            InitializeComponent();

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

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            FuncionariosWindow window = new FuncionariosWindow();
            window.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
