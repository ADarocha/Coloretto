using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    class Joueur
    {

        private string nom;
        private int score;
        private List<string> main;

        public Joueur(string nomJoueur, string couleurJoueur)
        {
            this.nom = nomJoueur;
            this.score = 0;
            this.main = new List<string>{couleurJoueur};

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
    }
}
