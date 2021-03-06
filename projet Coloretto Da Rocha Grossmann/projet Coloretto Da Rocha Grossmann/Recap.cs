﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    public partial class Recap : Form
    {
        Jeu coloretto = new Jeu();
        List<int> scoreJoueurs = new List<int>();

        List<int> cartesBleu = new List<int>();
        List<int> cartesJaune = new List<int>();
        List<int> cartesMarron = new List<int>();
        List<int> cartesRouge = new List<int>();
        List<int> cartesVert = new List<int>();
        List<int> cartesViolet = new List<int>();
        List<int> cartesOrange = new List<int>();
        bool J1 = true; bool J2 = false; bool J3 = false; bool J4 = false; bool J5 = false;
        int nbPositifs;
        int scoreJ1; int scoreJ2; int scoreJ3; int scoreJ4; int scoreJ5;
        bool fin;
        int joueur;


        
        public Recap(Jeu coloretto, List<int> cartesBleu, List<int> cartesJaune, List<int> cartesMarron, List<int> cartesRouge, List<int> cartesVert, List<int> cartesViolet, List<int> cartesOrange, List<int> scoreJoueurs)
        {
            InitializeComponent();
            this.coloretto = coloretto;
            this.cartesBleu = cartesBleu;
            this.cartesJaune = cartesJaune;
            this.cartesMarron = cartesMarron;
            this.cartesOrange = cartesOrange;
            this.cartesRouge = cartesRouge;
            this.cartesVert = cartesVert;
            this.cartesViolet = cartesViolet;
            this.scoreJoueurs = scoreJoueurs; 
        }


        

        private void Recap_Load(object sender, EventArgs e)
        {
            gbScore.Text = gbScore.Text = coloretto.ListeJoueurs[0].Nom; //nom du premier joueur
            nbPositifs = 0; joueur = 0; 
            scoreJ1 = scoreJoueurs[0]; scoreJ2 = scoreJoueurs[1]; scoreJ3 = scoreJoueurs[2]; scoreJ4 = scoreJoueurs[3]; scoreJ5 = scoreJoueurs[4]; //récupère les scores des joueurs du form précécent.
            fin = false; //détermine la fin du compte des points.
            lbJ1.Text = "Score" + coloretto.ListeJoueurs[0].Nom + " :";
            lbJ2.Text = "Score" + coloretto.ListeJoueurs[1].Nom + " :";
            lbScoreJ1.Text = scoreJ1.ToString();
            lbScoreJ2.Text = scoreJ2.ToString();
            J1 = true; //au tour du joueur 1 de compter ses points


            switch (coloretto.NbJoueurs) //en fonction du nombre de joueurs on fait apparaître le même nombre de noms et de scores.
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].Nom + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ3.Visible = true;
                    lbScoreJ3.Visible = true;
                    break;
                case 4 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].Nom + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ4.Text = "Score" + coloretto.ListeJoueurs[3].Nom + " :";
                    lbScoreJ4.Text = scoreJ4.ToString();
                    lbJ3.Visible = true;
                    lbScoreJ3.Visible = true;
                    lbJ4.Visible = true;
                    lbScoreJ4.Visible = true;
                    break;
                case 5 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].Nom + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ4.Text = "Score" + coloretto.ListeJoueurs[3].Nom + " :";
                    lbScoreJ4.Text = scoreJ4.ToString();
                    lbJ5.Text = "Score" + coloretto.ListeJoueurs[4].Nom + " :";
                    lbScoreJ5.Text = scoreJ5.ToString();
                    lbJ3.Visible = true;
                    lbScoreJ3.Visible = true;
                    lbJ4.Visible = true;
                    lbScoreJ4.Visible = true;
                    lbJ5.Visible = true;
                    lbScoreJ5.Visible = true;
                    break;
            }

            actuScore(0); 

        }
             

        private int nbPointsNegatifs(bool beige, int nbCartes)
        {

            //compte les points des couleurs de façon négative en fonction du type de score retenu.
            int pts = 0;
            if (beige) //si la carte de score est la beige
            {
                switch (nbCartes)
                {
                    case 1:
                        pts = -1;
                        break;
                    case 2:
                        pts = -3;
                        break;
                    case 3:
                        pts = -6;
                        break;
                    case 4:
                        pts = -10;
                        break;
                    case 5:
                        pts = -15;
                        break;
                    case 6:
                        pts = -21;
                        break;
                    case 7:
                        pts = -21;
                        break;
                    case 8:
                        pts = -21;
                        break;
                    case 9:
                        pts = -21;
                        break;

                }
            }
            else
            {
                switch (nbCartes)
                {
                    case 1:
                        pts = -1;
                        break;
                    case 2:
                        pts = -4;
                        break;
                    case 3:
                        pts = -8;
                        break;
                    case 4:
                        pts = -7;
                        break;
                    case 5:
                        pts = -6;
                        break;
                    case 6:
                        pts = -5;
                        break;
                    case 7:
                        pts = -5;
                        break;
                    case 8:
                        pts = -5;
                        break;
                    case 9:
                        pts = -5;
                        break;
                }

            }
            return pts;
        }
       

        private int nbPointsPositifs(bool beige, int nbCartes)
        {

            //même chose que pour nbPointsNegatifs mais pour les points positifs (choisi par l'utilisateurs).
            int pts = 0;
            if (beige)
            {
                switch (nbCartes)
                {
                    case 1:
                        pts = 1;
                        break;
                    case 2:
                        pts = 3;
                        break;
                    case 3:
                        pts = 6;
                        break;
                    case 4:
                        pts = 10;
                        break;
                    case 5:
                        pts = 15;
                        break;
                    case 6:
                        pts = 21;
                        break;
                    case 7:
                        pts = 21;
                        break;
                    case 8:
                        pts = 21;
                        break;
                    case 9:
                        pts = 21;
                        break;

                }
            }
            else
            {
                switch (nbCartes)
                {
                    case 1:
                        pts = 1;
                        break;
                    case 2:
                        pts = 4;
                        break;
                    case 3:
                        pts = 8;
                        break;
                    case 4:
                        pts = 7;
                        break;
                    case 5:
                        pts = 6;
                        break;
                    case 6:
                        pts = 5;
                        break;
                    case 7:
                        pts = 5;
                        break;
                    case 8:
                        pts = 5;
                        break;
                    case 9:
                        pts = 5;
                        break;
                }

            }
            return pts;
        }

        private void actuScore(int joueur)
        {
            //actualise les labels.
            lbJaune.Text = cartesJaune[joueur].ToString();
            lbMarron.Text = cartesMarron[joueur].ToString();
            lbOrange.Text = cartesOrange[joueur].ToString();
            lbRouge.Text = cartesRouge[joueur].ToString();
            lbVert.Text = cartesVert[joueur].ToString();
            lbViolet.Text = cartesViolet[joueur].ToString();
            lbBleu.Text = cartesBleu[joueur].ToString();
            lbScoreJ1.Text = scoreJ1.ToString();
            lbScoreJ2.Text = scoreJ2.ToString();
            lbScoreJ3.Text = scoreJ3.ToString();
            lbScoreJ4.Text = scoreJ4.ToString();
            lbScoreJ5.Text = scoreJ5.ToString();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //détermine quel joueur compte ses points.
            if (J1)
            {
                joueur = 0;
            }
            else
            {
                if (J2)
                {
                    joueur = 1;
                    
                }
                else
                {
                    if (J3)
                    {
                        joueur = 2;
                        
                    }
                    else
                    {
                        if (J4)
                        {
                            joueur = 3;
                            
                        }
                        else
                        {
                            if (J5)
                            {
                                joueur = 4;
                                
                            }
                        }
                    }
                }
            }


            
            if(nbPositifs == 3) //si le joueur a bien choisi 3 couleurs
            {
                switch (joueur) //en fonction du joueur, on lui ajoute les points positifs.
                {
                    case 0:
                        if (cbBleu.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked)
                            scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 1:
                        if (cbBleu.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked)
                            scoreJ2 = scoreJ2 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 2:
                        if (cbBleu.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked)
                            scoreJ3 = scoreJ3 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 3:
                        if (cbBleu.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked)
                            scoreJ4 = scoreJ4 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 4:
                        if (cbBleu.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked)
                            scoreJ5 = scoreJ5 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                }
                switch (joueur) //puis les points négatifs.
                {
                    case 0:
                        if (cbBleu.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked == false)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 1:
                        if (cbBleu.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked == false)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 2:
                        if (cbBleu.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked == false)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 3:
                        if (cbBleu.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked == false)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                    case 4:
                        if (cbBleu.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[joueur]);
                        if (cbMarron.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[joueur]);
                        if (cbViolet.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[joueur]);
                        if (cbJaune.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[joueur]);
                        if (cbVert.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[joueur]);
                        if (cbRouge.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[joueur]);
                        if (cbOrange.Checked == false)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[joueur]);
                        break;
                }

                if (J1)
                {
                    J1 = false; J2 = true; actuScore(1); gbScore.Text = coloretto.ListeJoueurs[1].Nom;
                }
                else
                {
                    if (J2 && coloretto.NbJoueurs == 2)
                    {
                        J2 = false; fin = true; actuScore(1);
                    }
                    else
                    {
                        if (J2 && coloretto.NbJoueurs > 2)
                        {
                            J2 = false; J3 = true; actuScore(2); gbScore.Text = coloretto.ListeJoueurs[2].Nom;
                        }
                        else
                        {
                            if (J3 && coloretto.NbJoueurs == 3)
                            {
                                J3 = false; fin = true; actuScore(1);
                            }
                            else
                            {
                                if (J3 && coloretto.NbJoueurs > 3)
                                {
                                    J3 = false; J4 = true; actuScore(3); gbScore.Text = coloretto.ListeJoueurs[3].Nom;
                                }
                                else
                                {
                                    if (J4 && coloretto.NbJoueurs == 4)
                                    {
                                        J4 = false; fin = true; actuScore(1);
                                    }
                                    else
                                    {
                                        if (J4 && coloretto.NbJoueurs == 5)
                                        {
                                            J4 = false; J5 = true; actuScore(4); gbScore.Text = coloretto.ListeJoueurs[4].Nom;
                                        }
                                        else
                                        {
                                            if (J5)
                                            {
                                                J5 = false; fin = true; actuScore(1);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            

            else
            {
                MessageBox.Show("Vous devez cocher 3 couleurs");
                return;
            }
            if (fin)
            {
                gbScore.Visible = false;
                MessageBox.Show("Les scores ont étés calculés et sont affichés ci-dessous.");
            }
        }



        private void Recap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbJaune_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJaune.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbMarron_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMarron.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOrange.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRouge.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbVert_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVert.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbViolet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViolet.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

        private void cbBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBleu.Checked)
            {
                nbPositifs++;
            }
            else
            {
                nbPositifs--;
            }
        }

    }
}
