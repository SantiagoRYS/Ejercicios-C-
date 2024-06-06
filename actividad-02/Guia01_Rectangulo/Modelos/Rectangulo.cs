using BLL;

namespace Modelos
{
    public class Rectangulo
    {

        private double largo;
        private double ancho;

        public double CalcularArea()
        {
            return this.largo * this.ancho;   
        }

        /**
         * 
         * @param l
         */
        public void ModificarLargo(double l)
        {
            try
            {
                Validacion.validarDistancia (l);} 
            catch (ArgumentException ae) 
            {
                throw new ArgumentException(ae.Message);
            }
            this.largo = l;
        }

        /**
         * 
         * @param a
         */
        public void ModificarAncho(double a)
        {
            try
            {
                Validacion.validarDistancia(a);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException(ae.Message);
            }
            this.ancho = a;
        }

        public double ConsultarLargo()
        {
            return this.largo; 
        }

        public double ConsultarAncho()
        {
            return this.ancho; 
        }

    }
}