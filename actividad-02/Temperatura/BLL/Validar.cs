namespace BLL
{
    public class Validar
    {
        public static void ValidarGrados(double gc)
        {
            if (gc < 0 || gc > 100)
            {
                throw new ArgumentOutOfRangeException("Los grados centigrados van desde 0° hasta los 100° ");
            }
        }
    }
}
