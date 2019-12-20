using System;
using System.Collections.Generic;
using System.Text;

namespace Véhicules
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Véhicule voiture1 = new Voiture("Mégane", 19000);
            Véhicule moto1 = new Moto("Intruder", 13000);
            Véhicule voiture2 = new Voiture("Enzo", 380000);
            Véhicule moto2 = new Moto("Yamaha XJR1300 ", 11000);
            //moto2.Prix = 13000;

            Console.WriteLine("Le classement dans liste1 :");
            var liste1 = new SortedList<string, Véhicule>();
            liste1.Add(voiture1.Nom, voiture1);
            liste1.Add(voiture2.Nom, voiture2);
            liste1.Add(moto1.Nom, moto1);
            liste1.Add(moto2.Nom, moto2);
            foreach (var item in liste1)
            {
                Console.WriteLine($"{item.Key} : {item.Value.Prix}");
            }

            Console.WriteLine("\nLe classement dans liste2 :");
            var liste2 = new SortedList<Véhicule, string>();
            liste2.Add(voiture1, voiture1.Nom);
            liste2.Add(voiture2, voiture2.Nom);
            liste2.Add(moto1, moto1.Nom);
            liste2.Add(moto2, moto2.Nom);

            foreach (var item in liste2)
            {
                //Console.WriteLine($"{item.Value} : {item.Key.Prix}");
                Console.WriteLine($"{item.Value} : {item.Key.Prix.ToString("C0")}");
            }


            Console.WriteLine("\nRecherche le Prix du véhicule");
            string[] listVehicule = new string[] { "Clio", "Mégane", "Golf", "Enzo", "Polo" };
            foreach (var item in listVehicule)
            {
                if (liste1.ContainsKey(item))
                {
                    Console.WriteLine($"{liste1[item].Nom} : {liste1[item].Prix}");
                }
            }

            Console.ReadKey();

        }
    }
}
