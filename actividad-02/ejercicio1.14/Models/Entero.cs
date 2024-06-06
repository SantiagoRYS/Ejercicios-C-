using BLL;

namespace Models
{
    public class Entero
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { Validacion.ValidarNumero(value); numero = value; }
		}

		public bool ValidarPrimo()
		{
			if (numero <=1)
			{
				return false;
			}
			else
			{

				for (int s = 2; s < numero; s++)
				{
					if (numero % s == 0)
					{
                        return false;
                    }
				}
				return true;
				
			}
		}
	}
}
