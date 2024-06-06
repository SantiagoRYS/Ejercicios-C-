using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CD : Publicacion
    {
        private double duracion;

        public double Duracion
        {
            get { return duracion; }
            set { Validacion.ValidarDuracion(value); duracion = value; }
        }
    }
}
