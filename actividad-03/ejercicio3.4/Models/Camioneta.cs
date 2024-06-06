using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Camioneta : Vehiculos
    {
		private int capacidadCarga;

		public int CapacidadCarga
		{
			get { return capacidadCarga; }
			set { Validar.ValidarCapacidad(value); capacidadCarga = value; }
		}

        public Camioneta()
        {
            this.CapacidadCarga = 1;
        }
    }
}
