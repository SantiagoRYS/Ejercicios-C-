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

namespace WpfAppauto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Auto Camioneta;
        public MainWindow()
        {
            InitializeComponent();
            Camioneta = new Auto();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Camioneta.Costo = Convert.ToInt32(TxbCosto.Text);
                Camioneta.ManoObra = 0.12;
                Camioneta.Impuesto = 0.06;
                LblTotal.Content = $"el costo final del vehiculo es de: {Camioneta.CalcularTotal()}";
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