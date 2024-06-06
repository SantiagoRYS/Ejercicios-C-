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

namespace WpfAppTemperatura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Temperatura grados;
        public MainWindow()
        {
            InitializeComponent();
            grados = new Temperatura(18);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                grados.GradosCentigrados = Convert.ToDouble(TxtGrados.Text);
                LblCentigrados.Content = $"C°:{grados.GradosCentigrados}";
                LblFarenheit.Content = $"F°: {grados.convertirAFarenheit()}";
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