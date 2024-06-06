using BLL;

namespace Models
{
    public class Publicacion
    {
		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		private int precio;

		public int Precio
		{
			get { return precio; }
			set { Validacion.ValidarPrecio(value); precio = value; }
		}
    }
}
