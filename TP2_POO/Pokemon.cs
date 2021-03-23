using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    public class Pokemon
    {
        protected string Nom;
        protected double Poids;


        public Pokemon()
        {

        }

        public Pokemon(string Nom, double Poids)
        {
            this.Nom = Nom;
            this.Poids = Poids;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string LeNom)
        {
            this.Nom = LeNom;
        }

        public double GetPoids()
        {
            return this.Poids;
        }

        public void SetPoids(double LePoids)
        {
            this.Poids = LePoids;
        }

        public void AjouterCasanier(Pokemon LeCas)
        {
            Casaniers.Add(LeCas);
        }

        public virtual string descriptif()
        {
            string resultat = "Mon nom est " + this.Nom + " je pèse " + this.Poids +"kg ";
            return resultat;
        }
    }
}
