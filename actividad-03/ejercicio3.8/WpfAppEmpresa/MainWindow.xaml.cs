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

namespace WpfAppEmpresa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Empleado> Empleados; 
        List<Cliente> Clientes;
        public MainWindow()
        {
            InitializeComponent();
            Empleados = new List<Empleado>();
            Clientes = new List<Cliente>();
        }

        private void BtnCapturarC_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = TxbNombreC.Text;
            cliente.Direccion = TxbDireccionC.Text;
            cliente.LimiteCredito = Convert.ToInt32(TxbCredito.Text);

            Clientes.Add(cliente);
        }

        private void BtnMostrarC_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var cliente in Clientes)
            {
                sb.AppendLine($"Cliente:\n Nombre: {cliente.Nombre}, direccion: {cliente.Direccion}, limite de credito: {cliente.LimiteCredito}");
            }
            MessageBox.Show($"{sb}");
        }

        private void BtnCapturarE_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = TxbNombreE.Text;
            empleado.Direccion = TxbDireccionE.Text;
            empleado.Salario = Convert.ToInt32(TxbSalario.Text);

            Empleados.Add(empleado);
        }

        private void BtnMostrarE_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var empleado in Empleados)
            {
                sb.AppendLine($"Cliente:\n Nombre: {empleado.Nombre}, direccion: {empleado.Direccion}, salario: {empleado.Salario}");
            }
            MessageBox.Show($"{sb}");
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}