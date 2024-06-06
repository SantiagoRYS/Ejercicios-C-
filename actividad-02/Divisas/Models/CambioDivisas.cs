using BLL;

namespace Models
{
    public class CambioDivisas
    {
		private double pesos;

		public double Pesos
		{
			get { return pesos; }
			set { Verificar.ValidarPesos(value); pesos = value; }
		}

		private double tipocambio;

		public double TipoCambio
		{
			get { return tipocambio; }
			set { Verificar.ValidarCambio(value); tipocambio = value; }
		}

        public CambioDivisas(double tc)
        {
            this.TipoCambio = tc;
        }

		public double ConvertirADolares()
		{
			return pesos/tipocambio;
		}

    }
}
