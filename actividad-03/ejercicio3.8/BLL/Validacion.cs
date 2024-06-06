namespace BLL
{
    public class Validacion
    {
        public static void ValidarSalario(int s)
        {
            if (s <= 0)
            {
                throw new ArgumentOutOfRangeException("El sueldo de un empleado no puede ser negativo ni 0");
            }
        }

        public static void ValidarCredito(int c)
        {
            if (c < 0)
            {
                throw new ArgumentOutOfRangeException("El limite de credito no puede ser negativo");
            }
        }

    }
}
