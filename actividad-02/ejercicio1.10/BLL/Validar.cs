namespace BLL
{
    public class Validar
    {
        public static void ValidarHamburguesaS(int HS)
        {
            if (HS < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }

        public static void ValidarHamburguesaQ(int HQ)
        {
            if (HQ < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }

        public static void ValidarHamburguesaE(int HE)
        {
            if (HE < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }

        public static void ValidarPapasFritas(int PF)
        {
            if (PF < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }

        public static void ValidarRefresco(int R)
        {
            if (R < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }

        public static void ValidarPostre(int P)
        {
            if (P < 0)
            {
                throw new ArgumentException("El pedido no puede ser negativo");
            }
        }
    }
}
