using BLL;

namespace Models
{
    public class Restaurante
    {
        private int hamburguesaS;

        public int HamburguesaS
        {
            get { return hamburguesaS; }
            set { Validar.ValidarHamburguesaS(value) ; hamburguesaS = value; }
        }

        private int hamburguesaQ;

        public int HamburguesaQ
        {
            get { return hamburguesaQ; }
            set { Validar.ValidarHamburguesaQ(value); hamburguesaQ = value; }
        }

        private int hamburguesaE;

        public int HamburguesaE
        {
            get { return hamburguesaE; }
            set { Validar.ValidarHamburguesaE(value); hamburguesaE = value; }
        }

        private int papasFritas;

        public int PapasFritas
        {
            get { return papasFritas; }
            set { Validar.ValidarPapasFritas(value); papasFritas = value; }
        }

        private int refresco;

        public int Refresco
        {
            get { return refresco; }
            set { Validar.ValidarRefresco(value); refresco = value; }
        }

        private int postre;

        public int Postre
        {
            get { return postre; }
            set { Validar.ValidarPostre(value); postre = value; }
        }



        public int CalcularTotal()
        {
            return (hamburguesaE*20)+(hamburguesaQ*18)+(hamburguesaS*15)+(papasFritas*8)+(refresco*5)+(postre*6);
        }
    }
}
