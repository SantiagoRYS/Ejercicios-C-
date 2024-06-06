using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Models
{
    public class Coordenadas
    {

        public double X1 { get; set; }

        public double Y1 { get; set; }

        public double X2 { get; set; }

        public double Y2 { get; set; }

        public double CalcularDistancia(double x1, double x2, double y1, double y2)
		{

			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

	}
}
