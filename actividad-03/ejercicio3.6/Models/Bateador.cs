using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bateador : Jugador
    {
		private int hits;

		public int Hits
		{
			get { return hits; }
			set { Validacion.ValidarHit(value); hits = value; }
		}

        public Bateador()
        {
            this.NumUniforme = 0;
            this.Nombre = "Robert";
            this.hits = 1;
        }

    }
}
