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

namespace WpfAppDia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Segundos tiempo;
        public MainWindow()
        {
            InitializeComponent();
            tiempo = new Segundos();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                tiempo.Dia = Convert.ToInt32(TxbDias.Text);
                LblSegundos.Content = $"Dias: {tiempo.Dia} \t Segundos: {tiempo.CalcularSegundos()}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxbDias.Text = $"" ;
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