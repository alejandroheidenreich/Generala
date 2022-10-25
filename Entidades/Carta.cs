namespace Entidades
{
    public enum Palo
    {
        Espada, Basto, Oro, Copa
    }
    public  class Carta
    {
        int numero;
        Palo palo;

        public Carta(int numero, Palo palo)
        {
            this.numero = numero;
            this.palo = palo;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }
        public Palo Palo
        {
            get => palo;
            set => palo = value;
        }

        public bool SonMismoPalo(Carta otraCarta)
        {
            return this.Palo == otraCarta.Palo;
        }
    }
}
