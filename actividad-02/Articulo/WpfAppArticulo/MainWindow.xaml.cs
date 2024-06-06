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

namespace WpfAppArticulo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Articulo articulo;
        public MainWindow()
        {
            InitializeComponent();
            articulo = new Articulo(123, "computador", 1999999.999, 1);
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                articulo.Clave = Convert.ToInt16(TxbClave.Text);
                articulo.Descripcion = Convert.ToString(TxbDescripcion.Text);
                articulo.Precio = Convert.ToDouble(TxbPrecio.Text);
                articulo.Cantidad = Convert.ToInt16(TxbCantidad.Text);
                LblClave.Content = $"la clave del articulo es: {articulo.Clave}";
                LblDescripcion.Content = $"Nombre del articulo: {articulo.Descripcion}";
                LblPrecio.Content = $"Precio del articulo: {articulo.Precio}";
                LblCantidad.Content = $"cantidad: {articulo.Cantidad}";
                LblIva.Content = $"IVA por unidad: {articulo.CalcularIva()}";

                TxtClave.text = string.Empty ;
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
    }
}