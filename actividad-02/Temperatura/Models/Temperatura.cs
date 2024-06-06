using BLL;

namespace Models
{
    public class Temperatura
    {
		private double gradosCentigrados;

		public double GradosCentigrados
		{
			get { return gradosCentigrados; }
			set { Validar.ValidarGrados(value); gradosCentigrados = value; }
		}

		public Temperatura(double gc)
		{
			this.GradosCentigrados = gc;
		}

		public double convertirAFarenheit()
		{
			return (gradosCentigrados*1.8)+32;
		}

	}
}
