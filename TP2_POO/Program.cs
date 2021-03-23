using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_POO
{
    class Program
    {



        static void Main(string[] args)
        {
            Pokemon P1 = new Sportif("pikachu", 18, 0.85, 2, 120);
            Pokemon P2 = new Sportif("mewtwo", 122, 2.0, 2, 100);
            Pokemon P3 = new Sportif("yveltal", 203, 5.8, 2, 140);
            
            Pokemon P7 = new DesMers("Tentacruel" , 55, 13);
            Pokemon P8 = new DesMers("Lamantine",120,2);
            Pokemon P9 = new DesMers("Poissoroy",39,5);


            List<Casanier> Pokemon = new List<Casanier>();
            Pokemon.Add(new Casanier("Salamèche", 8.5, 2, 0.6, 6));
            Pokemon.Add(new Casanier("Herbizarre", 13.0, 4, 1, 5));
            Pokemon.Add(new Casanier("Nidoran", 9.0, 4, 0.5, 2));

            Console.WriteLine(P1.descriptif());

            Console.WriteLine(P2.descriptif());

            Console.WriteLine(P3.descriptif());
            
            Console.WriteLine(P7.descriptif());

            Console.WriteLine(P8.descriptif());

            Console.WriteLine(P9.descriptif());


        }
    }
}
