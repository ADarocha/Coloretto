using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    //passage de la classe en public (si rien, une classe est considérée comme private de base) pour pouvoir accèder aux méthodes dans les autres classes et Form
    public class Jeu
    {
        private List<Joueur> listeJoueurs;
        private int nbJoueurs = 2;
        private bool deuxJoueurs; // true = 2 joueurs, false = +
        private bool beigeOuGris; //beige = true, gris = false
        private bool dernierTour; // true = dernier tour

        /// <summary>
        /// Constructeur de base de la classe
        /// </summary>
        public Jeu()
        {
            this.listeJoueurs = new List<Joueur>();
        }

        /// <summary>
        /// Constructeur surchargé pour génèrer la liste des joueurs
        /// </summary>
        /// <param name="listeJoueurs">Liste d'objets de la classe Joueur</param>
        public Jeu(List<Joueur> listeJoueurs)
        {
            this.listeJoueurs = new List<Joueur>(listeJoueurs);
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

        public List<Joueur> ListeJoueurs
        {
            get { return this.listeJoueurs; }
        }
    }
}
