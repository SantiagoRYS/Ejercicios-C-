namespace BLL
{
    public class Validar
    {
        public static void ValidarClave(int cl)
        {
            if (cl <= 0 )
            {
                throw new ArgumentException("La clave no puede estar vacia");
            }
        }

        public static void ValidarDescripcion(string de)
        {
            if (string.IsNullOrEmpty(de))
            {
                throw new ArgumentException("La descripcion del articulo no puede estar vacia");
            }
        }

        public static void ValidarPrecio(double pr)
        {
            if (pr <= 0)
            {
                throw new ArgumentException("El precion tiene que ser mayor a 0");
            }
        }

        public static void ValidarCantidad(int ca)
        {
            if (ca < 0)
            {
                throw new ArgumentException("La cantidad de articulos no puede ser menor a 0");
            }
        }

    }
}
