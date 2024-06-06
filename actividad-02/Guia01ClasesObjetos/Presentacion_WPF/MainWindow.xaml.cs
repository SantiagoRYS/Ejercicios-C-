using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Circunferencia rueda;
        Circunferencia moneda;
        public MainWindow()
        {
            InitializeComponent();
            rueda = new Circunferencia();
            rueda.ModificarRadio(10.2);
            moneda = new Circunferencia();
            moneda.ModificarRadio(1.4);
            
        }

        private void BtnCapturarRadio_Click(object sender, RoutedEventArgs e)
        {
            if (RbtRueda.IsChecked == false && RbtMoneda.IsChecked == false) 
            {
                LblResultado.Content = $"Debe seleccionar un objeto";
            }
            else if (RbtRueda.IsChecked == true)
            {
                rueda.ModificarRadio(Convert.ToDouble(TxbRadio.Text));
                MessageBox.Show($"El radio de la rueda ha sido captuado: {rueda.ConsultarRadio()}");
                LblResultado.Content = string.Empty ;
            }
            else if (RbtMoneda.IsChecked == true)
            {
                moneda.ModificarRadio(Convert.ToDouble(TxbRadio.Text));
                MessageBox.Show($"El radio de la rmoneda ha sido captuado: {moneda.ConsultarRadio()}");
                LblResultado.Content = string.Empty;
            }
            BtnCalcularArea.IsEnabled = true;
            BtnCalcularPerimetro.IsEnabled = true;
        }

        private void TxbRadio_PreviewTextInput (object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*(\\.[0-9]*)?$");
            e.Handled = !regex.IsMatch(TxbRadio.Text + e.Text);

        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            if (RbtRueda.IsChecked == true)
            {
               double areaRueda = rueda.CalcularArea(); 
                //MessageBox.Show
                LblResultado.Content = $"El area de la Rueda es: {areaRueda.ToString()}";
            }
            else if (RbtMoneda.IsChecked == true)
            {
                double areaMoneda = moneda.CalcularArea();
                LblResultado.Content = $"El area de la Moneda es: {areaMoneda.ToString()}";
            }

        }

        private void BtnCalcularPerimetro_Click(object sender, RoutedEventArgs e)
        {
            if (RbtRueda.IsChecked == true)
            {
                double perimetroRueda = rueda.CalcularPerimetro();
                //MessageBox.Show
                LblResultado.Content = $"El perimetro de la Rueda es: {perimetroRueda.ToString()}";
            }
            else if (RbtMoneda.IsChecked == true)
            {
                double perimetroMoneda = moneda.CalcularPerimetro();
                LblResultado.Content = $"El perimetro de la Moneda es: {perimetroMoneda.ToString()}";
            }

        }

        private void TxbRadio_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.V && Keyboard.Modifiers == ModifierKeys.Control)
            {
                e.Handled = true;
            }
            else if (e.Key == Key.Insert && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                e.Handled = true;
            }
        }

        private void TxbRadio_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.CancelCommand();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
