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

namespace WpfAppFecha
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Fecha fecha1, fecha2, fecha3;
        public MainWindow()
        {
            InitializeComponent();
            fecha1 = new Fecha();
            fecha2 = new Fecha(10, 12, 2022);
            fecha3 = new Fecha();
        }

        private void BtnCapturar_Click(object sender, RoutedEventArgs e)
        {


            try
            {

                LblPorDefecto.Content = $"la fecha por defecto es : {fecha1.ConsultarFechaConLetra()}";
                LblPorParametros.Content = $"{fecha2.Dia}{"/"}{fecha2.Mes}{"/"}{fecha2.Año}";
                fecha3.ModificarFecha(Convert.ToInt16(TxbDia.Text), Convert.ToInt16(TxbMes.Text), Convert.ToInt16(TxbAño.Text));
                MessageBox.Show("texto de prueba");
                LblFecha.Content = $"{fecha3.Dia}{"/"}{fecha3.Mes}{"/"}{fecha3.Año}";


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