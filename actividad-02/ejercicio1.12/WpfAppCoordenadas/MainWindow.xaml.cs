using Models;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCoordenadas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coordenadas punto1;
        Coordenadas punto2;
        public MainWindow()
        {
            InitializeComponent();

            punto1 = new Coordenadas();
            punto2 = new Coordenadas();

            BtnCalcular.IsEnabled = false;

        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (RbtPunto1.IsChecked == false && RbtPunto2.IsChecked == false)
                {
                    MessageBox.Show($"Debe seleccionar un punto para capturar las coordenadas");
                    TxbX.Text = string.Empty;
                    TxbY.Text = string.Empty;
                }
                else if (RbtPunto1.IsChecked == true)
                {
                    punto1.X1 = Convert.ToDouble(TxbX.Text);
                    punto1.Y1 = Convert.ToDouble(TxbY.Text);
                    MessageBox.Show($"Las coordenadas del punto 1 han sido registradas");
                    LblPunto1.Content = $"{punto1.X1}, {punto1.Y1}";
                    TxbX.Text = string.Empty;
                    TxbY.Text = string.Empty;
                }
                else if (RbtPunto2.IsChecked == true)
                {
                    punto2.X2 = Convert.ToDouble(TxbX.Text);
                    punto2.Y2 = Convert.ToDouble(TxbY.Text);
                    MessageBox.Show($"Las coordenadas del punto 1 han sido registradas");
                    LblPunto2.Content = $"{punto2.X2}, {punto2.Y2}";
                    TxbX.Text = string.Empty;
                    TxbY.Text = string.Empty;
                }
                LblTotal.Content = $"";
                BtnCalcular.IsEnabled = punto1.X1 != 0 && punto1.Y1 != 0 && punto2.X2 != 0 && punto2.Y2 != 0;

            }

            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxbX.Text = string.Empty;
                TxbY.Text = string.Empty;
            }
        }

        private void TxbX_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*(\\.[0-9]*)?$");
            e.Handled = !regex.IsMatch(TxbX.Text + e.Text);

        }

        private void TxbY_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*(\\.[0-9]*)?$");
            e.Handled = !regex.IsMatch(TxbY.Text + e.Text);

        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double distancia = punto1.CalcularDistancia(punto1.X1, punto1.Y1, punto2.X2, punto2.Y2);
            LblTotal.Content = distancia.ToString();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}