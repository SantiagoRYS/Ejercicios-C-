using BLL;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Articulo
    {
        private int clave;

        public int Clave
        {
            get { return clave; }
            set { Validar.ValidarClave(value); clave = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { Validar.ValidarDescripcion(value); descripcion = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { Validar.ValidarPrecio(value); precio = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { Validar.ValidarCantidad(value); cantidad = value; }
        }

        public Articulo(int cl, string de, double pr, int ca)
        {
            this.Clave = cl;
            this.Descripcion = de;
            this.Precio = pr;
            this.Cantidad = ca;
        }

        public double CalcularIva()
        {

            return precio * 0.19;

        }
    }

}
