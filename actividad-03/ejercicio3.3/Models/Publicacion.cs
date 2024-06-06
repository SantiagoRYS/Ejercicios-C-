using BLL;
using System.ComponentModel.Design;

namespace Models
{
    public abstract class Publicacion
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

        public static int CalcularTotalLibros(List<Libro> Libros)
        {
            int totalLibro = 0;
            foreach (var libro in Libros)
            {
                totalLibro += libro.precio;
            }

            return totalLibro;

        }

        public static int CalcularTotalDiscos(List<CD> Discos)
        {
            int totalDisco = 0;
            foreach (var disco in Discos)
            {
                totalDisco += disco.precio;
            }

            return totalDisco;

        }
        public static int CalcularTotal(List<Libro> Libros, List<CD> Discos)
        {
            int total = 0;
            int totalDisco = 0;
            int totalLibro = 0;
            foreach (var libro in Libros)
            {
                totalLibro += libro.precio;
            }

            foreach (var disco in Discos)
            {
                totalDisco += disco.precio;
            }

            return total=(totalDisco + totalLibro);

        }
    }
}
