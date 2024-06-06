using Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InterfaceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Empleado> Empleados;
        public MainWindow()
        {
            InitializeComponent();
            Empleados = new List<Empleado>();
            DataGridEmpleados.ItemsSource = Empleados;
        }

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado()
                {
                    Numero = Convert.ToInt32(TxbNumero.Text),
                    Nombre = TxbNombre.Text,
                    Sueldo = Convert.ToDouble(TxbSueldo.Text),

                };
                TxbNumero.Text = string.Empty;
                TxbNombre.Text = string.Empty;
                TxbSueldo.Text = string.Empty;

                Empleados.Add(empleado);
                DataGridEmpleados.Items.Refresh();

                double Nomina = 0;
                foreach (var emple in Empleados)
                {
                    Nomina += emple.Sueldo;
                    LblNomina.Content = $"{Nomina}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

       
        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}