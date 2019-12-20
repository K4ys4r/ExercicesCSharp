using System;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jouez au pendu!");

            //--------------------------------------------------------------------------
            // 1. Les étapes ci-desous consistent à faire saisir un mot valide au 1er joueur
            
            string mot = string.Empty;
            bool motValide = false;
            char lettreJoeur;


            
            // Tant que le mot saisi n'est pas valide
            while (!motValide)
            {

                Console.WriteLine("Saisissez un mot de 3 à 25 lettres sans accent : ");
                mot = Console.ReadLine().ToLower();

                try
                {
                    // On fait saisir le mot
                    // On vérifie son format (appeler la méthode statique VerifierMot)
                    Jeu.VerifierMot(mot);
                    motValide = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //--------------------------------------------------------------------------
            // 2. les étapes suivantes consistent à faire deviner le mot au 2d joueur

            // On vide l'écran
            Console.Clear();

            // On crée un jeu et on l'initialise avec le mot saisi
            Jeu jeu = new Jeu();
            jeu.InitialiserJeu(mot);

            // Tant que le jeu n'est pas fini
            while (jeu.GetEtatPartie() == EtatsPartie.EnCours)
            {
                Console.WriteLine(jeu.GetDessinPendu());
                // On affiche le dessin et l'état du mot en cours
                Console.WriteLine("Mot en cours de déchiffrage : {0}\nProposez une lettre: ", jeu.GetMotEnCours());

                // On demande une lettre et on la teste
                lettreJoeur = Console.ReadKey().KeyChar;
                jeu.TesterLettre(lettreJoeur);
                // Si la partie est gagnée, on affiche un message en vert
                if (jeu.GetEtatPartie() == EtatsPartie.Gagnée)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bravo, vous avez gagné");
                    Console.ResetColor();
                }
                // Si elle est perdue on affiche un message en rouge avec la solution
                if (jeu.GetEtatPartie() == EtatsPartie.Perdue)
                {
                    Console.WriteLine(jeu.GetDessinPendu());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPerdu! Le mot à deviner était : {0}", jeu.GetMotADeviner());
                    Console.ResetColor();
                }
            }
            
            Console.ReadKey();
        }
    }
}
