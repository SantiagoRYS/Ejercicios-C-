namespace BLL
{
    public class Validacion
    {
        public static void ValidarMinutos(int d)
        {
            if (d <= 0)
            {
                throw new ArgumentException($"La duracion de la llamada no puede ser menor de un minuto");
            }
        }
    }
}
