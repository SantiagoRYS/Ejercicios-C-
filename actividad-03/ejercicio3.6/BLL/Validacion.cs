namespace BLL
{
    public class Validacion
    {
        public static void ValidarNumero(int n)
        {
            if (n < 0 || n > 99)
            {
                throw new ArgumentOutOfRangeException("El numero dorsal del jugador no puede ser menor a 0 ni mayor a 99 ");
            }
        }

        public static void ValidarHit(int h)
        {
            if (h < 0 || h > 7)
            {
                throw new ArgumentOutOfRangeException("El numero de hits no puede ser menor a 1 ni mayor a 7 ");
            }
        }

        public static void ValidarPonches(int p)
        {
            if (p < 0 || p > 20)
            {
                throw new ArgumentOutOfRangeException("El numero de ponches no puede ser menor de 0 ni mayor de 20");
            }
        }

        public static void ValidarErrores(int e)
        {
            if (e < 0 || e > 20)
            {
                throw new ArgumentOutOfRangeException("El numero de errores no puede ser menor a 0 ni mayor a 20");
            }
        }

    }
}
