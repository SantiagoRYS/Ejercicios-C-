namespace BLL
{
    public class Validacion
    {
        public static void ValidarPrecio(int p)
        {
            if (p <= 0)
            {
                throw new ArgumentException("El precio no puede ser menor de $1");
            }
        }

        public static void ValidarNumeroPaginas(int np)
        {
            if (np <= 0)
            {
                throw new ArgumentException("La cantidad de paginas no puede ser menor de 1");
            }
        }

        public static void ValidarDuracion(double d)
        {
            if (d < 1)
            {
                throw new ArgumentException("La duracion del audio no puede ser menor de 1 minuto");
            }
        }

    }
}
