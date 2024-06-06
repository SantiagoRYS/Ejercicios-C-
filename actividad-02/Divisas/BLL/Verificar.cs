namespace BLL
{
    public class Verificar
    {
        public static void ValidarPesos(double p)
        {
            if (p <= 0)
            {
                throw new ArgumentException("La cantidad de dinero no puede ser menor de 1");
            }
        }

        public static void ValidarCambio(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentException("El cambio de divisas no puede ser menor de 1");
            }
        }
    }
}
