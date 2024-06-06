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

namespace WpfAppNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entero entero;
        public MainWindow()
        {
            InitializeComponent();
            entero = new Entero();
        }

        private void BtnValidar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                entero.Numero = Convert.ToInt32(TxtNumero.Text);
                if (entero.ValidarPrimo() == false)
                {
                    MessageBox.Show($"El numero {entero.Numero} no es un numero Primo");
                    TxtNumero.Text = null;
                }
                else
                {
                    MessageBox.Show($"El numero {entero.Numero} es un numero Primo");
                    TxtNumero.Text = null;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtNumero.Text = null;
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