using BLL;

namespace Moldels
{
    public class Gasolinera
    {
		private double litro;

		public double Litro
		{
			get { return litro; }
			set { litro = value; }
		}


		private int galon;

		public int Galon
		{
			get { return galon; }
			set { Verificacion.Validargalon(value); galon = value; }
		}

        public Gasolinera(int g)
        {
            this.Galon = g;
        }

		public double CalcularGasolina()
		{
			return (3.785 * litro) * galon;
		}

    }
}
