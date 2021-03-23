using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    class Sportif : Pokemon
    {
        public double Taille;
        public int NmbPattes;
        public int FreqCard;

        public Sportif()
        {

        }

        public Sportif(string Nom, double Poids, double Taille, int NmbPattes, int FreqCard) : base (Nom, Poids)
        {
            this.Taille = Taille;
            this.NmbPattes = NmbPattes;
            this.FreqCard = FreqCard;
        }

        public int GetNbpatte()
        {
            return this.NmbPattes;
        }

        public void SetNmbpatte(int Nmbpatte)
        {
            this.NmbPattes = Nmbpatte;
        }

        public double GetTaille()
        {
            return this.Taille;
        }

        public void SetTaille(double Taille)
        {
            this.Taille = Taille;
        }

        public int GetFreqcard()
        {
            return this.FreqCard;
        }

        public void SetFcardiaque(int FreqCard)
        {
            this.FreqCard = FreqCard;
        }

        public override string descriptif()
        {
            string resultat = base.descriptif() + "j'ai " + this.NmbPattes + " pattes pour marcher, je mesure " + this.Taille
            + "m, ma vitesse est de: "+NmbPattes*Taille*3+"km/h \net pour finir j'adore le sport, mon pouls est de " + this.FreqCard +" battements par minute\n\n" ;
            return resultat;
        }

    }
}
