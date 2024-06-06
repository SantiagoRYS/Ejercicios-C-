using Moldels;
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

namespace WpfAppGasolinera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gasolinera bomba;
        public MainWindow()
        {
            InitializeComponent();

            bomba = new Gasolinera(1);

        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bomba.Galon = Convert.ToInt32(TxbGalones.Text);
                bomba.Litro = 15445.99;
                LblVenta.Content = $"vendiste {bomba.Galon} galones de gasolina \t total a pagar: {bomba.CalcularGasolina()}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}