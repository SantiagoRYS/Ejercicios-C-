namespace BLL
{
    public class Validacion
    {
        public static void validarDistancia(double distancia)
        {
            if (distancia <= 0)
            {
                throw new ArgumentException("El valor de la distancia (Largo o Ancho) no debe ser menor que 1");
            }
        }
        public static Double CalcularDiferencia(double areaPared,double areaVentana)
        {
            if (areaVentana > areaPared)
            {
                throw new ArgumentException("El area de la Ventana no puede ser menor al area de la pared");
            }
            return areaPared-areaVentana;
        }

        public static Double CalcularTiempo(double areaTotal)
        {
            if (areaTotal <= 0)
            {
                throw new ArgumentException("El area total a pintar no puede ser menor o igual que 0");
            }
            double minutos = areaTotal * 10;
            double horas = minutos / 60;
            
            return horas;
        }
    }
}