using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Auto : Vehiculos
    {
		private int cantPasajeros;

		public int CantPasajeros
		{
			get { return cantPasajeros; }
			set { Validar.ValidarCantiadad(value); cantPasajeros = value; }
		}

        public Auto()
        {
            this.CantPasajeros = 1;
        }

    }
}
