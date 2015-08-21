using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    class Jeu
    {
        private List<Joueur> listeJoueurs;
        private int nbJoueurs = 2;
        private bool deuxJoueurs; // true = 2 joueurs, false = +
        private bool beigeOuGris; //beige = true, gris = false
        private bool dernierTour; // true = dernier tour


        public Jeu()
        {
            this.listeJoueurs = new List<Joueur>();
        }

        public void AjouterJoueur(Joueur joueur)
        {
            listeJoueurs.Add(joueur);
        }

        public int NbJoueurs

        {
            set { this.nbJoueurs = value; }
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
