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

namespace WpfAppRestaurante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Restaurante mesa;
        public MainWindow()
        {
            InitializeComponent();

            mesa = new Restaurante();

        }

        private void BtnTotal_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                mesa.HamburguesaS = Convert.ToInt32(TxbHamburguesaS.Text);
                mesa.HamburguesaQ = Convert.ToInt32(TxbHamburguesaQ.Text);
                mesa.HamburguesaE = Convert.ToInt32(TxbHamburguesaE.Text);
                mesa.PapasFritas = Convert.ToInt32(TxbPapasFritas.Text);
                mesa.Refresco = Convert.ToInt32(TxbRefresco.Text);
                mesa.Postre = Convert.ToInt32(TxbPostre.Text);
                LblTotal.Content = $"{mesa.CalcularTotal()}";

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
    }
}