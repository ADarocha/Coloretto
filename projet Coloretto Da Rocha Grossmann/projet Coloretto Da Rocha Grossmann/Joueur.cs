using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    //passage de la classe en public (si rien, une classe est considérée comme private de base) pour pouvoir accèder aux méthodes dans les autres classes et Form
    public class Joueur
    {

        private string nom;
        private int score;
        private string couleurDepart;

        public Joueur(string nomJoueur, string couleur)
        {
            this.nom = nomJoueur;
            this.score = 0;
            this.couleurDepart = couleur;

        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public string CouleurDepart
        {
            get { return this.couleurDepart; }
            set { this.couleurDepart = value; }
        }

    }
}
