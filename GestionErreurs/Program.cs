using System;

namespace GestionErreurs
{
    class Program
    {

        static void Main(string[] args)
        {

            CréerCompte();
            Console.WriteLine("\nVotre compte a bien été créé. Un message vient de vous être envoyé ");
        }

        //Definir LEs Fonction
        static void CréerCompte()
        {
            bool loginBon = false;
            string loginUtilisateur;
            string motDePasse;
            while (!loginBon)
            {
                try
                {
                    Console.WriteLine("Saisissez votre login : ");
                    loginUtilisateur = Console.ReadLine();
                    VerifierLogin(loginUtilisateur);
                    loginBon = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            bool mdpBon = false;
            while (!mdpBon)
            {
                try
                {
                    Console.WriteLine("Saisissez votre mot de pass : ");
                    motDePasse = Console.ReadLine();
                    VerifierMotDePasse(motDePasse);
                    mdpBon = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        static void VerifierLogin(string nom)
        {
            if (nom.Length < 5)
            {
                throw new FormatException("Le login doit faire au moins 5 caractères");
            }
        }

        static void VerifierMotDePasse(string mdpass)
        {
            int nbLettre = 0;
            int nbChiffre = 0;
            if (mdpass.Length >= 6)
            {
                for (int i = 0; i < mdpass.Length; i++)
                {
                    if (mdpass[i] >= 48 && mdpass[i] <= 57)
                    {
                        nbChiffre++;
                    }
                    else if ((mdpass[i] >= 65 && mdpass[i] <= 90) ||
                        (mdpass[i] >= 97 && mdpass[i] <= 122))
                    {
                        nbLettre++;
                    }
                }
            }
            else
            {
                throw new FormatException("Le mot de pass doit comporter au moins 6 caractères");
            }
            if (nbLettre < 1 || nbChiffre < 1)
            {
                throw new FormatException("Le mot de pass doit comporter au moins une lettre et un chiffre.");
            }
        }

        /////


    }
}
