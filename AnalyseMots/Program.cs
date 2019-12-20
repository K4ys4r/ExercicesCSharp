using System;

namespace AnalyseMots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un mot : ");
            string utilisateurMot = Console.ReadLine();
            int nVoyelles, nConsonnes;
            CompterLetters(utilisateurMot,out nVoyelles, out nConsonnes);
            string message;
            message = $"\"{utilisateurMot}\" comporte {nVoyelles + nConsonnes} lettres," +
                $" dont {nConsonnes} consonnes et {nVoyelles} voyelles";
            Console.WriteLine(message);

        }

        static void CompterLetters(string mot,out int nbVoyelles, out int nbConsonnes)
        {
            nbConsonnes = 0;
            nbVoyelles = 0;
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == 'a' || mot[i] == 'e' ||
                    mot[i] == 'u' || mot[i] == 'i' ||
                    mot[i] == 'o' || mot[i] == 'y')
                {
                    nbVoyelles++;
                }
                else
                {
                    nbConsonnes++;
                }

            }

        }
    }
}
