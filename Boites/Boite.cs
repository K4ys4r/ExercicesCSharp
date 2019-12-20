using System;
using System.Collections.Generic;
using System.Text;

namespace Boites
{

    public enum Couleurs
    {
        Blanc,
        Bleu,
        Vert,
        Jaune,
        Orange,
        Rouge,
        Marron
    }
    public enum Matières
    {
        Carton,
        Plastique,
        Bois,
        Métal
    }
    class Boite
    {

        private Etiquette _etiquetteDest; 
        private Etiquette _etiquetteFragile;

        public static int Compteur{get; private set;}
        //private static int _compteur = 0;
        //public static int Compteur
        //{
        //    get { return _compteur; }
        //}

        private double _largeur;
        private double _hauteur;
        private Couleurs _couleur;
        private Matières _matière = Matières.Carton;

        //////
        //Implantation Détaillé
        private double _longueur;
        public double Longueur
        {
            get { return _longueur; }
        }
        //Implantation automatique
        //public double Longueur { get; } = 30;
        //////

        public double Largeur
        {
            get { return _largeur; }
        }
        public double Hauteur
        {
            get { return _hauteur; }
        }

        public Couleurs Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public Matières Matière
        {
            get { return _matière; }
        }

        public double Volume
        {
            get { return _largeur * _longueur * _hauteur; }
        }

        public Boite(double longueur, double largeur, double hauteur)
        {
            _largeur = largeur;
            //Largeur = largeur; cela ne marche pas car on a une implantation detaillée, il faut une impantation automatisée.
            _longueur = longueur;
            _hauteur = hauteur;
            Compteur++;
            //_compteur++;
        }
        public Boite(double longueur, double largeur, double hauteur, Matières mat) :
            this(longueur, largeur, hauteur)
        {
            _matière = mat;
        }

        public void Etiqueter(string destinateur)
        {
            _etiquetteDest = new Etiquette();
            string _destinateur = destinateur;
            _etiquetteDest.Couleur = Couleurs.Blanc;
            _etiquetteDest.Format = Formats.L;
            _etiquetteDest.Text = destinateur;
        }

        public void Etiqueter(string destinateur, bool fragile)
        {
            Etiqueter(destinateur);
            bool _fragile = fragile;

            if (fragile)
            {
                _etiquetteFragile.Couleur = Couleurs.Rouge;
                _etiquetteFragile.Format = Formats.S;
                _etiquetteFragile.Text = "FRAGILE";

            }

        }
        public void Etiqueter(string destinateur, bool fragile,Etiquette etiqFra,Etiquette etiqDes)
        {
            Etiqueter(destinateur);
            _etiquetteDest = etiqDes;
            bool _fragile = fragile;
            if (fragile)
            {
                _etiquetteFragile = etiqFra;
            }

        }



        public bool Compare(Boite boite1)
        {
            if (this.Largeur == boite1.Largeur &&
                this.Longueur == boite1.Longueur &&
                this.Hauteur == boite1.Hauteur &&
                this.Matière == boite1.Matière)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Compare(Boite b1, Boite b2)
        {

            return (b2.Largeur == b1.Largeur &&
                    b2.Longueur == b1.Longueur &&
                    b2.Hauteur == b1.Hauteur &&
                    b2.Matière == b1.Matière);
        }




    }
}
