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

namespace WpfAppPublicacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Libro>Libros;
        private List<CD> Discos;
        public MainWindow()
        {
            InitializeComponent();

            Discos = new List<CD>();
            Libros = new List<Libro>();
            DataGridDiscos.ItemsSource = Discos;
            DataGridLibros.ItemsSource = Libros;
        }

        private void RbtImpreso_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtImpreso.IsChecked == true)
            {
                TxtDuracion.IsEnabled = false;
                LblD.IsEnabled = false;
                TxtNumeroPaginas.IsEnabled = true;
                LblN.IsEnabled = true;
            }
        }

        private void RbtAudio_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtAudio.IsChecked == true)
            {
                TxtNumeroPaginas.IsEnabled = false;
                LblN.IsEnabled = false;
                TxtDuracion.IsEnabled = true;
                LblD.IsEnabled = true;
            }
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RbtAudio.IsChecked == false && RbtImpreso.IsChecked == false)
                {
                    MessageBox.Show("Por favor seleccione el tipo de publicacion");
                }
                else if (RbtAudio.IsChecked == true)
                {
                    CD disco = new CD();
                    disco.Titulo = txtTitulo.Text;
                    disco.Precio = Convert.ToInt32(TxtPrecio.Text);
                    disco.Duracion = Convert.ToInt32(TxtDuracion.Text);

                    Discos.Add(disco);
                    DataGridDiscos.ItemsSource = Discos;
                    DataGridDiscos.Items.Refresh();
                    ActualizarTotales();
                }
                else if (RbtImpreso.IsChecked == true)
                {
                    Libro libro = new Libro();
                    libro.Titulo = txtTitulo.Text;
                    libro.Precio = Convert.ToInt32(TxtPrecio.Text);
                    libro.NumeroPaginas = Convert.ToInt32(TxtNumeroPaginas.Text);

                    Libros.Add(libro);
                    DataGridLibros.ItemsSource = Libros;
                    DataGridLibros.Items.Refresh();
                    ActualizarTotales();
                }
                txtTitulo.Text = string.Empty;
                TxtPrecio.Text = string.Empty;
                TxtNumeroPaginas.Text = string.Empty;
                TxtDuracion.Text = string.Empty;
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

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if(RbtImpreso.IsChecked == true)
            {
                foreach (var libro in Libros)
                {
                    sb.AppendLine($"titulo: {libro.Titulo}, precio: {libro.Precio}, núm. páginas: {libro.NumeroPaginas}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtAudio.IsChecked == true)
            {
                foreach (var disco in Discos)
                {
                    sb.AppendLine($"titulo: {disco.Titulo}, precio: {disco.Precio}, duracion: {disco.Duracion}min");
                }
                MessageBox.Show($"{sb}");
            }
        }

        private void ActualizarTotales()
        {
            int total = Libro.CalcularTotal(Libros, Discos);
            LblTotal.Content = $"${total}";
            int totalDisco = Libro.CalcularTotalDiscos(Discos);
            LblDiscosVendidos.Content = $"${totalDisco}";
            int totalLibro = Libro.CalcularTotalLibros(Libros);
            LblLibrosVendidos.Content = $"${totalLibro}";
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }
    }
}