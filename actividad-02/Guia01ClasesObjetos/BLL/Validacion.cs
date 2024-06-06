using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Validacion
    {
        public static void validarRadio(double radio)
        {
            if (radio < 0) 
            {
                throw new ArgumentException("Ek valor del radio no debe ser menor a 0");
            }
        }
    }
}
