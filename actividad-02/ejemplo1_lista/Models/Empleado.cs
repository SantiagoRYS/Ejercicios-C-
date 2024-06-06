using BLL;

namespace Models
{
    public class Empleado
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { Validaciones.ValidarNumero(value); numero = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { Validaciones.ValidarNombre(value); nombre = value; }
		}

		private double sueldo;

		public double Sueldo
		{
			get { return sueldo; }
			set { Validaciones.ValidarSueldo(value); sueldo = value; }
		}

        public Empleado()
        {
            
        }

		public double CalcularNomina()
		{
			double Nomina =+ Sueldo;
			return Nomina;
		}



    }
}
