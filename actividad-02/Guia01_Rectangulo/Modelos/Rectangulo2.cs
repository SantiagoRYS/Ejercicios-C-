using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Rectangulo2
    {
        private double ancho;
        private double largo;


        public double Ancho 
        { 
            get => ancho;
            set 
            {
                try
                {
                    Validacion.validarDistancia(ancho);
                }
                catch (ArgumentException ae)
                {
                    throw new ArgumentException(ae.Message);
                }
                this.ancho = value;
            } 
        }
        public double Largo
        {
            get => largo;
            set
            {
                try
                {
                    Validacion.validarDistancia(largo);
                }
                catch (ArgumentException ae)
                {
                    throw new ArgumentException(ae.Message);
                }
                this.largo = value;
            }
        }

        public double CalcularArea()
        {
            return this.largo * this.ancho;
        }


    }
}
