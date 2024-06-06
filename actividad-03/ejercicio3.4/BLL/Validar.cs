namespace BLL
{
    public class Validar
    {
        public static void ValidarAño(int a)
        {
            if (a < 1885 || a > 2024)
            {
                throw new ArgumentException("El año no puede ser anterior a 1885 ni superior a 2024");
            }
        }

        public static void ValidarPrecio(int p)
        {
            if (p <= 0)
            {
                throw new ArgumentException("El precio no puede ser menor a 1");
            }
        }

        public static void ValidarCantiadad(int c)
        {
            if (c <= 0)
            {
                throw new ArgumentException("la capacidad de pasajeros no puede ser menor de 1");
            }
        }

        public static void ValidarCapacidad(int cp)
        {
            if (cp <= 0)
            {
                throw new ArgumentException("El precio no puede ser menor a 1Kg");
            }
        }

    }
}
