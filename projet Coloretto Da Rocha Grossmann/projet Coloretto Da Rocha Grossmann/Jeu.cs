using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    class Jeu
    {
        private List<Joueur> listeJoueurs;
        private bool deuxJoueurs;
        private bool beigeOuGris;
        private bool dernierTour;


        public Jeu()
        {
            this.listeJoueurs = new List<Joueur>();


        }

        private void ajouterJoueur(Joueur joueur)
        {
            listeJoueurs.Add(joueur);
        }

        public int NbJoueurs

        {
            get { return this.listeJoueurs.Count(); }
        }

        public bool DeuxJoueurs
        {
            set { this.deuxJoueurs = value; }
            get { return this.deuxJoueurs; }
        }

        public bool TypeScore
        {
            set { this.beigeOuGris = value; }
            get { return this.beigeOuGris; }
        }

        public bool DernierTour
        {
            set { this.dernierTour = value; }
            get { return this.dernierTour; }
        }

    }
}
