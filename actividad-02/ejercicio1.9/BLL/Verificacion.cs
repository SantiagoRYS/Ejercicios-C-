namespace BLL
{
    public class Verificacion
    {
        public static void Validargalon(int g)
        {
            if (g <= 0)
            {
                throw new ArgumentException("No se puede registrar un numero de galones que no sea entero / tampoco se puede registrar menos de un galon");
            }

        }
    }
}
