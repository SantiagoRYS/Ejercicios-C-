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

namespace WpfAppAgencia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Auto> Compacto;
        List<Auto> Lujo;
        List<Auto> Vagoneta;
        List<Camioneta> Camioneta;

        public MainWindow()
        {
            InitializeComponent();
            Compacto = new List<Auto>();
            Lujo = new List<Auto>();
            Vagoneta = new List<Auto>();
            Camioneta = new List<Camioneta>();
        }

        private void RbtAutoCompacto_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtAutoCompacto.IsChecked == true)
            {
                TxbCarga.IsEnabled = false;
                LblCarga.IsEnabled = false;
                TxbPajaseros.IsEnabled = true;
                LblPasajeros.IsEnabled = true;
            }
        }

        private void RbtAutoDeLujo_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtAutoDeLujo.IsChecked == true)
            {
                TxbCarga.IsEnabled = false;
                LblCarga.IsEnabled = false;
                TxbPajaseros.IsEnabled = true;
                LblPasajeros.IsEnabled = true;
            }
        }

        private void RbtVagoneta_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtVagoneta.IsChecked == true)
            {
                TxbCarga.IsEnabled = false;
                LblCarga.IsEnabled = false;
                TxbPajaseros.IsEnabled = true;
                LblPasajeros.IsEnabled = true;
            }
        }

        private void RbtCamioneta_Checked(object sender, RoutedEventArgs e)
        {
            if (RbtCamioneta.IsChecked == true)
            {
                TxbCarga.IsEnabled = true;
                LblCarga.IsEnabled = true;
                TxbPajaseros.IsEnabled = false;
                LblPasajeros.IsEnabled = false;
            }
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RbtAutoCompacto.IsChecked == false && RbtAutoDeLujo.IsChecked == false && RbtCamioneta.IsChecked == false && RbtVagoneta.IsChecked == false)
                {
                    MessageBox.Show("Por favor seleccione el tipo de Vehiculo");
                }
                else if (RbtAutoCompacto.IsChecked == true)
                {
                    Auto compacto = new Auto();
                    compacto.NumSerie = TxbNumero.Text;
                    compacto.Marca = (TxbMarca.Text);
                    compacto.Año = Convert.ToInt32(TxbAño.Text);
                    compacto.Precio = Convert.ToInt32(TxbPrecio.Text);
                    compacto.CantPasajeros = Convert.ToInt32(TxbPajaseros.Text);

                    Compacto.Add(compacto);

                }
                else if (RbtAutoDeLujo.IsChecked == true)
                {
                    Auto lujo = new Auto();
                    lujo.NumSerie = TxbNumero.Text;
                    lujo.Marca = (TxbMarca.Text);
                    lujo.Año = Convert.ToInt32(TxbAño.Text);
                    lujo.Precio = Convert.ToInt32(TxbPrecio.Text);
                    lujo.CantPasajeros = Convert.ToInt32(TxbPajaseros.Text);

                    Lujo.Add(lujo);

                }
                else if (RbtVagoneta.IsChecked == true)
                {
                    Auto vagoneta = new Auto();
                    vagoneta.NumSerie = TxbNumero.Text;
                    vagoneta.Marca = (TxbMarca.Text);
                    vagoneta.Año = Convert.ToInt32(TxbAño.Text);
                    vagoneta.Precio = Convert.ToInt32(TxbPrecio.Text);
                    vagoneta.CantPasajeros = Convert.ToInt32(TxbPajaseros.Text);

                    Vagoneta.Add(vagoneta);

                }
                else if (RbtCamioneta.IsChecked == true)
                {
                    Camioneta camioneta = new Camioneta();
                    camioneta.NumSerie = TxbNumero.Text;
                    camioneta.Marca = (TxbMarca.Text);
                    camioneta.Año = Convert.ToInt32(TxbAño.Text);
                    camioneta.Precio = Convert.ToInt32(TxbPrecio.Text);
                    camioneta.CapacidadCarga = Convert.ToInt32(TxbCarga.Text);

                    Camioneta.Add(camioneta);

                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores validos para cada campo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            foreach (var textBox in new[] { TxbNumero, TxbMarca, TxbAño, TxbPrecio, TxbPajaseros, TxbCarga })
            {
                textBox.Text = "";
            }

        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (RbtAutoCompacto.IsChecked == true)
            {
                foreach (var compacto in Compacto)
                {
                    sb.AppendLine($"AUTOS COMPACTOS \n Num_serie: {compacto.NumSerie}, marca: {compacto.Marca}, año: {compacto.Año}, precio: {compacto.Precio}, Cant_pasajeros: {compacto.CantPasajeros}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtAutoDeLujo.IsChecked == true)
            {
                foreach (var lujo in Lujo)
                {
                    sb.AppendLine($"AUTOS DE LUJO \n Num_serie: {lujo.NumSerie}, marca: {lujo.Marca}, año: {lujo.Año}, precio: {lujo.Precio}, Cant_pasajeros: {lujo.CantPasajeros}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtVagoneta.IsChecked == true)
            {
                foreach (var vagoneta in Vagoneta)
                {
                    sb.AppendLine($"VAGONETAS \n Num_serie: {vagoneta.NumSerie}, marca: {vagoneta.Marca}, año: {vagoneta.Año}, precio: {vagoneta.Precio}, Cant_pasajeros: {vagoneta.CantPasajeros}");
                }
                MessageBox.Show($"{sb}");
            }
            else if (RbtCamioneta.IsChecked == true)
            {
                foreach (var camioneta in Camioneta)
                {
                    sb.AppendLine($"CAMIONETAS \n Num_serie: {camioneta.NumSerie}, marca: {camioneta.Marca}, año: {camioneta.Año}, precio: {camioneta.Precio}, Cap_Carga: {camioneta.CapacidadCarga}");
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