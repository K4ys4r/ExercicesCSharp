using System;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
           // Boite boite1 = new Boite(25,25,12);

            //Boite boite2 = new Boite(25,25,12,Matières.Carton);

            //Console.WriteLine(boite2.Compare(boite1));


            Boite boite1 = new Boite(30,40,50,Matières.Plastique);
            Etiquette etiqBoite1 = new Etiquette { Couleur=Couleurs.Blanc,Format=Formats.L,Text="Hilal" };
            Etiquette etiqBoite1Frag = new Etiquette { Couleur=Couleurs.Rouge,Format=Formats.S,Text="FRAGILE" };

            boite1.Etiqueter("Hilal", true, etiqBoite1Frag, etiqBoite1);


            Console.WriteLine(boite1);


        }

    }
}
