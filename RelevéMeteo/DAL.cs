using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RelevéMeteo
{
    static class DAL
    {
        const string _CHEMIN_Fichier = @"..\..\..\DonnéesMétéoParis.txt";

        public static List<RelevéMensuel> GetRelevésMensuels()
        {
            var liste = new List<RelevéMensuel>();
            var donnéesFichier = File.ReadAllLines(_CHEMIN_Fichier);
            for (int i = 1; i < donnéesFichier.Length; i++)
            {
               liste.Add(new RelevéMensuel(donnéesFichier[i]));
            }
            return liste;
        }
    }
}
