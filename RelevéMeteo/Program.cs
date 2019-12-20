using System;
using System.IO;
using System.Text;

namespace RelevéMeteo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ligneHorizontal = new string('-', 5 * 14 + 8);
            string[] donnéesMeteo = File.ReadAllLines(@"..\..\..\DonnéesMétéoParis.txt");
            Console.WriteLine(string.Format("{0,14} |{1,14} |{2,14} |{3,14} |{4,14}","Mois","T° min","T° max","Précip (mm)","Ensol (H)"));

            Console.WriteLine(ligneHorizontal);
            RelevéMensuel donnéeAfficher;
            for (int i = 1; i < donnéesMeteo.Length; i++)
            {
                donnéeAfficher = new RelevéMensuel(donnéesMeteo[i]);
                Console.WriteLine(donnéeAfficher.ToString());
            }

        }
    }
}
