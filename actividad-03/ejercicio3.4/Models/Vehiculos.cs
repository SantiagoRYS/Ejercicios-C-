using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vehiculos
    {
		private string numSerie;

		public string NumSerie
		{
			get { return numSerie; }
			set { numSerie = value; }
		}

		private string marca;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		private int año;

		public int Año
		{
			get { return año; }
			set { Validar.ValidarAño(value); año = value; }
		}

		private int precio;

		public int Precio
		{
			get { return precio; }
			set { Validar.ValidarPrecio(value); precio = value; }
		}

        public Vehiculos()
        {
            this.Año = 1885;
			this.Precio = 1;
			this.Marca = string.Empty;
			this.NumSerie = string.Empty;
        }

    }
}
