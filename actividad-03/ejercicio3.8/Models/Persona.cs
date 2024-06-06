namespace Models
{
    public abstract class Persona
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string direcion;

		public string Direccion
		{
			get { return direcion; }
			set { direcion = value; }
		}
	}
}
