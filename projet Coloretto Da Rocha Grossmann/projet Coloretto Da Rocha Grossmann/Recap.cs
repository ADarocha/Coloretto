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
        string gagant;


        

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
            nbPositifs = 0;
            scoreJ1 = scoreJoueurs[0]; scoreJ2 = scoreJoueurs[1]; scoreJ3 = scoreJoueurs[2]; scoreJ4 = scoreJoueurs[3]; scoreJ5 = scoreJoueurs[4];
            fin = false;
            lbJ1.Text = "Score" + coloretto.ListeJoueurs[0].ToString() + " :";
            lbJ2.Text = "Score" + coloretto.ListeJoueurs[1].ToString() + " :";
            lbScoreJ1.Text = scoreJ1.ToString();
            lbScoreJ2.Text = scoreJ2.ToString();


            switch (coloretto.NbJoueurs)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].ToString() + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ3.Visible = true;
                    lbScoreJ3.Visible = true;
                    break;
                case 4 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].ToString() + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ4.Text = "Score" + coloretto.ListeJoueurs[3].ToString() + " :";
                    lbScoreJ4.Text = scoreJ4.ToString();
                    lbJ3.Visible = true;
                    lbScoreJ3.Visible = true;
                    lbJ4.Visible = true;
                    lbScoreJ4.Visible = true;
                    break;
                case 5 :
                    lbJ3.Text = "Score" + coloretto.ListeJoueurs[2].ToString() + " :";
                    lbScoreJ3.Text = scoreJ3.ToString();
                    lbJ4.Text = "Score" + coloretto.ListeJoueurs[3].ToString() + " :";
                    lbScoreJ4.Text = scoreJ4.ToString();
                    lbJ5.Text = "Score" + coloretto.ListeJoueurs[4].ToString() + " :";
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

        private void btJaune_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);

                        J1 = false;
                        J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);

                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);

                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesJaune[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false;
                        fin = true;
                    }
                }
            }
            btJaune.Visible = false;
        }


        private void btMarron_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);

                        J1 = false;
                        J2 = true;
                        actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesMarron[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false;
                        fin = true;
                    }
                }
            }
            btMarron.Visible = false;
        }

        private void btOrange_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);
                        J1 = false; J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesOrange[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false; fin = true;
                    }
                }
            }
            btOrange.Visible = false;
        }

        private void btRouge_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);
                        J1 = false; J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesRouge[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false; fin = true;
                    }
                }
            }
            btRouge.Visible = false;
        }

        private void btVert_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        J1 = false; J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesVert[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        J5 = false; fin = true;
                    }
                }
            }
            btVert.Visible = false;
        }

        private void btViolet_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);
                        J1 = false; J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ4 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesViolet[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesBleu[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false; fin = true;
                    }
                }
            }
            btViolet.Visible = false;
        }

        private void btBleu_Click(object sender, EventArgs e)
        {
            if (J1)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[0]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[0]);
                        if (btMarron.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[0]);
                        if (btOrange.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[0]);
                        if (btRouge.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[0]);
                        if (btViolet.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[0]);
                        if (btVert.Visible)
                            scoreJ1 = scoreJ1 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[0]);
                        J1 = false; J2 = true; actuScore(1); apparaitre();
                    }
                }
            }
            else if (J2)
            {
                if (nbPositifs < 3)
                {
                    scoreJ2 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[1]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[1]);
                        if (btMarron.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[1]);
                        if (btOrange.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[1]);
                        if (btRouge.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[1]);
                        if (btViolet.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[1]);
                        if (btVert.Visible)
                            scoreJ2 = scoreJ2 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[1]);
                        J2 = false;
                        if (coloretto.NbJoueurs == 2)
                            fin = true;
                        else
                        {
                            J3 = true; actuScore(2); apparaitre();
                        }
                    }
                }
            }
            else if (J3)
            {
                if (nbPositifs < 3)
                {
                    scoreJ3 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[2]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[2]);
                        if (btMarron.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[2]);
                        if (btOrange.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[2]);
                        if (btRouge.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[2]);
                        if (btViolet.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[2]);
                        if (btVert.Visible)
                            scoreJ3 = scoreJ3 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[2]);
                        J3 = false;
                        if (coloretto.NbJoueurs == 3)
                            fin = true;
                        else
                        {
                            J4 = true; actuScore(3); apparaitre();
                        }
                    }
                }
            }
            else if (J4)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[3]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[3]);
                        if (btMarron.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[3]);
                        if (btOrange.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[3]);
                        if (btRouge.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[3]);
                        if (btViolet.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[3]);
                        if (btVert.Visible)
                            scoreJ4 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[3]);
                        J4 = false;
                        if (coloretto.NbJoueurs == 4)
                            fin = true;
                        else
                        {
                            J5 = true; actuScore(4); apparaitre();
                        }
                    }
                }
            }
            else if (J5)
            {
                if (nbPositifs < 3)
                {
                    scoreJ1 = scoreJ1 + nbPointsPositifs(coloretto.TypeScore, cartesBleu[4]);
                    nbPositifs++;
                    if (nbPositifs >= 3)
                    {
                        if (btBleu.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesJaune[4]);
                        if (btMarron.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesMarron[4]);
                        if (btOrange.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesOrange[4]);
                        if (btRouge.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesRouge[4]);
                        if (btViolet.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesViolet[4]);
                        if (btVert.Visible)
                            scoreJ5 = scoreJ5 + nbPointsNegatifs(coloretto.TypeScore, cartesVert[4]);
                        J5 = false; fin = true;
                    }
                }
            }
            btBleu.Visible = false;
        }


        private int nbPointsNegatifs(bool beige, int nbCartes)
        {
            int pts = 0;
            if (beige)
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
            lbJaune.Text = cartesJaune[joueur].ToString();
            lbMarron.Text = cartesJaune[joueur].ToString();
            lbOrange.Text = cartesJaune[joueur].ToString();
            lbRouge.Text = cartesJaune[joueur].ToString();
            lbVert.Text = cartesJaune[joueur].ToString();
            lbViolet.Text = cartesJaune[joueur].ToString();
            lbBleu.Text = cartesJaune[joueur].ToString();
            lbScoreJ1.Text = scoreJ1.ToString();
            lbScoreJ2.Text = scoreJ2.ToString();
            lbScoreJ3.Text = scoreJ3.ToString();
            lbScoreJ4.Text = scoreJ4.ToString();
            lbScoreJ5.Text = scoreJ5.ToString();
        }

        private void apparaitre()
        {
            btBleu.Visible = true;
            btJaune.Visible = true;
            btOrange.Visible = true;
            btViolet.Visible = true;
            btVert.Visible = true;
            btRouge.Visible = true;
            btMarron.Visible = true;
        }
    }
}
