using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro : Publicacion
    {
		private int numeroPaginas;

		public int NumeroPaginas
		{
			get { return numeroPaginas; }
			set { Validacion.ValidarNumeroPaginas(value); numeroPaginas = value; }
		}
	}
}
