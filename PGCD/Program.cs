using System;

namespace PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, q, pgcd=0;
            EntrerNombres(out p, out q);
            pgcd = CalculerPGCD(p, q);
            //pgcd = CalculerPGCD2(p, q);
            Console.WriteLine("le PGCD de {0} et {1} est : {2}",p,q,pgcd);

        }

        static void EntrerNombres(out int p, out int q)
        {
            Console.WriteLine("Entrez le premier nombre : ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le deuxieme nombre : ");
            q = int.Parse(Console.ReadLine());
        }


        /*
        static int CalculerPGCD2(int p, int q)
        {
            if (p <= q)
            {
                q = q - p;
            }
            else
            {
                p = p - q;
            }
            return (p == q) ? p : CalculerPGCD(p, q);
        }*/

        static int CalculerPGCD(int p, int q)
        {
            while (p != q)
            {
                if (p <= q)
                {
                    q = q - p;
                }
                else
                {
                    p = p - q;
                }
            }
            return p;
        }
    }
}
