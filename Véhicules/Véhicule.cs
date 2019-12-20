using System;
using System.Collections.Generic;
using System.Text;

namespace Véhicules
{
    public enum Energies
    {
        Aucune, Essence, Gazole, GPL, Electrique
    }
    class Véhicule:IComparable<Véhicule>
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energie { get; }
        public double Prix { get; set; }

        public Véhicule(string nom,double p)
        {
            Nom = nom;
            Prix = p;
        }
        public Véhicule(string nom, int nbR, Energies energie)
        {
            Nom = nom;
            NbRoues = nbR;
            Energie = energie;
        }

        public override string ToString()
        {
            return $"Véhicule {Nom} roule sur {NbRoues} roues et à l’énergie {Energie} ";
        }

        public virtual string Description { get { return $"Véhicule { Nom} roule sur { NbRoues} roues et à l’énergie { Energie} "; } }


        int IComparable<Véhicule>.CompareTo(Véhicule v)
        {
            if (this.Prix > v.Prix) return 1;
            else if (this.Prix < v.Prix) return -1;
            else return 0;
        }
    }

    class Voiture : Véhicule
    {
        public Voiture(string nom,double p):base(nom,p)
        {

        }
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }

        public override string Description => "Je suis une Voiture\r\n" + base.Description;
        public override string ToString()
        {
            return "Je suis une voiture\r\n" + base.ToString();
        }


    }
    class Moto : Véhicule
    {
        public Moto(string nom,double p):base(nom,p)
        {

        }
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }
        public override string Description => "Je suis une Moto\n" + base.Description;

    }
}
