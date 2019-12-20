using System;

namespace TrierTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            int tailleTableau = 10;
            int maxValeur = 100;
            int[] tableau = new int[tailleTableau];
            tableau = GenererTableau(tailleTableau,maxValeur);
            AfficherTableau(tableau);
            TrierTableau(tableau);
            AfficherTableau(tableau);
        }

        static void AfficherTableau(int [] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ",tab[i]);
            }
            Console.WriteLine();
        }

        static int [] TrierTableau(int [] tab)
        {
            int intermediaire = 0;
            int i = 0;

            while (i<tab.Length)
            {

                for (int j = 0; j < tab.Length - i-1; j++)
                {
                    if (tab[j]>tab[j+1])
                    {
                        intermediaire = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = intermediaire;
                    }
                    else
                    {
                        continue;
                    }

                }
                i++;
            }
            return tab;
        }

        static int [] GenererTableau(int n,int max)
        {
            Random rd = new Random();
            int[] tab = new int [n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = rd.Next(max);
            }
            return tab;


        }
    }
}
