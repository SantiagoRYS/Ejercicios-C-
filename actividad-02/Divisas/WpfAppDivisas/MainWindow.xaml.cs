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

namespace WpfAppDivisas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CambioDivisas cambio;
        public MainWindow()
        {
            InitializeComponent();
            cambio = new CambioDivisas(3855.16);
        }

        private void BtnCambiar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cambio.Pesos = Convert.ToInt32(TxbPesos.Text);
                cambio.TipoCambio = Convert.ToInt32(TxbCambio.Text);

                LblPesos.Content = $"Pesos: {cambio.Pesos}";
                LblDolares.Content = $"dolares: {cambio.ConvertirADolares()}";
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