using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Empleado : Persona
    {
		private int salario;

		public int Salario
		{
			get { return salario; }
			set { Validacion.ValidarSalario(value); salario = value; }
		}

        public Empleado()
        {
            this.Nombre = "Pedro";
            this.Direccion = "calle 80 # 34c - 98";
            this.Salario = 1;
        }

    }
}
