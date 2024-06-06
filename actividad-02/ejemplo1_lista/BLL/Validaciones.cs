namespace BLL
{
    public class Validaciones
    {
        public static void ValidarSueldo(double sueldo)
        {
            if (sueldo <= 0)
            {
                throw new ArgumentOutOfRangeException("El valor del sueldo no puede ser menor o igual a 0");
            }
        }

        public static void ValidarNumero(int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentOutOfRangeException("El numero no puede ser menor o igual a 0");
            }
        }

        public static void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no debe estar vacío");
            }
        }

    }
}
