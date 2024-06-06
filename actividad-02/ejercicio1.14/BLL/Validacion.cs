namespace BLL
{
    public class Validacion
    {
        public static void ValidarNumero(int n)
        {
            if (n < 0)
            {

                throw new ArgumentException("El numero tiene que ser un entero positivo");

            }
        }
    }
}
