using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    public class Pokemon
    {
        private string Nom;
        private double Poids;
        private int NmbPattes;
        private double Taille;
        private int Pouls;
        private int TempsTV;
        private int NmbNageoires;
        private double Vitesse;
        private string Categorie;
        private List<Pokemon> Casaniers;
        private List<Pokemon> Sportifs;
        private List<Pokemon> DesMer;


        public Pokemon ()
         {
            Casaniers = new List<Pokemon>();
            Sportifs = new List<Pokemon>();
            DesMer = new List<Pokemon>();
         }

        public Pokemon(string Nom, double Poids, int Nmbpattes, double Taille, int Pouls, int TempsTV, int NmbNageoires, double Vitesse, string Categorie)
        {
            this.Nom = Nom;
            this.Poids = Poids;
            this.NmbPattes = Nmbpattes;
            this.Taille = Taille;
            this.Pouls = Pouls;
            this.TempsTV = TempsTV;
            this.NmbNageoires = NmbNageoires;
            this.Vitesse = Vitesse;
            this.Categorie = Categorie;
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

        public int GetNbpatte()
        {
            return this.NmbPattes;
        }

        public void SetNbpatte(int LeNbpatte)
        {
            this.NmbPattes = LeNbpatte;
        }

        public double GetTaille()
        {
            return this.Taille;
        }

        public void SetTaille(double LaTaille)
        {
            this.Taille = LaTaille;
        }

        public int GetFcardiaque()
        {
            return this.Pouls;
        }

        public void SetFcardiaque(int LePouls)
        {
            this.Pouls = LePouls;
        }

        public int GetTempsTV()
        {
            return this.TempsTV;
        }

        public void SetHeuretélé(int LeTempsTV)
        {
            this.TempsTV = LeTempsTV;
        }

        public int GetNbnageoire()
        {
            return this.NmbNageoires;
        }

        public void SetNbnageoire(int LeNmbnageoires)
        {
            this.NmbNageoires = LeNmbnageoires;
        }
        public double GetVitesse()
        {
            return this.Vitesse;
        }

        public void SetVitesse(double LaVitesse)
        {
            this.Vitesse = LaVitesse;
        }

        public string GetCategorie()
        {
            return this.Categorie;
        }

        public void SetCategorie(string LaCategorie)
        {
            this.Categorie = LaCategorie;
        }

        public void AjouterCasanier(Pokemon LeCas)
        {
            Casaniers.Add(LeCas);
        }

        public string descriptif()
        {
            string resultat="";

            switch (this.Categorie)
            {
                case "sportif" :
                    resultat = "Je suis le Pokémon " + this.Nom;
                    resultat += "\nMon poids est de " + this.Poids;
                    resultat += "\nMa vitesse est de " + this.Vitesse;
                    resultat += "\nJ'ai " + this.NmbPattes + "patte(s)";
                    resultat += "\nMa taille est de " + this.Taille;
                    resultat += "\nMa fréquence cardiaque est de " + this.Pouls + "battements par minute.";
                    break;

                case "casanier":
                    resultat = "Je suis le Pokémon " + this.Nom;
                    resultat += "\nMon poids est de " + this.Poids;
                    resultat += "\nMa vitesse est de " + this.Vitesse;
                    resultat += "\nJ'ai " + this.NmbPattes + "patte(s)";
                    resultat += "\nMa taille est de " + this.Taille;
                    resultat += "\nJe regarde la télé " + this.TempsTV + "par jour.";
                    break;

                case "des mers":
                    resultat = "Je suis le Pokémon " + this.Nom;
                    resultat += "\nMon poids est de " + this.Poids;
                    resultat += "\nMa vitesse est de " + this.Vitesse;
                    resultat += "\nJ'ai " + this.NmbNageoires + "nageoire(s)";
                    break;
            }

            return resultat;

        }

    }
}
