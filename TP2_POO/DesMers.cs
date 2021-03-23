using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    class DesMers : Pokemon
    {
        public int NmbNageoires;

        public DesMers() { }

        public DesMers(string Nom, double Poids, int NmbNageoires) : base(Nom, Poids)
        {
            this.NmbNageoires = NmbNageoires;
        }

        public int GetNbnageoire()
        {
            return this.NmbNageoires;
        }

        public void SetNbnageoire(int LeNmbnageoires)
        {
            this.NmbNageoires = LeNmbnageoires;
        }

        public override string descriptif()
        {
            string resultat = base.descriptif() +"je nage à "+Poids/25*NmbNageoires  +"km/h et j'ai " + this.NmbNageoires+ " nageoires\n \n";
            return resultat;
        }
    }
}
