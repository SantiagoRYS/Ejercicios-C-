using Modelos;
using BLL;
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

namespace Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangulo pared;
        Rectangulo ventana;
        public MainWindow()
        {
            InitializeComponent();
            pared = new Rectangulo();
            ventana = new Rectangulo();
 
        }

        private void BtnCapturarLargoAncho_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (RbtPared.IsChecked == false && RbtVentana.IsChecked == false)
                {
                    LblResultado.Content = $"Debe seleccionar un objeto";
                    return;
                }
                else if (RbtPared.IsChecked == true)
                {
                    pared.ModificarLargo(Convert.ToDouble(TxbLargo.Text));
                    pared.ModificarAncho(Convert.ToDouble(TxbAncho.Text));
                    MessageBox.Show($"El largo y ancho de la pared ha sido capturado, Largo: {pared.ConsultarLargo()}m Ancho: {pared.ConsultarAncho()}m ");
                    LblResultado.Content = string.Empty;
                }
                else if (RbtVentana.IsChecked == true)
                {
                    ventana.ModificarLargo(Convert.ToDouble(TxbLargo.Text));
                    ventana.ModificarAncho(Convert.ToDouble(TxbAncho.Text));
                    MessageBox.Show($"El largo y ancho de la ventana ha sido capturado, Largo: {ventana.ConsultarLargo()}m Ancho: {ventana.ConsultarAncho()}m ");
                    LblResultado.Content = string.Empty;
                }
                BtnCalcularArea.IsEnabled = true;
            }
            catch (FormatException )
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el largo y el ancho.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
      
        private void TxbLargo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*(\\,[0-9]*)?$");
            e.Handled = !regex.IsMatch(TxbLargo.Text + e.Text);

        }

        private void TxbAncho_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[0-9]*(\\,[0-9]*)?$");
            e.Handled = !regex.IsMatch(TxbAncho.Text + e.Text);

        }
        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            
            if (RbtPared.IsChecked == true)
            {
                double areaPared = pared.CalcularArea();
                //MessageBox.Show
                LblAreaPared.Content = $"{areaPared.ToString()}";
                
            }
            else if (RbtVentana.IsChecked == true)
            {
                double areaVentana = ventana.CalcularArea();
                LblAreaVentana.Content = $"{areaVentana.ToString()}";
            }
            BtnCalcularDiferencia.IsEnabled = true;
            
        }

        private void BtnCalcularDiferencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (LblAreaPared.Content.ToString() == "0")
                {
                    MessageBox.Show("Debe capturar los datos para la pared antes de calcular la diferencia.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (LblAreaVentana.Content.ToString() == "0")
                {
                    MessageBox.Show("Debe capturar los datos para la ventana antes de calcular la diferencia.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                LblAreaTotal.Content = $"{Validacion.CalcularDiferencia(Convert.ToDouble(LblAreaPared.Content), Convert.ToDouble(LblAreaVentana.Content)).ToString()}";
            }
            catch (ArgumentException ae) 
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            BtnCalcularTiempo.IsEnabled = true;

        }

        private void BtnCalcularTiempo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LblResultado.Content = $"Tardara en total {Validacion.CalcularTiempo(Convert.ToDouble(LblAreaTotal.Content))} Horas pintar toda la pared";
            }
            catch(ArgumentException ae) 
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void TxbLargo_PreviewKeyDown(object sender, KeyEventArgs e)
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
        private void TxbLargo_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.CancelCommand();
        }

        private void TxbAncho_PreviewKeyDown(object sender, KeyEventArgs e)
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
        private void TxbAncho_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            e.CancelCommand();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
    
}

