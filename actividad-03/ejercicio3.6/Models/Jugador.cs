using BLL;

namespace Models
{
    public abstract class Jugador
    {

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int numUniforme;

		public int NumUniforme
		{
			get { return numUniforme; }
			set { Validacion.ValidarNumero(value); numUniforme = value; }
		}


	}
}
