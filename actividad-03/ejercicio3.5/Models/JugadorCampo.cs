using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JugadorCampo : Jugador
    {

		private int numJugador;

		public int NumJugador
		{
			get { return numJugador; }
			set { Validacion.ValidarNumeroJ(value); numJugador = value; }
		}

		private int goles;

		public int Goles
		{
			get { return goles; }
			set { Validacion.ValidarGoles(value); goles = value; }
		}

        public JugadorCampo()
        {
            this.NumJugador = 1;
            this.Nombre = "Raul";
            this.MinJugados = 90;
            this.Goles = 0;
        }

    }
}
