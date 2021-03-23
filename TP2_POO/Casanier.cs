using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    class Casanier : Pokemon
    {
        public int NmbPattes;
        public double Taille;
        public int TempsTV;

        public Casanier()
        {

        }

        public Casanier(string Nom,double Poids,int NmbPattes, double Taille, int TempsTV) : base( Nom, Poids)
        {
            this.NmbPattes = NmbPattes;
            this.Taille = Taille;
            this.TempsTV = TempsTV;
        }

        public int GetNmbPatte()
        {
            return this.NmbPattes;
        }

        public void SetNmbpatte(int LeNmbpatte)
        {
            this.NmbPattes = LeNmbpatte;
        }

        public double GetTaille()
        {
            return this.Taille;
        }

        public void SetTaille(double LaTaille)
        {
            this.Taille = LaTaille;
        }

        public int GetTempsTV()
        {
            return this.TempsTV;
        }

        public void SetTempsTV(int LeTempsTV)
        {
            this.TempsTV = LeTempsTV;
        }

        public override string descriptif()
        {
            string resultat = base.descriptif() + " j'ai " + this.NmbPattes + " Pattes pour marcher, je mesure " + this.Taille 
            +" cm, je me déplace à "+ NmbPattes*Taille*3+ "km/h \net pour finir j'adore regarder la télé , environ "+ this.TempsTV +"h par jour\n \n";
            return resultat;
        }
    }
}
