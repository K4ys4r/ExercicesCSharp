using System;

namespace Saisons
{
    class Program
    {
        [Flags]
        public enum Saisons
        {
            Rien = 0,
            Hiver = 1,
            Printemps = 2,
            Eté = 4,
            Automne = 8
        }

        [Flags]
        public enum Mois
        {
            Aucun = 0,
            Janvier = 1,
            Février = 2,
            Mars = 4,
            Avril = 8,
            Mai = 16,
            Juin = 32,
            Juillet = 64,
            Août = 128,
            Septembre = 256,
            Octobre = 512,
            Novembre = 1024,
            Décembre = 2048
        }

        static void Main(string[] args)
        {
            Mois jan = Mois.Janvier;
            Saisons message = Saisons.Rien;
            message = SaisonsDuMois(jan);
            Console.WriteLine(message);
        }

        static Saisons SaisonsDuMois(Mois mois)
        {
            Mois moisHiver = Mois.Décembre | Mois.Janvier | Mois.Février | Mois.Mars;
            Mois moisPrintemps = Mois.Mars | Mois.Avril | Mois.Mai | Mois.Juin;
            Mois moisEté = Mois.Juin | Mois.Juillet | Mois.Août | Mois.Septembre;
            Mois moisAutoumne = Mois.Septembre | Mois.Novembre | Mois.Octobre | Mois.Janvier;

            Saisons sais = Saisons.Rien;
            if ((mois & moisHiver) == mois)
            {
                sais |= Saisons.Hiver;
            }
            if ((mois & moisPrintemps) == mois)
            {
                sais |= Saisons.Printemps;
            }
            if ((mois & moisEté) == mois )
            {
                sais |= Saisons.Eté;
            }
            if ((mois & moisAutoumne) == mois)
            {
                sais |= Saisons.Automne;
            }

            return sais;
        }
    }
}
