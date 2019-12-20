using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RelevéMeteo
{
    class Stats
    {
        private List<RelevéMensuel> _listeRelevés;
        //public double ReleveTempMax { get; private set; }
        public RelevéMensuel ReleveTempMax { get; private set; }
        public double EnsoleillementMoyenJuillet { get; private set; }
        public double NbMoisChauds { get; private set; }

        public Dictionary<int, double> PrécipitationsMoyennesParAnnée { get; set; }
        public Stats(List<RelevéMensuel> listeRelevés)
        {
            _listeRelevés = listeRelevés;


            //var t_max_1 = (from r in _listeRelevés select r.TemperatureMax).Max();
            //ReleveTempMax = (from r in _listeRelevés select r.TemperatureMax).Max();
            ReleveTempMax = _listeRelevés.OrderBy(r => r.TemperatureMax).LastOrDefault();
            //ReleveTempMax =  _listeRelevés.Where(r => r.TemperatureMax == t_max_1).FirstOrDefault();

            EnsoleillementMoyenJuillet = (from r in _listeRelevés
                                          where r.Mois.Month == 7
                                          select r.Ensoleil
                                         ).Average();

            //_listeRelevés.Where(r => r.TemperatureMax > _listeRelevés.Average(r2 => r2.TemperatureMax)).Count();
            var t_max = (from r in _listeRelevés
                         select r.TemperatureMax).Average();
            NbMoisChauds = _listeRelevés.Where(r => r.TemperatureMax >= t_max).Count();


            var listePrecipAnnée = _listeRelevés.OrderBy(r => r.Mois).GroupBy(r => r.Mois.Year);
            PrécipitationsMoyennesParAnnée = new Dictionary<int, double>();
            foreach (var item in listePrecipAnnée)
            {
                PrécipitationsMoyennesParAnnée.Add(item.Key, item.Average(r => r.Précipitation));
            }
        }

        public double GetPrécipitationsAnnée(int année)
        {
            double sum = 0;
            //sum = (from r in _listeRelevés
            //           //where r.Mois.ToString("yyyy")==année.ToString("yyyy") 
            //       where r.Mois.Year == année
            //       select r.Précipitation).Sum();
            sum = _listeRelevés.Where(r => r.Mois.Year == année).Sum(r => r.Précipitation);
            return sum;
        }
    }
}
