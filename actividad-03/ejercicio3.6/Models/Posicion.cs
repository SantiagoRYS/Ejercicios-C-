using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Posicion : Jugador
    {

		private int hits;

		public int Hits
		{
			get { return hits; }
			set { Validacion.ValidarHit(value); hits = value; }
		}

		private int errores;

		public int Errores
		{
			get { return errores; }
			set { errores = value; }
		}


		public Posicion()
        {
			this.NumUniforme = 0;
			this.Nombre = "Robert";
            this.hits = 1;
			this.errores = 1;

        }

    }
}
