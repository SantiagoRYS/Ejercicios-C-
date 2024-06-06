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

		private int minJugados;

		public int MinJugados
		{
			get { return minJugados; }
			set { Validacion.ValidarMinutos(value); minJugados = value; }
		}

	}
}
