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

namespace WpfAppJugadores
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Portero> Portero;
        List<JugadorCampo> Defensa;
        List<JugadorCampo> Medio;
        List<JugadorCampo> Delantero;
        public MainWindow()
        {
            InitializeComponent();
            Portero = new List<Portero>();
            Defensa = new List<JugadorCampo>();
            Medio = new List<JugadorCampo>();
            Delantero = new List<JugadorCampo>();
        }

        private void RbtPortero_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtPortero.IsChecked == true)
            {
                TxbGoles.IsEnabled = false;
                LblGoles.IsEnabled = false;
            }
        }

        private void RbtDefensa_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtDefensa.IsChecked == true)
            {
                TxbGoles.IsEnabled = true;
                LblGoles.IsEnabled = true;
            }
        }

        private void RbtMedio_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtMedio.IsChecked == true)
            {
                TxbGoles.IsEnabled = true;
                LblGoles.IsEnabled = true;
            }
        }

        private void RbtDelantero_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtDelantero.IsChecked == true)
            {
                TxbGoles.IsEnabled = true;
                LblGoles.IsEnabled = true;
            }
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RbtPortero.IsChecked == false && RbtDefensa.IsChecked == false && RbtMedio.IsChecked == false && RbtDelantero.IsChecked == false)
                {
                    MessageBox.Show("Por favor seleccione la posición del jugador");
                }
                else if (RbtPortero.IsChecked == true)
                {
                    Portero portero = new Portero();
                    portero.NumPortero = Convert.ToInt32(TxbNumero.Text);
                    portero.Nombre = TxbNombre.Text;
                    portero.MinJugados = Convert.ToInt32(TxbMinutos.Text);

                    Portero.Add(portero);

                }
                else if (RbtDefensa.IsChecked == true)
                {
                    JugadorCampo defensa = new JugadorCampo();
                    defensa.NumJugador = Convert.ToInt32(TxbNumero.Text);
                    defensa.Nombre = TxbNombre.Text;
                    defensa.MinJugados = Convert.ToInt32(TxbMinutos.Text);
                    defensa.Goles = Convert.ToInt32(TxbGoles.Text);

                    Defensa.Add(defensa);

                }
                else if (RbtMedio.IsChecked == true)
                {
                    JugadorCampo medio = new JugadorCampo();
                    medio.NumJugador = Convert.ToInt32(TxbNumero.Text);
                    medio.Nombre = TxbNombre.Text;
                    medio.MinJugados = Convert.ToInt32(TxbMinutos.Text);
                    medio.Goles = Convert.ToInt32(TxbGoles.Text);

                    Medio.Add(medio);

                }
                else if (RbtDelantero.IsChecked == true)
                {
                    JugadorCampo delantero = new JugadorCampo();
                    delantero.NumJugador = Convert.ToInt32(TxbNumero.Text);
                    delantero.Nombre = TxbNombre.Text;
                    delantero.MinJugados = Convert.ToInt32(TxbMinutos.Text);
                    delantero.Goles = Convert.ToInt32(TxbGoles.Text);

                    Delantero.Add(delantero);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show(aoore.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            foreach (var textBox in new[] { TxbNumero, TxbGoles, TxbMinutos, TxbNombre})
            {
                textBox.Text = "";
            }
        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (RbtPortero.IsChecked == true)
            {
                foreach (var portero in Portero)
                {
                    sb.AppendLine($"PORTERO: \n Núm. portero: {portero.NumPortero}, nombre: {portero.Nombre}, min. jugados: {portero.MinJugados}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtDefensa.IsChecked == true)
            {
                foreach (var defensa in Defensa)
                {
                    sb.AppendLine($"DEFENSA \n Núm. jugador: {defensa.NumJugador}, nombre: {defensa.Nombre}, min. jugados: {defensa.MinJugados}, {defensa.Goles}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtMedio.IsChecked == true)
            {
                foreach (var medio in Medio)
                {
                    sb.AppendLine($"MEDIO CAMPISTA \n Núm. jugador: {medio.NumJugador}, nombre: {medio.Nombre}, min. jugados: {medio.MinJugados}, {medio.Goles}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtDelantero.IsChecked == true)
            {
                foreach (var delantero in Delantero)
                {
                    sb.AppendLine($"DELANTERO \n Núm. jugador: {delantero.NumJugador}, nombre: {delantero.Nombre}, min. jugados: {delantero.MinJugados}, {delantero.Goles}");
                }
                MessageBox.Show($"{sb}");
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}