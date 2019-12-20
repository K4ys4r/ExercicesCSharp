using System;
using System.Collections.Generic;
using System.Text;

namespace Heritages
{
    public interface IRenouvelable
    {
        DateTime DateRenouvellemnet { get; }
        void Renouveler(DateTime date);
    }
    class MoyenDePaiment:IRenouvelable
    {
        public long NuméroCompte { get; }
        public string NomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }

        public DateTime DateRenouvellemnet { get; set; }


        // public DateTime DateRenouvellement { get; set; }

        public MoyenDePaiment(long numéroCompte)
        {
            NuméroCompte = numéroCompte;
        }
        /// <summary>
        /// cela dit que la fonction pourrait être redefini
        /// </summary>
        /// <param name="virtual"></param>
        //public virtual void Renouveler(DateTime date)
        //{
        //   DateRenouvellement = date;
        //}
        public override string ToString()
        {
            return $"Moyen de paiement du compte {NuméroCompte} de {NomTitulaire}";
        }

        public void Renouveler(DateTime date)
        {
            DateRenouvellemnet = date;
        }
    }

    class Carte:MoyenDePaiment
    {
        public int Numéro { get; }
        public DateTime DAteExpiration { get; set; }
        public int CodeSecret { get; set; }
        public int Cryptogramme { get; set; }
        /// <summary>
        /// base(parametre il va appeler le constructeur de l'ancetre et lui passer le parametre)
        /// </summary>
        public Carte(long numCompte,int numCarte):base(numCompte) 
        {
            Numéro = numCarte;
        }

        public void Renouveler(DateTime date)
        {
            base.Renouveler(date);
            DAteExpiration = DAteExpiration.AddYears(2);
        }

        public override string ToString()
        {
            return base.ToString() + $" ,Carte N° : {Numéro}";
        }

    }

    class Chequier:MoyenDePaiment
    {
        public string Adresse { get; set; }
        public int NumeroPremierChequier { get; set; }
        public int NbChequiers { get; set; }

        public Chequier(long numCompte):base(numCompte)
        {

        }
        public  void Renouveler(DateTime date)
        {
            base.Renouveler(date);
            NumeroPremierChequier += NbChequiers; 
        }



    }
}
