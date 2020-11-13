using System;

namespace pekseg
{
    class Pekaru
    {
        string nev;
        int ar;
        bool laktozmentes;

        public Pekaru(string nev, int ar, bool laktozmentes)
        {
            this.nev = nev;
            this.ar = ar;
            this.laktozmentes = laktozmentes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Laktozmentes { get => laktozmentes; set => laktozmentes = value; }

        public override string ToString()
        {
            return String.Format("{0} ({1} Ft / db)", Nev, Ar);
        }
    }
}
