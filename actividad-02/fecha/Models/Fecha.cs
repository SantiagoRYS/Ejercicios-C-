using BLL;

namespace Models
{
	public class Fecha
	{
		private int dia;

		public int Dia
		{
			get { return dia; }
			set { Verificacion.ValidarDia(value); dia = value; }
		}

		private int mes;

		public int Mes
		{
			get { return mes; }
			set { Verificacion.ValidarMes(value); mes = value; }
		}

		private int año;

		public int Año
		{
			get { return año; }
			set { Verificacion.ValidarAño(value); año = value; }
		}

		public Fecha()
		{
			this.Dia = 18;
			this.Mes = 10;
			this.Año = 2000;
		}

		public Fecha(int d, int m, int a)
		{
			this.Dia = d;
			this.Mes = m;
			this.Año = a;
		}

		public void ModificarFecha(int di, int me, int añ)
		{
			this.Dia = di;
			this.Mes = me;
			this.Año = añ;
		}

		public string ConsultarFechaConLetra()
		{
			return $"{this.dia}/{this.mes}/{this.año}";
        }
    }
}
