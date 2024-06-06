using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente : Persona
    {
		private int limiteCredito;

		public int LimiteCredito
		{
			get { return limiteCredito; }
			set { Validacion.ValidarCredito(value); limiteCredito = value; }
		}

        public Cliente()
        {
            this.Nombre = "Pedro";
            this.Direccion = "calle 80 # 34c - 98"; 
            this.limiteCredito = 0;
        }

    }
}
