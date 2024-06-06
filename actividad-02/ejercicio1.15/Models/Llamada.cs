namespace Models
{
    public class Llamada
    {
		private int duracion;

		public int Duracion
		{
			get { return duracion; }
			set { duracion = value; }
		}

		public int CalcularCosto()
		{
			int costo = 5;
			if (duracion >= 1 && duracion <=3)
			{
				costo = 5;
			}
			else if (duracion > 3)
			{
				for (int i = 3; i <= duracion; i++)
				{
					costo = (costo + 3);
				}
			}
			return costo;
		}

	}
}
