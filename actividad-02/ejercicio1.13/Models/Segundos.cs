using BLL;

namespace Models
{
    public class Segundos
    {
		private int dia;

		public int Dia
		{
			get { return dia; }
			set { Validacion.ValidarDia(value); dia = value; }
		}

		public int CalcularSegundos()
		{
			return dia * 86400;
		}

	}
}
