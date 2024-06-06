namespace BLL
{
    public class Validacion
    {
        public static void ValidarDia(int d)
        {
            if (d <= 0)
            {
                throw new ArgumentException("La cantidad de dias no puede ser menos de 1");
            }
        }
    }
}
