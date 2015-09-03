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

        bool tourJ1; bool tourJ2; bool tourJ3; bool tourJ4; bool tourJ5; bool pioche; int manche;
        bool derniereManche; bool J1aRamasse; bool J2aRamasse; bool J3aRamasse; bool J4aRamasse; bool J5aRamasse; bool tousARamasse; string dernierAJouer;
        int scoreJ1 = 0; int scoreJ2 = 0; int scoreJ5 = 0; int scoreJ3 = 0; int scoreJ4 = 0; 

        List<int> cartesBleu = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesJaune = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesMarron = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesRouge = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesVert = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesViolet = new List<int> { 0, 0, 0, 0, 0 };
        List<int> cartesOrange = new List<int> { 0, 0, 0, 0, 0 };

        List<int> scoreJoueurs = new List<int> { 0, 0, 0, 0, 0 };
        Recap recap;
        


        private void Principal_Load(object sender, EventArgs e)
        {
            List<string> paquetCartes = coloretto.PaquetCartes; //recuperation du paquet de carte

            paquetCartes = ShufflePaquet(paquetCartes);//melanger les cartes

            J1aRamasse = false; J2aRamasse = false; J3aRamasse = true; J4aRamasse = true; J5aRamasse = true; //les deux premiers joueurs sont considérés comme pouvant jouer. On ajoute les autres joueurs plus tard en fonction du nombre de joueurs

            derniereManche = false; // le tour ne sera pas le dernier
            pioche = true; //permet au premier joueur de piocher.
            lbTourJoueur.Text = coloretto.ListeJoueurs[0].Nom; //le joueur 1 est le premier à jouer
            tourJ1 = true; //tour du J1
            tourJ2 = false; //tour du J2
            gbJ1.Text = coloretto.ListeJoueurs[0].Nom; gbJ2.Text = coloretto.ListeJoueurs[1].Nom; // nom du J1 et J2
            cacherPlacerAfficherRamasser(false, false); //cache tous les boutons

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
                J3aRamasse = false; tourJ3 = false; gbJ3.Visible = true; //Active le joueur 3 et la rangée n°3
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
                    J4aRamasse = false; tourJ4 = false; gbJ4.Visible = true; //active J4 et rangée 4
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
                    J5aRamasse = false; tourJ5 = false; gbJ5.Visible = true; //active J5 et la rangée 5
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
            switch (coloretto.NbJoueurs) //cache des rangées de carte en fonction du nombre de joueurs
            {
                case 2 :
                    gbRangee3.Visible = false; gbRangee4.Visible = false; gbRangee5.Visible = false;
                    break;
                case 3:
                    gbRangee4.Visible = false; gbRangee5.Visible = false;
                    break;
                case 4:
                    gbRangee5.Visible = false;
                    break;
                case 5:
                    //rien
                    break;
            }
            manche = 1; //definition du premier tour
            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom + " de jouer."; //nom du premier joueur à jouer.
            lbNbCartes.Text = coloretto.PaquetCartes.Count().ToString(); //nombre de carte sur le bouton de la pioche
            actualiserVosCartes(0);
            resumeJoueurs();

        }

        

        private void btPioche_Click(object sender, EventArgs e)
        {

            if (coloretto.PaquetCartes.Count() == 0)
            {
                MessageBox.Show("Il n'y a plus de carte dans la pioche.");
                return;
            }
            cacherPlacerAfficherRamasser(true, false); //cache les boutons ramasser.
            //Si une rangée possède 3 carte, le joueur ne pourra pas placer car le bouton placer ne sera pas disponible
            if (pbR1C3.Image != null)
                btPlacerR1.Visible = false;
            if (pbR2C3.Image != null)
                btPlacerR2.Visible = false;
            if (pbR3C3.Image != null)
                btPlacerR3.Visible = false;
            if (pbR4C3.Image != null)
                btPlacerR4.Visible = false;
            if (pbR5C3.Image != null)
                btPlacerR5.Visible = false;

            if (pioche == true) //Si le joueur peut piocher
            {
                switch (coloretto.PaquetCartes[0]) //on affiche la carte qu'il a piocher sur le bouton de la pioche
                {
                    case "jaune":
                        btPioche.Image = Properties.Resources.carteJaune;
                        break;
                    case "bleu":
                        btPioche.Image = Properties.Resources.carteBleue;
                        break;
                    case "rouge":
                        btPioche.Image = Properties.Resources.carteRouge;
                        break;
                    case "marron":
                        btPioche.Image = Properties.Resources.carteMarron;
                        break;
                    case "orange":
                        btPioche.Image = Properties.Resources.carteOrange;
                        break;
                    case "vert":
                        btPioche.Image = Properties.Resources.carteVert;
                        break;
                    case "violet":
                        btPioche.Image = Properties.Resources.carteViolet;
                        break;
                    case "+2":
                        btPioche.Image = Properties.Resources.cartePlus2;
                        cacherPlacerAfficherRamasser(false, false);
                        if (tourJ1){scoreJ1++;}//on rajoute les deux points au score du joueur qui a piocher.
                        else{if (tourJ2){scoreJ2++;}
                            else{if (tourJ3){scoreJ3++;}
                                else{if (tourJ4){scoreJ4++;}
                                    else{if (tourJ5){scoreJ5++;}}}}}
                        MessageBox.Show("Vous avez piocher une carte ''+2''. Deux points ont été ajoutés à votre score final !"); //on le notifie.
                        btPioche.Image = null;
                        break;
                    case "joker":
                        btPioche.Image = Properties.Resources.carteJoker;
                        cacherPlacerAfficherRamasser(false, false);
                        gbJoker.Visible = true;
                        break;
                }
                pioche = false; //empêche le joueur de piocher deux fois.
                lbNbCartes.Text = coloretto.PaquetCartes.Count().ToString(); //on actualise le nombr de cartes dans la pioche.

                if (coloretto.PaquetCartes[0] == "+2")
                {
                    coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
                    tourSuivant();
                }
            }
            else
            {
                MessageBox.Show("Impossible ! vous avez déjà piocher, ou vous avez ramasser une rangée!"); //sinon on préviens qu'il n'est pas possible de piocher.
            }
        }

        private void btPlacerR1_Click(object sender, EventArgs e)
        {
            placerImage(pbR1C1, pbR1C2, pbR1C3);
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            tourSuivant();
        }

        private void btRamasserR1_Click(object sender, EventArgs e)
        {
            ramasserRangee(pbR1C1, pbR1C2, pbR1C3);
            pbR1C1.Tag = null; pbR1C2.Tag = null; pbR1C3.Tag = null; //reset des tags
            pioche = false;
            if (tourJ1)
            {
                J1aRamasse = true;
                if (J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                    dernierAJouer = "J1"; //determine quel joueur à terminé le tour
            }
            else
            {
                if (tourJ2)
                {
                    J2aRamasse = true;
                    if (J1aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                        dernierAJouer = "J2";
                }

                else
                {
                    if (tourJ3)
                    {
                        J3aRamasse = true;
                        if (J1aRamasse && J2aRamasse && J4aRamasse && J5aRamasse)
                            dernierAJouer = "J3";
                    }
                    else
                    {
                        if (tourJ4)
                        {
                            J4aRamasse = true;
                            if (J2aRamasse && J3aRamasse && J1aRamasse && J5aRamasse)
                                dernierAJouer = "J4";
                        }
                        else
                        {
                            if (tourJ5)
                            {
                                J5aRamasse = true;
                                if (J2aRamasse && J3aRamasse && J4aRamasse && J1aRamasse)
                                    dernierAJouer = "J5";
                            }
                        }
                    }
                }
            }
            gbRangee1.Visible = false; //cache la rangée une fois qu'elle est ramassée
            tourSuivant();
        }

        private void btPlacerR2_Click(object sender, EventArgs e)
        {
            placerImage(pbR2C1, pbR2C2, pbR2C3);
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            tourSuivant();
        }

        private void btRamasserR2_Click(object sender, EventArgs e)
        {
            ramasserRangee(pbR2C1, pbR2C2, pbR2C3);
            pbR2C1.Tag = null; pbR2C2.Tag = null; pbR2C3.Tag = null; //reset des tags
            pioche = false;
            if (tourJ1)
            {
                J1aRamasse = true;
                if (J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                    dernierAJouer = "J1";
            }
            else
            {
                if (tourJ2)
                {
                    J2aRamasse = true;
                    if (J1aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                        dernierAJouer = "J2";
                }

                else
                {
                    if (tourJ3)
                    {
                        J3aRamasse = true;
                        if (J1aRamasse && J2aRamasse && J4aRamasse && J5aRamasse)
                            dernierAJouer = "J3";
                    }
                    else
                    {
                        if (tourJ4)
                        {
                            J4aRamasse = true;
                            if (J2aRamasse && J3aRamasse && J1aRamasse && J5aRamasse)
                                dernierAJouer = "J4";
                        }
                        else
                        {
                            if (tourJ5)
                            {
                                J5aRamasse = true;
                                if (J2aRamasse && J3aRamasse && J4aRamasse && J1aRamasse)
                                    dernierAJouer = "J5";
                            }
                        }
                    }
                }
            }
            gbRangee2.Visible = false;
            tourSuivant();
        }

        private void btPlacerR3_Click(object sender, EventArgs e)
        {
            placerImage(pbR3C1, pbR3C2, pbR3C3);
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            tourSuivant();
        }

        private void btRamasserR3_Click(object sender, EventArgs e)
        {
            ramasserRangee(pbR3C1, pbR3C2, pbR3C3);
            pbR3C1.Tag = null; pbR3C2.Tag = null; pbR3C3.Tag = null; //reset des tags
            pioche = false;
            if (tourJ1)
            {
                J1aRamasse = true;
                if (J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                    dernierAJouer = "J1";
            }
            else
            {
                if (tourJ2)
                {
                    J2aRamasse = true;
                    if (J1aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                        dernierAJouer = "J2";
                }

                else
                {
                    if (tourJ3)
                    {
                        J3aRamasse = true;
                        if (J1aRamasse && J2aRamasse && J4aRamasse && J5aRamasse)
                            dernierAJouer = "J3";
                    }
                    else
                    {
                        if (tourJ4)
                        {
                            J4aRamasse = true;
                            if (J2aRamasse && J3aRamasse && J1aRamasse && J5aRamasse)
                                dernierAJouer = "J4";
                        }
                        else
                        {
                            if (tourJ5)
                            {
                                J5aRamasse = true;
                                if (J2aRamasse && J3aRamasse && J4aRamasse && J1aRamasse)
                                    dernierAJouer = "J5";
                            }
                        }
                    }
                }
            }
            gbRangee3.Visible = false;
            tourSuivant();
        }

        private void btPlacerR4_Click(object sender, EventArgs e)
        {
            placerImage(pbR4C1, pbR4C2, pbR4C3);
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            tourSuivant();
        }

        private void btRamasserR4_Click(object sender, EventArgs e)
        {
            ramasserRangee(pbR4C1, pbR4C2, pbR4C3);
            pbR4C1.Tag = null; pbR4C2.Tag = null; pbR4C3.Tag = null; //reset des tags
            pioche = false;
            if (tourJ1)
            {
                J1aRamasse = true;
                if (J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                    dernierAJouer = "J1";
            }
            else
            {
                if (tourJ2)
                {
                    J2aRamasse = true;
                    if (J1aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                        dernierAJouer = "J2";
                }

                else
                {
                    if (tourJ3)
                    {
                        J3aRamasse = true;
                        if (J1aRamasse && J2aRamasse && J4aRamasse && J5aRamasse)
                            dernierAJouer = "J3";
                    }
                    else
                    {
                        if (tourJ4)
                        {
                            J4aRamasse = true;
                            if (J2aRamasse && J3aRamasse && J1aRamasse && J5aRamasse)
                                dernierAJouer = "J4";
                        }
                        else
                        {
                            if (tourJ5)
                            {
                                J5aRamasse = true;
                                if (J2aRamasse && J3aRamasse && J4aRamasse && J1aRamasse)
                                    dernierAJouer = "J5";
                            }
                        }
                    }
                }
            }
            gbRangee4.Visible = false;
            tourSuivant();
        }


        private void btPlacerR5_Click(object sender, EventArgs e)
        {
            placerImage(pbR5C1, pbR5C2, pbR5C3);
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            tourSuivant();
        }

        private void btRamasserR5_Click(object sender, EventArgs e)
        {
            ramasserRangee(pbR5C1, pbR5C2, pbR5C3);
            pbR5C1.Tag = null; pbR5C2.Tag = null; pbR5C3.Tag = null; //reset des tags
            pioche = false;
            if (tourJ1)
            {
                J1aRamasse = true;
                if (J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                    dernierAJouer = "J1";
            }
            else
            {
                if (tourJ2)
                {
                    J2aRamasse = true;
                    if (J1aRamasse && J3aRamasse && J4aRamasse && J5aRamasse)
                        dernierAJouer = "J2";
                }

                else
                {
                    if (tourJ3)
                    {
                        J3aRamasse = true;
                        if (J1aRamasse && J2aRamasse && J4aRamasse && J5aRamasse)
                            dernierAJouer = "J3";
                    }
                    else
                    {
                        if (tourJ4)
                        {
                            J4aRamasse = true;
                            if (J2aRamasse && J3aRamasse && J1aRamasse && J5aRamasse)
                                dernierAJouer = "J4";
                        }
                        else
                        {
                            if (tourJ5)
                            {
                                J5aRamasse = true;
                                if (J2aRamasse && J3aRamasse && J4aRamasse && J1aRamasse)
                                    dernierAJouer = "J5";
                            }
                        }
                    }
                }
            }
            gbRangee5.Visible = false;
            tourSuivant();
        }



        private void btJokerBleu_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesBleu[0]++; }
            else
            {
                if (tourJ2) { cartesBleu[1]++; }
                else
                {
                    if (tourJ3) { cartesBleu[2]++; }
                    else
                    {
                        if (tourJ4) { cartesBleu[3]++; }
                        else { if (tourJ5) { cartesBleu[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerJaune_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesJaune[0]++; }
            else
            {
                if (tourJ2) { cartesJaune[1]++; }
                else
                {
                    if (tourJ3) { cartesJaune[2]++; }
                    else
                    {
                        if (tourJ4) { cartesJaune[3]++; }
                        else { if (tourJ5) { cartesJaune[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerMarron_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesMarron[0]++; }
            else
            {
                if (tourJ2) { cartesMarron[1]++; }
                else
                {
                    if (tourJ3) { cartesMarron[2]++; }
                    else
                    {
                        if (tourJ4) { cartesMarron[3]++; }
                        else { if (tourJ5) { cartesMarron[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerOrange_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesOrange[0]++; }
            else
            {
                if (tourJ2) { cartesOrange[1]++; }
                else
                {
                    if (tourJ3) { cartesOrange[2]++; }
                    else
                    {
                        if (tourJ4) { cartesOrange[3]++; }
                        else { if (tourJ5) { cartesOrange[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerRouge_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesRouge[0]++; }
            else
            {
                if (tourJ2) { cartesRouge[1]++; }
                else
                {
                    if (tourJ3) { cartesRouge[2]++; }
                    else
                    {
                        if (tourJ4) { cartesRouge[3]++; }
                        else { if (tourJ5) { cartesRouge[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerVert_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesVert[0]++; }
            else
            {
                if (tourJ2) { cartesVert[1]++; }
                else
                {
                    if (tourJ3) { cartesVert[2]++; }
                    else
                    {
                        if (tourJ4) { cartesVert[3]++; }
                        else { if (tourJ5) { cartesVert[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

        private void btJokerViolet_Click(object sender, EventArgs e)
        {
            if (tourJ1) { cartesViolet[0]++; }
            else
            {
                if (tourJ2) { cartesViolet[1]++; }
                else
                {
                    if (tourJ3) { cartesViolet[2]++; }
                    else
                    {
                        if (tourJ4) { cartesViolet[3]++; }
                        else { if (tourJ5) { cartesViolet[4]++; } }
                    }
                }
            }
            btPioche.Image = null; //retire l'image de la pioche
            coloretto.PaquetCartes.RemoveAt(0); //on supprime la carte de la pioche
            gbJoker.Visible = false;
            tourSuivant();
        }

























        /// <summary>
        /// Méthodes
        /// </summary>























        private void tourSuivant()
        {


            if (J1aRamasse && J2aRamasse && J3aRamasse && J4aRamasse && J5aRamasse) //si tous le monde a ramasser dans le tour
                tousARamasse = true;

            if (tousARamasse && derniereManche)
            {
                MessageBox.Show("Partie terminée.");
                scoreJoueurs[0] = scoreJ1; //ajout des scores à la liste
                scoreJoueurs[1] = scoreJ2;
                scoreJoueurs[2] = scoreJ3;
                scoreJoueurs[3] = scoreJ4;
                scoreJoueurs[4] = scoreJ5;
                recap = new Recap(coloretto, cartesBleu, cartesJaune, cartesMarron, cartesRouge, cartesVert, cartesViolet, cartesOrange, scoreJoueurs);
                recap.Show();
                return;
            }

            if(tousARamasse) //si tous le monde a ramasser
            {
                switch (coloretto.NbJoueurs) // en fonction du nombre de joueurs, on fais ré-apparaître les rangées de cartes.
                {
                    case 1:
                        break;
                    case 2:
                        gbRangee1.Visible = true; gbRangee2.Visible = true;
                        break;
                    case 3:
                        gbRangee1.Visible = true; gbRangee2.Visible = true; gbRangee3.Visible = true;
                        break;
                    case 4 :
                        gbRangee1.Visible = true; gbRangee2.Visible = true; gbRangee3.Visible = true; gbRangee4.Visible = true;
                        break;
                    case 5:
                        gbRangee1.Visible = true; gbRangee2.Visible = true; gbRangee3.Visible = true; gbRangee4.Visible = true; gbRangee5.Visible = true; 
                        break;
                }
            }




            cacherPlacerAfficherRamasser(false, true); //on cache les boutons ramasser.
            if (pbR1C1.Image == null) //rend impossible de ramasser une rangée vide.
                btRamasserR1.Visible = false;
            if (pbR2C1.Image == null)
                btRamasserR2.Visible = false;
            if (pbR3C1.Image == null)
                btRamasserR3.Visible = false;
            if (pbR4C1.Image == null)
                btRamasserR4.Visible = false;
            if (pbR5C1.Image == null)
                btRamasserR5.Visible = false;

            pioche = true; //autorise la pioche au joueur.


            if (tousARamasse) // si tous le monde a ramasser
            {
                switch (dernierAJouer) // en fonction du dernier joueur à avoir ramasser dans le tour, celui-ci relance le tour suivant.
                {
                    case "J1":
                        tourJ1 = true; tourJ2 = false; tourJ3 = false; tourJ4 = false; tourJ5 = false;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                        actualiserVosCartes(0);
                        resumeJoueurs();
                        break;
                    case "J2":
                        tourJ2 = true; tourJ1 = false; tourJ3 = false; tourJ4 = false; tourJ5 = false;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                        actualiserVosCartes(1);
                        resumeJoueurs();
                        break;
                    case "J3":
                        tourJ3 = true; tourJ2 = false; tourJ1 = false; tourJ4 = false; tourJ5 = false;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                        actualiserVosCartes(2);
                        resumeJoueurs();
                        break;
                    case "J4":
                        tourJ4 = true; tourJ2 = false; tourJ3 = false; tourJ1 = false; tourJ5 = false;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom;
                        actualiserVosCartes(3);
                        resumeJoueurs();
                        break;
                    case "J5":
                        tourJ5 = true; tourJ2 = false; tourJ3 = false; tourJ4 = false; tourJ1 = false;
                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[4].Nom;
                        actualiserVosCartes(4);
                        resumeJoueurs();
                        break;
                }
            }
            else //sinon
            {



                switch (coloretto.NbJoueurs)
                {
                    case 1:
                        break;
                    case 2:
                        if (tourJ1)
                        {
                            tourJ1 = false;
                            tourJ2 = true;
                            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                            actualiserVosCartes(1);
                            resumeJoueurs();
                        }
                        else
                        {
                            if (tourJ2)
                            {
                                tourJ1 = true;
                                tourJ2 = false;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                actualiserVosCartes(0);
                                resumeJoueurs();
                            }
                        }
                        break;
                    case 3:
                        if (tourJ1)
                        {
                            if (J2aRamasse)
                            {
                                tourJ1 = false;
                                tourJ3 = true;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                actualiserVosCartes(2);
                                resumeJoueurs();

                            }
                            else
                            {
                                tourJ1 = false;
                                tourJ2 = true;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                actualiserVosCartes(1);
                                resumeJoueurs();
                            }
                        }
                        else
                        {
                            if (tourJ2)
                            {
                                if (J3aRamasse)
                                {
                                    tourJ1 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                    actualiserVosCartes(0);
                                    resumeJoueurs();
                                }
                                else
                                {
                                    tourJ3 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                    actualiserVosCartes(2);
                                    resumeJoueurs();
                                }
                            }
                            else
                            {
                                if (tourJ3)
                                {
                                    if (J1aRamasse)
                                    {
                                        tourJ2 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                        actualiserVosCartes(1);
                                        resumeJoueurs();
                                    }
                                    else
                                    {

                                        tourJ1 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                        actualiserVosCartes(0);
                                        resumeJoueurs();
                                    }
                                }
                            }
                        }
                        break;
                    case 4 :
                        if (tourJ1)
                        {
                            if (J2aRamasse)
                            {
                                tourJ3 = true;
                                tourJ1 = false;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                actualiserVosCartes(2);
                                resumeJoueurs();
                            }
                            else
                            {
                                tourJ1 = false;
                                tourJ2 = true;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                actualiserVosCartes(1);
                                resumeJoueurs();
                            }
                        }
                        else
                        {
                            if (tourJ2)
                            {
                                if (J3aRamasse)
                                {
                                    tourJ4 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom;
                                    actualiserVosCartes(3);
                                    resumeJoueurs();
                                }
                                else
                                {

                                    tourJ3 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                    actualiserVosCartes(2);
                                    resumeJoueurs();
                                }
                            }
                            else
                            {
                                if (tourJ3)
                                {
                                    if (J4aRamasse)
                                    {
                                        tourJ1 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                        actualiserVosCartes(0);
                                        resumeJoueurs();
                                    }
                                    else
                                    {
                                        tourJ4 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom;
                                        actualiserVosCartes(3);
                                        resumeJoueurs();
                                    }
                                }
                                else
                                {
                                    if (tourJ4)
                                    {
                                        if (J1aRamasse)
                                        {
                                            tourJ2 = true;
                                            tourJ4 = false;
                                            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                            actualiserVosCartes(1);
                                            resumeJoueurs();
                                        }
                                        else
                                        {
                                            tourJ1 = true;
                                            tourJ4 = false;
                                            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                            actualiserVosCartes(0);
                                            resumeJoueurs();
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        if (tourJ1)
                        {
                            if (J2aRamasse)
                            {
                                tourJ3 = true;
                                tourJ1 = false;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                actualiserVosCartes(2);
                                resumeJoueurs();
                            }
                            else
                            {
                                tourJ1 = false;
                                tourJ2 = true;
                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                actualiserVosCartes(1);
                                resumeJoueurs();
                            }
                        }
                        else
                        {
                            if (tourJ2)
                            {
                                if (J3aRamasse)
                                {
                                    tourJ4 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom;
                                    actualiserVosCartes(3);
                                    resumeJoueurs();
                                }
                                else
                                {
                                    tourJ3 = true;
                                    tourJ2 = false;
                                    lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[2].Nom;
                                    actualiserVosCartes(2);
                                    resumeJoueurs();
                                }
                            }
                            else
                            {
                                if (tourJ3)
                                {
                                    if (J4aRamasse)
                                    {
                                        tourJ5 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[4].Nom;
                                        actualiserVosCartes(4);
                                        resumeJoueurs();
                                    }
                                    else
                                    {
                                        tourJ4 = true;
                                        tourJ3 = false;
                                        lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[3].Nom;
                                        actualiserVosCartes(3);
                                        resumeJoueurs();
                                    }
                                }
                                else
                                {
                                    if (tourJ4)
                                    {
                                        if (J5aRamasse)
                                        {
                                            tourJ1 = true;
                                            tourJ4 = false;
                                            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                            actualiserVosCartes(0);
                                            resumeJoueurs();
                                        }
                                        else
                                        {
                                            tourJ5 = true;
                                            tourJ4 = false;
                                            lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[4].Nom;
                                            actualiserVosCartes(0);
                                            resumeJoueurs();
                                        }
                                    }
                                    else
                                    {
                                        if (tourJ5)
                                        {
                                            if (J1aRamasse)
                                            {
                                                tourJ2 = true;
                                                tourJ5 = false;
                                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[1].Nom;
                                                actualiserVosCartes(1);
                                                resumeJoueurs();
                                            }
                                            else
                                            {
                                                tourJ1 = true;
                                                tourJ5 = false;
                                                lbTourJoueur.Text = "C'est au tour de " + coloretto.ListeJoueurs[0].Nom;
                                                actualiserVosCartes(0);
                                                resumeJoueurs();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;      
                }

            }
            if (coloretto.PaquetCartes.Count() == 15 && derniereManche == false) //si c'est la dernière manche, on préviens les joueurs
            {
                MessageBox.Show("Dernière manche !");
                derniereManche = true;
            }

            if (tousARamasse) //si le tour es terminé, on remet à zéro les valeurs
            {
                J1aRamasse = false; J2aRamasse = false; J3aRamasse = false; J4aRamasse = false; J5aRamasse = false; tousARamasse = false; dernierAJouer = "";
                manche++;
            }

            if (tourJ1 && J1aRamasse)
            {
                tourSuivant();
            }
            else 
            {
                if (tourJ2 && J2aRamasse)
                {
                    tourSuivant();
                }
                else if (coloretto.NbJoueurs > 2)
                {
                    if (tourJ3 && J3aRamasse)
                    {
                        tourSuivant();
                    }
                    else if (coloretto.NbJoueurs > 3)
                    {
                        if (tourJ4 && J4aRamasse)
                        {
                            tourSuivant();
                        }
                        else if (coloretto.NbJoueurs == 5)
                        {
                            if (tourJ5 && J5aRamasse)
                            {
                                tourSuivant();
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


        private void cacherPlacerAfficherRamasser(bool etatPlacer, bool etatRamasser)
        {
            //permet de cacher / afficher les boutons ramasser / placer ici
            btPlacerR1.Visible = etatPlacer; btPlacerR2.Visible = etatPlacer; btPlacerR3.Visible = etatPlacer; btPlacerR4.Visible = etatPlacer; btPlacerR5.Visible = etatPlacer;
            btRamasserR1.Visible = etatRamasser; btRamasserR2.Visible = etatRamasser; btRamasserR3.Visible = etatRamasser; btRamasserR4.Visible = etatRamasser; btRamasserR5.Visible = etatRamasser;
        }

        private void cacherRamasser()
        {
            //peut-être à supprimer, ne sert pas (?)
            btRamasserR1.Visible = false; btRamasserR2.Visible = false; btRamasserR3.Visible = false; btRamasserR4.Visible = false; btRamasserR5.Visible = false;
        }

        private void placerImage(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            //permet de placer une image dans une rangée en fonction du nombre de carte déjà présentent dans la rangée, et selon la carte.
            switch (coloretto.PaquetCartes[0])
            {
                case "jaune":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "jaune"; pb1.Image = Properties.Resources.carteJaune;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "jaune"; pb2.Image = Properties.Resources.carteJaune;
                        }
                        else
                        {
                            pb3.Tag = "jaune"; pb3.Image = Properties.Resources.carteJaune;
                        }
                    }
                    break;
                case "bleu":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "bleu"; pb1.Image = Properties.Resources.carteBleue;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "bleu"; pb2.Image = Properties.Resources.carteBleue;
                        }
                        else
                        {
                            pb3.Tag = "bleu"; pb3.Image = Properties.Resources.carteBleue;
                        }
                    }
                    break;
                case "rouge":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "rouge"; pb1.Image = Properties.Resources.carteRouge;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "rouge"; pb2.Image = Properties.Resources.carteRouge;
                        }
                        else
                        {
                            pb3.Tag = "rouge"; pb3.Image = Properties.Resources.carteRouge;
                        }
                    }
                    break;
                case "marron":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "marron"; pb1.Image = Properties.Resources.carteMarron;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "marron"; pb2.Image = Properties.Resources.carteMarron;
                        }
                        else
                        {
                            pb3.Tag = "marron"; pb3.Image = Properties.Resources.carteMarron;
                        }
                    }
                    break;
                case "orange":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "orange"; pb1.Image = Properties.Resources.carteOrange;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "orange"; pb2.Image = Properties.Resources.carteOrange;
                        }
                        else
                        {
                            pb3.Tag = "orange"; pb3.Image = Properties.Resources.carteOrange;
                        }
                    }
                    break;
                case "vert":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "vert"; pb1.Image = Properties.Resources.carteVert;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "vert"; pb2.Image = Properties.Resources.carteVert;
                        }
                        else
                        {
                            pb3.Tag = "vert";
                            pb3.Image = Properties.Resources.carteVert;
                        }
                    }
                    break;
                case "violet":
                    if (pb1.Image == null)
                    {
                        pb1.Tag = "violet"; pb1.Image = Properties.Resources.carteViolet;
                    }
                    else
                    {
                        if (pb2.Image == null)
                        {
                            pb2.Tag = "violet"; pb2.Image = Properties.Resources.carteViolet;
                        }
                        else
                        {
                            pb3.Tag = "violet"; pb3.Image = Properties.Resources.carteViolet;
                        }
                    }
                    break;
            }
        }

        private void ramasserRangee(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            //verifie qui est entrain de jouer, et ramasse les cartes pour lui.
            if (tourJ1 == true)
            {
                ramasser(pb1, 0); ramasser(pb2, 0); ramasser(pb3, 0);
                pb1.Image = null; pb2.Image = null; pb3.Image = null;
            }
            else
            {
                if (tourJ2 == true)
                {
                    ramasser(pb1, 1); ramasser(pb2, 1); ramasser(pb3, 1);
                    pb1.Image = null; pb2.Image = null; pb3.Image = null;
                }
                else
                {
                    if (tourJ3 == true)
                    {
                        ramasser(pb1, 2); ramasser(pb2, 2); ramasser(pb3, 2);
                        pb1.Image = null; pb2.Image = null; pb3.Image = null;
                    }
                    else
                    {
                        if (tourJ4 == true)
                        {
                            ramasser(pb1, 3); ramasser(pb2, 3); ramasser(pb3, 3);
                            pb1.Image = null; pb2.Image = null; pb3.Image = null;
                        }
                        else
                        {
                            if (tourJ5 == true)
                            {
                                ramasser(pb1, 4); ramasser(pb2, 4); ramasser(pb3, 4);
                                pb1.Image = null; pb2.Image = null; pb3.Image = null;
                            }
                        }
                    }
                }
            }
        }

        private void ramasser(PictureBox pb, int joueur)
        {
            //ramasse une carte
            if (pb.Image != null)
            {
                if (pb.Tag.ToString() == "jaune")
                    cartesJaune[joueur]++;
                if (pb.Tag.ToString() == "bleu")
                    cartesBleu[joueur]++;
                if (pb.Tag.ToString() == "rouge")
                    cartesRouge[joueur]++;
                if (pb.Tag.ToString() == "marron")
                    cartesMarron[joueur]++;
                if (pb.Tag.ToString() == "vert")
                    cartesVert[joueur]++;
                if (pb.Tag.ToString() == "violet")
                    cartesViolet[joueur]++;
                if (pb.Tag.ToString() == "orange")
                    cartesOrange[joueur]++;
            }
        }

        private List<string> ShufflePaquet(List<string> paquetCartes)
        {
            Random rng = new Random(); //on instancie un objet de la classe Random pour pouvoir obtenir un nombre aléatoire
            int n = paquetCartes.Count(); //on récupère le nombre d'éléments dans la liste
            int i;
            for (i = 0; i <= n - 1; i++) //pour i allant de 0 jusqu'au nombre d'éléments dans la liste-1 (pour ne pas dépasser l'index maximale de la liste)
            {
                int k = rng.Next(0, n - 1); //on génère et assigne un nombre aléatoire dont la valeur maximale est l'index maximale que peut contenir la liste
                string valeur = paquetCartes[k]; //on stocke la valeur de l'élément de la liste ayant pour un index le nombre aléatoire
                paquetCartes[k] = paquetCartes[i]; //on assigne à l'élément de la liste d'index aléatoire l'élément de la liste ayant pour index i
                paquetCartes[i] = valeur; //on assigne à l'élément de la liste ayant pour index i l'ancienne valeur de l'élément de la liste ayant pour index k
            }
            return paquetCartes;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        


        
    }
}
