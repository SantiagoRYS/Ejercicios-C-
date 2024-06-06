namespace BLL
{
    public class Validacion
    {
        public static void ValidarNumeroJ(int nj)
        {
            if (nj < 1 || nj >25)
            {
                throw new ArgumentOutOfRangeException("El numero dorsal de un jugador de campo no puede ser menor a 1 ni mayor a 25 ");
            }
        }

        public static void ValidarNumeroP(int np)
        {
            if (np < 1 || np > 99)
            {
                throw new ArgumentOutOfRangeException("El numero dorsal de un portero no puede ser menor a 1 ni mayor a 99 ");
            }
        }

        public static void ValidarMinutos(int m)
        {
            if (m < 0 || m > 120)
            {
                throw new ArgumentOutOfRangeException("El jugador no puede jugar mas de 120 minutos o menos de 0 minutos");
            }
        }

        public static void ValidarGoles(int g)
        {
            if (g < 0 || g > 50)
            {
                throw new ArgumentOutOfRangeException("El numero de goles no puede ser menor a 0 ni mayor a 50");
            }
        }

    }
}
