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

namespace WpfAppBeisbol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pitchers> Pitcher;
        List<Posicion> Posicion;
        List<Bateador> Bateador;
        public MainWindow()
        {
            InitializeComponent();
            Pitcher = new List<Pitchers>();
            Posicion = new List<Posicion>();
            Bateador = new List<Bateador>();

        }

        private void RbtPitcher_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtPitcher.IsChecked == true)
            {
                TxbHits.IsEnabled = false;
                LblHits.IsEnabled = false;
                TxbErrores.IsEnabled = true;
                LblErrores.IsEnabled = true;
                TxbPonches.IsEnabled = true;
                LblPonches.IsEnabled = true;
            }
        }

        private void RbtPosicion_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtPosicion.IsChecked == true)
            {
                TxbHits.IsEnabled = true;
                LblHits.IsEnabled = true;
                TxbErrores.IsEnabled = true;
                LblErrores.IsEnabled = true;
                TxbPonches.IsEnabled = false;
                LblPonches.IsEnabled = false;
            }
        }

        private void RbtBateador_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtBateador.IsChecked == true)
            {
                TxbHits.IsEnabled = true;
                LblHits.IsEnabled = true;
                TxbErrores.IsEnabled = false;
                LblErrores.IsEnabled = false;
                TxbPonches.IsEnabled = false;
                LblPonches.IsEnabled = false;
            }
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RbtPitcher.IsChecked == false && RbtPosicion.IsChecked == false && RbtBateador.IsChecked == false)
                {
                    MessageBox.Show("Por favor seleccione la posición del jugador");
                }
                else if (RbtPitcher.IsChecked == true)
                {
                    Pitchers pitcher = new Pitchers();
                    pitcher.NumUniforme = Convert.ToInt32(TxbNumero.Text);
                    pitcher.Nombre = TxbNombre.Text;
                    pitcher.Ponches = Convert.ToInt32(TxbPonches.Text);
                    pitcher.Errores = Convert.ToInt32(TxbErrores.Text);

                    Pitcher.Add(pitcher);

                }
                else if (RbtPosicion.IsChecked == true)
                {
                    Posicion posicion = new Posicion();
                    posicion.NumUniforme = Convert.ToInt32(TxbNumero.Text);
                    posicion.Nombre = TxbNombre.Text;
                    posicion.Hits = Convert.ToInt32(TxbHits.Text);
                    posicion.Errores = Convert.ToInt32(TxbErrores.Text);

                    Posicion.Add(posicion);

                }
                else if (RbtBateador.IsChecked == true)
                {
                    Bateador bateador = new Bateador();
                    bateador.NumUniforme = Convert.ToInt32(TxbNumero.Text);
                    bateador.Nombre = TxbNombre.Text;
                    bateador.Hits = Convert.ToInt32(TxbHits.Text);

                    Bateador.Add(bateador);

                }
                foreach (var textBox in new[] { TxbNumero, TxbErrores, TxbHits, TxbNombre, TxbPonches })
                {
                    textBox.Text = "";
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
        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (RbtPitcher.IsChecked == true)
            {
                foreach (var pitcher in Pitcher)
                {
                    sb.AppendLine($"PITCHER: \n Núm. Uniforme: {pitcher.NumUniforme}, nombre: {pitcher.Nombre}, ponches: {pitcher.Ponches}, errores {pitcher.Errores}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtPosicion.IsChecked == true)
            {
                foreach (var posicion in Posicion)
                {
                    sb.AppendLine($"JUGADOR DE POSICION: \n Núm. Uniforme: {posicion.NumUniforme}, nombre: {posicion.Nombre}, hits: {posicion.Hits}, errores {posicion.Errores}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtBateador.IsChecked == true)
            {
                foreach (var bateador in Bateador)
                {
                    sb.AppendLine($"BATEADOR DESIGNADO: \n Núm. Uniforme: {bateador.NumUniforme}, nombre: {bateador.Nombre}, hits: {bateador.Hits}");
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