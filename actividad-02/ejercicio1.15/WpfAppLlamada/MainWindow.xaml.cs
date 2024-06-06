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

namespace WpfAppLlamada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Llamada telefono;
        public MainWindow()
        {
            InitializeComponent();
            telefono = new Llamada();
        }

        private void BtnVerCosto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LblCosto.Content = $"";
                telefono.Duracion = Convert.ToInt32(TxtDuracion.Text);
                LblCosto.Content = $"Costo: ${telefono.CalcularCosto()}";
                TxtDuracion.Text = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtDuracion.Text = null;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtDuracion.Text = null;
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}