using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Portero : Jugador
    {

        private int numPortero;

        public int NumPortero
        {
            get { return numPortero; }
            set { Validacion.ValidarNumeroP(value); numPortero = value; }
        }

        public Portero()
        {

            this.NumPortero = 1;
            this.Nombre = "Raul";
            this.MinJugados = 90;

        }
    }
}
