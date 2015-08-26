using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    public partial class Principal : Form
    {

        Jeu coloretto; //initialisation d'un objet de la classe Jeu

        /// <summary>
        /// Constructeur du Form avec passage en paramètre d'un objet de la classe Jeu du Form précédent
        /// </summary>
        /// <param name="coloretto">Objet de la classe Jeu du Form précédent</param>
        /// 

        public Principal(Jeu coloretto)
        {
            InitializeComponent(); //création du Form
            this.coloretto = new Jeu(coloretto.ListeJoueurs); //instanciation d'un objet de la classe Jeu avec les paramètres issu de l'objet du Form précédent

        }

        // variables

        bool tourJ1;
        bool tourJ2;
        bool tourJ3;
        bool tourJ4;
        bool tourJ5;
        int manche;
        List<int> cartesBleu = new List<int> {0,0,0,0,0};
        List<int> cartesJaune = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesMarron = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesRouge = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesVert = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesViolet = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesOrange = new List<int> { 0, 0, 0, 0, 0 };
        


        private void Principal_Load(object sender, EventArgs e)
        {
            List<string> paquetCartes = coloretto.PaquetCartes; //recuperation du paquet de carte
            //melanger les cartes


            lbTourJoueur.Text = coloretto.ListeJoueurs[0].Nom; //le joueur 1 est le premier à jouer
            tourJ1 = true; //tour du J1
            tourJ2 = false; //tour du J2
            gbJ1.Text = coloretto.ListeJoueurs[0].Nom; // nom du J1
            gbJ2.Text = coloretto.ListeJoueurs[1].Nom; // nom du J2
            switch (coloretto.ListeJoueurs[0].CouleurDepart) //Assigne la carte de départ du joueur 1 à sa main
            {
                case "bleu":
                    cartesBleu[0]++;
                    break;
                case "rouge":
                    cartesRouge[0]++;
                    break;
                case "jaune":
                    cartesJaune[0]++;
                    break;
                case "marron":
                    cartesMarron[0]++;
                    break;
                case "orange":
                    cartesOrange[0]++;
                    break;
                case "vert":
                    cartesVert[0]++;
                    break;
                case "violet":
                    cartesViolet[0]++;
                    break;
            }
            switch (coloretto.ListeJoueurs[1].CouleurDepart) //il en va de même pour le J2
            {
                case "bleu":
                    cartesBleu[1]++;
                    break;
                case "rouge":
                    cartesRouge[1]++;
                    break;
                case "jaune":
                    cartesJaune[1]++;
                    break;
                case "marron":
                    cartesMarron[1]++;
                    break;
                case "orange":
                    cartesOrange[1]++;
                    break;
                case "vert":
                    cartesVert[1]++;
                    break;
                case "violet":
                    cartesViolet[1]++;
                    break;
            }

            if (coloretto.NbJoueurs > 2)
            {
                tourJ3 = false;
                gbJ3.Visible = true;
                gbJ3.Text = coloretto.ListeJoueurs[2].Nom;

                switch (coloretto.ListeJoueurs[2].CouleurDepart) //definition de la carte de départ dans la main de J3
                {
                    case "bleu":
                        cartesBleu[2]++;
                        break;
                    case "rouge":
                        cartesRouge[2]++;
                        break;
                    case "jaune":
                        cartesJaune[2]++;
                        break;
                    case "marron":
                        cartesMarron[2]++;
                        break;
                    case "orange":
                        cartesOrange[2]++;
                        break;
                    case "vert":
                        cartesVert[2]++;
                        break;
                    case "violet":
                        cartesViolet[2]++;
                        break;
                }
                
                if (coloretto.NbJoueurs > 3)
                {
                    tourJ4 = false;
                    gbJ4.Visible = true;
                    gbJ4.Text = coloretto.ListeJoueurs[3].Nom;

                    switch (coloretto.ListeJoueurs[3].CouleurDepart)//definition de la carte de départ dans la main de J4
                    {
                        case "bleu":
                            cartesBleu[3]++;
                            break;
                        case "rouge":
                            cartesRouge[3]++;
                            break;
                        case "jaune":
                            cartesJaune[3]++;
                            break;
                        case "marron":
                            cartesMarron[3]++;
                            break;
                        case "orange":
                            cartesOrange[3]++;
                            break;
                        case "vert":
                            cartesVert[3]++;
                            break;
                        case "violet":
                            cartesViolet[3]++;
                            break;
                    }
                }
                if (coloretto.NbJoueurs == 5)
                {
                    tourJ5 = false;
                    gbJ5.Visible = true;
                    gbJ5.Text = coloretto.ListeJoueurs[4].Nom;

                    switch (coloretto.ListeJoueurs[4].CouleurDepart)//definition de la carte de départ dans la main de J5
                    {
                        case "bleu":
                            cartesBleu[4]++;
                            break;
                        case "rouge":
                            cartesRouge[4]++;
                            break;
                        case "jaune":
                            cartesJaune[4]++;
                            break;
                        case "marron":
                            cartesMarron[4]++;
                            break;
                        case "orange":
                            cartesOrange[4]++;
                            break;
                        case "vert":
                            cartesVert[4]++;
                            break;
                        case "violet":
                            cartesViolet[4]++;
                            break;
                    }
                }
            }
            manche = 1; //definition du premier tour
            lbNoTour.Text = manche.ToString(); // Tour 1
            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer."; //nom du premier joueur à jouer.
            btPioche.Text = coloretto.PaquetCartes.Count().ToString(); //nombre de carte sur le bouton de la pioche
            actualiserVosCartes(0);
            resumeJoueurs();

        }

        private void btTourSuivant_Click(object sender, EventArgs e)
        {
            //On verifie Quel joueur vient de cliquer sur Tour suivant. Puis, en fonction du nombre de joueurs, on passe au joueur suivant, où on termine la manche et reviens au premier joueur
            if (tourJ1 == true)
            {
                tourJ1 = false;
                tourJ2 = true;
                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom + " de jouer.";
                actualiserVosCartes(1);
                resumeJoueurs();
            }
            else
            {
                if (tourJ2 == true)
                {
                    if (coloretto.NbJoueurs > 2)
                    {
                        tourJ2 = false;
                        tourJ3 = true;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom + " de jouer.";
                        actualiserVosCartes(2);
                        resumeJoueurs();
                    }
                    else
                    {
                        tourJ2 = false;
                        tourJ1 = true;
                        manche++;
                        lbNoTour.Text = manche.ToString();
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer.";
                        actualiserVosCartes(0);
                        resumeJoueurs();
                    } 
                }
                    else
                    {
                        if (tourJ3 == true)
                        {
                            if (coloretto.NbJoueurs > 3)
                            {
                                tourJ3 = false;
                                tourJ4 = true;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom + " de jouer.";
                                actualiserVosCartes(3);
                                resumeJoueurs();
                            }
                            else
                            {
                                tourJ3 = false;
                                tourJ1 = true;
                                manche++;
                                lbNoTour.Text = manche.ToString();
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer.";
                                actualiserVosCartes(0);
                                resumeJoueurs();
                            }
                        }
                        else
                        {
                            if (tourJ4 == true)
                            {
                                if (coloretto.NbJoueurs == 5)
                                {
                                    tourJ4 = false;
                                    tourJ5 = true;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[4].Nom + " de jouer.";
                                    actualiserVosCartes(4);
                                    resumeJoueurs();
                                }
                                else
                                {
                                    tourJ4 = false;
                                    tourJ1 = true;
                                    manche++;
                                    lbNoTour.Text = manche.ToString();
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer.";
                                    actualiserVosCartes(0);
                                    resumeJoueurs();
                                }
                            }
                            else 
                            {
                                if (tourJ5 == true)
                                {
                                    tourJ5 = false;
                                    tourJ1 = true;
                                    manche++;
                                    lbNoTour.Text = manche.ToString();
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer.";
                                    actualiserVosCartes(0);
                                    resumeJoueurs();
                                }
                            }
                        }
                }
            }


        }
        private void resumeJoueurs()
        {
            //actualise la liste des cartes des joueurs dans la groupbox en haut à gauche " Joueurs "
            lbCBleuJ1.Text = cartesBleu[0].ToString(); lbCJauneJ1.Text = cartesJaune[0].ToString(); lbCRougeJ1.Text = cartesRouge[0].ToString(); lbCMarronJ1.Text = cartesMarron[0].ToString(); lbCOrangeJ1.Text = cartesOrange[0].ToString(); lbCVertJ1.Text = cartesVert[0].ToString(); lbCVioletJ1.Text = cartesViolet[0].ToString();
            lbCBleuJ2.Text = cartesBleu[1].ToString(); lbCJauneJ2.Text = cartesJaune[1].ToString(); lbCRougeJ2.Text = cartesRouge[1].ToString(); lbCMarronJ2.Text = cartesMarron[1].ToString(); lbCOrangeJ2.Text = cartesOrange[1].ToString(); lbCVertJ2.Text = cartesVert[1].ToString(); lbCVioletJ2.Text = cartesViolet[1].ToString();
            if (coloretto.NbJoueurs > 2)
                lbCBleuJ3.Text = cartesBleu[2].ToString(); lbCJauneJ3.Text = cartesJaune[2].ToString(); lbCRougeJ3.Text = cartesRouge[2].ToString(); lbCMarronJ3.Text = cartesMarron[2].ToString(); lbCOrangeJ3.Text = cartesOrange[2].ToString(); lbCVertJ3.Text = cartesVert[2].ToString(); lbCVioletJ3.Text = cartesViolet[2].ToString();
            if (coloretto.NbJoueurs > 3)
                lbCBleuJ4.Text = cartesBleu[3].ToString(); lbCJauneJ4.Text = cartesJaune[3].ToString(); lbCRougeJ4.Text = cartesRouge[3].ToString(); lbCMarronJ4.Text = cartesMarron[3].ToString(); lbCOrangeJ4.Text = cartesOrange[3].ToString(); lbCVertJ4.Text = cartesVert[3].ToString(); lbCVioletJ4.Text = cartesViolet[3].ToString();
            if (coloretto.NbJoueurs == 5)
                lbCBleuJ5.Text = cartesBleu[4].ToString(); lbCJauneJ5.Text = cartesJaune[4].ToString(); lbCRougeJ5.Text = cartesRouge[4].ToString(); lbCMarronJ5.Text = cartesMarron[4].ToString(); lbCOrangeJ5.Text = cartesOrange[4].ToString(); lbCVertJ5.Text = cartesVert[4].ToString(); lbCVioletJ5.Text = cartesViolet[4].ToString();
        }

        private void actualiserVosCartes(int joueur)
        {
            //actualise le nombre de carte du joueur entrain de jouer.
            lbNbBleu.Text = cartesBleu[joueur].ToString(); lbNbJaune.Text = cartesJaune[joueur].ToString(); lbNbRouge.Text = cartesRouge[joueur].ToString(); lbNbMarron.Text = cartesMarron[joueur].ToString(); lbNbOrange.Text = cartesOrange[joueur].ToString(); lbNbVert.Text = cartesVert[joueur].ToString(); lbNbViolet.Text = cartesViolet[joueur].ToString();
        }

    }
}
