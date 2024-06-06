using System.Security.Cryptography;

namespace BLL
{
    public class Verificacion
    {
        public static void ValidarDia(int di)
        {
            if (di <= 0 || di > 31)
            {
                throw new ArgumentOutOfRangeException("El dia solo puede ser de 1 a 31");
            }
        }

        public static void ValidarMes(int me)
        {
            if (me <= 0 || me > 12)
            {
                throw new ArgumentOutOfRangeException("El mes solo puede ser del mes 1 al 12");
            }
        }

        public static void ValidarAño(int añ)
        {
            if (añ <= 0 || añ > 2024)
            {
                throw new ArgumentOutOfRangeException("El año solo puede ser de 0 a 2024");
            }
        }
    }
}
