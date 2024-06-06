namespace BLL
{
    public class Validacion
    {
        public static void ValidarCosto(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentException("El costo del auto no puede ser cero, ni menos de cero");
            }
        }
    }
}
