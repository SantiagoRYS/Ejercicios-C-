using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pitchers : Jugador
    {

        private int ponches;

        public int Ponches
        {
            get { return ponches; }
            set { Validacion.ValidarPonches(value); ponches = value; }
        }

        private int errores;

        public int Errores
        {
            get { return errores; }
            set { Validacion.ValidarErrores(value); errores = value; }
        }


        public Pitchers()
        {
            this.NumUniforme = 0;
            this.Nombre = "Robert";
            this.ponches = 1;
            this.errores = 1;

        }
    }
}
