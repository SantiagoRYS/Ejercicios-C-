using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Circunferencia
    {
        //campo
        private double radio;

        //Get
        public double ConsultarRadio() 
        {
            return this.radio;
        }

        //Set

        public void ModificarRadio(double radio) //Parametro
        {
            try
            {
                Validacion.validarRadio(radio);} 
            catch (ArgumentException ae) 
            {
                throw new ArgumentException(ae.Message);
            }
            this.radio = radio; // validar que radio >=0
        }


        public double CalcularArea()
        {
           // return Math.PI * Math.Pow(this.radio ,2);
            return Math.PI * (this.radio * this.radio);
        }

        public double CalcularPerimetro()
        {
            return (2 * Math.PI) * this.radio;
        }

    }
}
