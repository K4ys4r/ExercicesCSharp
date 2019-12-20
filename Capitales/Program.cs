using System;

namespace Capitales
{
    class Program
    {
      static  string[] pays = new string[] {"Albanie", "Allemagne", "Andorre", "Autriche", "Belgique",
                                            "Biélorussie", "Bosnie-Herzégovnie", "Bulgarie", "Chypre",
                                            "Croatie","Danemark","Espagne","Estonie","Finlande","France"};
      static  string[] capitales = new string[] {"Tirana","Berlin","Andorre-la-Vieille","vienne","Bruxelles",
                                                  "Minsk","Sarajevo","Sofia","Nicosie","Zagreb",
                                                  "Copenhague","Madrid","Tallinn","Helsinki","Paris"};

        static void Main(string[] args)
        {
            //Jouer();
            Jouer2();
            //PoserQuestion(5);

        }


        
        static void Jouer2()
        {
            Console.Clear();
            Console.WriteLine("Appuyer sur Echap pour arrêter le jeu");
            //ConsoleKeyInfo utilisateurMessage = Console.ReadKey();

            //Console.WriteLine(utilisateurMessage.Key);
            ConsoleKeyInfo utilisateurMessage = Console.ReadKey();


            while (utilisateurMessage.Key != ConsoleKey.Escape  )
            {
                Random rd = new Random();
                int i = rd.Next(pays.Length - 1);
                PoserQuestion(i);
                utilisateurMessage = Console.ReadKey();
            }
        }

        static void PoserQuestion(int i)
        {
            if (i>=0 && i<pays.Length)
            {
                Console.WriteLine("\nQuelle est la capitale de : {0}",pays[i]);
                string rep = Console.ReadLine();
                if (rep.ToLower() == capitales[i].ToLower())
                {
                    Console.WriteLine("Bravo !");
                }
                else
                {
                    Console.WriteLine("Mauvaise réponce.\nLa bonne réponce était {0}", capitales[i]);
                }

            }
        }

        static void Jouer()
        {
            string jouerEncore = "o";
            while (jouerEncore.ToLower() == "o")
            {
                int compteur = 0;
                Console.Clear();
                for (int i = 0; i < pays.Length; i++)
                {
                    Console.WriteLine("\nQuelle est la capitale de : {0}", pays[i]);
                    string rep = Console.ReadLine();
                    if (rep.ToLower() == capitales[i].ToLower())
                    {
                        Console.WriteLine("Bravo !");
                        compteur++;
                    }
                    else
                    {
                        Console.WriteLine("Mauvaise réponce.\nLa bonne réponce était {0}", capitales[i]);
                    }
                }
                Console.WriteLine("Vous avez eu {0} bonnes réponces\n", compteur);

                Console.WriteLine("Voulez-vous jouer encore ? ");
                jouerEncore = Console.ReadLine();
            }
            Console.WriteLine("Merci d'avoir joué");

        }


        /*
        // Demander pour tous les pays 
        for (int i = 0; i < pays.Length; i++)
        {
            Console.WriteLine("Quelle est la capitale de : {0}",pays[i]);
            string rep = Console.ReadLine();
            string message = (rep.ToLower() == capitales[i].ToLower()) ? "Bravo !" : "Mauvaise réponse";
            Console.WriteLine(message);
        }
        */


        /*
        // Demander pour 1/2 pays
        for (int i = 0; i < pays.Length; i=i+2)
        {
                Console.WriteLine("Quelle est la capitale de : {0}", pays[i]);
                string rep = Console.ReadLine();
                string message = (rep.ToLower() == capitales[i].ToLower()) ? "Bravo !" : "Mauvaise réponse";
                Console.WriteLine(message);
        }
        */

        /*
        // Demander pour tous les pays en partand de la fin 
        for (int i = pays.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("Quelle est la capitale de : {0}", pays[i]);
            string rep = Console.ReadLine();
            string message = (rep.ToLower() == capitales[i].ToLower()) ? "Bravo !" : "Mauvaise réponse";
            Console.WriteLine(message);
        }
        */

        /*
        // compter la bomme reponse
        int compteur = 0;0
        for (int i = 0; i < pays.Length; i++)
        {
            Console.WriteLine("Quelle est la capitale de : {0}",pays[i]);
            string rep = Console.ReadLine();
            if (rep.ToLower() == capitales[i].ToLower())
            {
                Console.WriteLine("Bravo !");
                compteur++;
            }
            else
            {
                Console.WriteLine("Mauvaise réponce.");
            }
        }
        Console.WriteLine("Vous avez eu {0} bonnes réponces",compteur);
        */

    }
}
