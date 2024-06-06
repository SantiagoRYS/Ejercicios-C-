using BLL;

namespace Models
{
    public class Auto
    {
		private double costo;

		public double Costo
		{
			get { return costo; }
			set { Validacion.ValidarCosto(value); costo = value; }
		}

		private double manoObra;

		public double ManoObra
		{
			get { return manoObra; }
			set { manoObra = value; }
		}

		private double impuesto;

		public double Impuesto
		{
			get { return impuesto; }
			set { impuesto = value; }
		}

		public double CalcularTotal()
		{
			return costo + (costo*manoObra)+(costo*impuesto);
		}

	}
}
