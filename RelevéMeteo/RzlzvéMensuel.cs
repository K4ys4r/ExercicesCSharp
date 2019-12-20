using System;
using System.Collections.Generic;
using System.Text;

namespace RelevéMeteo
{
    class RelevéMensuel
    {
        public DateTime Mois { get; set; }
        public double TemperatureMin { get; set; }
        public double TemperatureMax { get; set; }
        public double Précipitation { get; set;}
        public double Ensoleil { get; set; }

        public RelevéMensuel(string info)
        {

            string [] ligneInfos = info.Split('\t');
            Mois = DateTime.Parse(ligneInfos[0]);
            TemperatureMin = double.Parse(ligneInfos[1]);
            TemperatureMax = double.Parse(ligneInfos[2]);
            Précipitation = double.Parse(ligneInfos[3]);
            Ensoleil = double.Parse(ligneInfos[4]);
        }

        public override string ToString()
        {
            return string.Format("{0,14} |{1,14} |{2,14} |{3,14} |{4,14}",Mois.ToString("MM/yyyy"),
                TemperatureMin,TemperatureMax,Précipitation,Ensoleil);
        }
    }
}
