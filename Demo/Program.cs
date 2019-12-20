using System;

namespace Demo
{
    enum Sexes {Femme, Homme }
    class Program
    {
        static void Main(string[] args)
        {
            // Appel d'une fonctione
            //Demo1();
            //Demo2();
            //Demo3();
            string nom;
            int annéeNais;
            char genre;
            Console.WriteLine("Saisissez votre nom? ");
            nom = Console.ReadLine();
            Console.WriteLine("Saisissez votre  année de naissance? ");
            annéeNais = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez votre sexe (H:Homme/F:Femme)? ");
            genre = char.Parse(Console.ReadLine());

            string message;
           // message = Demo4(nom, annéeNais, genre);
            message = Demo4_Enum(nom, annéeNais, Sexes.Homme);
            Console.WriteLine(message);
            //
            Console.ReadKey();

        }

        // definir une fonction
        static void Demo1()
        {
            // PRINT TO SCREEN
            Console.Write("écriture");
            Console.Write(" de mots les");
            Console.Write("uns à la suite des autres\n");
            Console.WriteLine("Ecriture avec retour à la ligne à la fin");
            Console.WriteLine("on peut générer un retour à la ligne \navec un caractère spécial");
            //


            // READ INPUT
            Console.WriteLine("Saisissez votre nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Bonjour " + nom + ".\nQuelle est votre année de naissance ?");
            string rep = Console.ReadLine();
            int annéeNais = int.Parse(rep);
            int age = 2019 - annéeNais;
            //Console.WriteLine("Vous allez avoir " + age + " ans."); // first method
            //Console.WriteLine("Bonjour {0}, Vous allez avoir {1} ans.", nom, age); // second method
            Console.WriteLine($"Bonjour {nom}, Vous allez avoir {age} ans."); // third method (chaine interpolée)
            //


            // IF OPERATION
            if (annéeNais % 4 == 0) // == et pas = car ce n'est pas une affectation
            { // une seule ligne pas besoin de { 
                Console.WriteLine("Vous êtes né.e durant une année bissexile");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas né.e durant une année bissextile");
            }
            //


            // OPERATEUR ternaire
            string message;
            //             if ()               message              else :    message   
            message = (annéeNais % 4 == 0) ? "est une année bissextile" : "n'est pas une année bissextile";
            Console.WriteLine(message);
            //

            // IF plus complexe
            if (age < 25)
                Console.WriteLine("Vous êtes dans la tranche d'âge : moins de 25 ans");
            else if (age >= 25 && age < 35)
                Console.WriteLine("Xouss êtes dans la tranche d'âge 25 - 35 ans");
            else
                Console.WriteLine("vous êtes dans la tranche d'âge : plus de 35 ans");
            //


            // declaration d'un constant
            const int annéemin = 1900;
            const int annéemax = 2019;
            if (annéeNais < annéemin || annéeNais > annéemax)
                Console.WriteLine("Vous devez saissir une année de naissance valide");
        }

        static void Demo2()
        {
            string text;
            string phrase;
            int nbPhrases, nbMots;

            phrase = "le C# est un langage moderne et puissant";
            text = phrase;
            text = text + " il est utilisé pour toutes sortes d'applications\n";
            text += "- Applications Console\n";
            text += "- Applications fenêtrée avec Winforms ety WPF\n";
            text += "- Applications mobile avec Xamarin\n";

            Console.WriteLine(text);

            // char variable
            char lettre;
            lettre = phrase[3];
            //

            //tableau
            int[] tabPos = new int[3];
            tabPos[0] = 3;
            tabPos[1] = 4;
            tabPos[2] = 40;
            // une autre methode plus condensée
            tabPos = new int[3] { 3, 4, 40 };
            Console.WriteLine(tabPos.Length);
            //

            //Boucle FOR
            for (int i = 0; i < tabPos.Length; i++)
            {
                Console.WriteLine("Position {0} : {1}", i, tabPos[i]);
            }
            //

            //Boucle WHILE
            int j = 0;
            while (j < tabPos.Length)
            {
                Console.WriteLine("Position {0} : {1}", j, tabPos[j]);
                j++;
            }
            //

            //Boucle DO WHILE
            j = 0;
            do
            {
                Console.WriteLine("Position {0} : {1}", j, tabPos[j]);
                j++;
            } while (j < tabPos.Length);
            //

            //Boucle FOREACH
            foreach (int item in tabPos)
            {
                Console.WriteLine("{0}", item);
            }
            //

            //Compter le nombre de phrases dans un texte
            nbPhrases = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n') // "" pour la chaine de caractères et '' pour le caractère
                {
                    nbPhrases++;
                }
            }
            Console.WriteLine("il y a {0} phrases dans le texte", nbPhrases);

        }

        static void Demo3()
        {
            string phrase = "le C# est un langage moderne et puissant";

            int n = CompterMots(phrase);
            Console.WriteLine("La phrase \"{0}\" comporte {1} mots", phrase, n);
        }
        
        
        static string Demo4_Enum(string noM,int annee, Sexes s)
        {
            const int annéeActuel = 2019;
            int age = annéeActuel - annee;
            if (s == Sexes.Homme)
            {
                return $"Bonjour Monsieur {noM}, vous avez {age} ans.";
            }
            else
                return $"Bonjour Madame {noM}, vous avez {age} ans.";
        }
        static string Demo4(string noM,int annee, char s)
        {
            const int annéeActuel = 2019;
            int age = annéeActuel - annee;
            if (s == 'H')
            {
            //    Console.WriteLine("Bonjour Monsieur {0}, vous avez {1} ans.",noM,age);
            //    return string.Format("Bonjour Monsieur {0}, vous avez {1} ans.",noM,age);
                return $"Bonjour Monsieur {noM}, vous avez {age} ans.";
            }
            else if(s == 'F')
            {
            //    Console.WriteLine("Bonjour Madame {0}, vous avez {1} ans.", noM, age);
                return $"Bonjour Madame {noM}, vous avez {age} ans.";
            }
            else
            {
               return "Vous êtes anonyme";
            }

        }

        static int CompterMots(string p) //Entete de la fonction "string p" est un paramétre, static int car la fonction va envoyer un entier
        {
            int nbMots = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == ' ' || p[i] == '\'' || p[i] == '\n')
                {
                    nbMots++;
                }
            }
            return nbMots + 1;
        }
    }
}
