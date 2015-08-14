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
    public partial class Coloretto : Form
    {
        public Coloretto()
        {
            InitializeComponent();
            
        }

        int nbJoueurs = 2;
        Jeu coloretto = new Jeu();
        Joueur cloclo = new Joueur("clocloleCharclo", "JauneAsiatique");

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNbJoueurs.Text = "2"; //initialise la textBox avec le nombre de joueurs
        }

        private void DeuxJoueurs()
        {
            if (nbJoueurs == 2) //si le nombre de joueurs est de 2
            {
                coloretto.DeuxJoueurs = true; //On active le mode deux joueurs dans l'objet
            }
            else coloretto.DeuxJoueurs = false; //Sinon on active le mode 2+ joueurs
        }

        private void configJoueurs(int nbJoueurs)
        {
            switch (nbJoueurs) //en fonction du nombre de joueurs, on fait disparaître / apparaître des groupBox pour donner un nom et une couleur à chaque joueur.
            {
                case 2:
                    gbJ3.Visible = false;
                    gbJ4.Visible = false;
                    gbJ5.Visible = false;
                    break;
                case 3:
                    gbJ3.Visible = true;
                    gbJ4.Visible = false;
                    gbJ5.Visible = false;
                    break;
                case 4:
                    gbJ3.Visible = true;
                    gbJ4.Visible = true;
                    gbJ5.Visible = false;
                    break;
                case 5:
                    gbJ3.Visible = true;
                    gbJ4.Visible = true;
                    gbJ5.Visible = true;
                    break;
            }
                
        }


        private void btMoins_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbNbJoueurs.Text) > 2)
            {
                coloretto.NbJoueurs = coloretto.NbJoueurs - 1; //modifie le nombre de joueurs dans l'objet.
                nbJoueurs = nbJoueurs - 1; //variable local pour compter le nombre de joueurs (va servir à déterminer le nombre de nom de joueurs à demander).
                tbNbJoueurs.Text = nbJoueurs.ToString(); //affiche le nouveau nombre de joueurs.
                configJoueurs(nbJoueurs);
            }
            else
            {
                MessageBox.Show("Le nombre de joueurs doit être compris entre 2 et 5");
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(tbNbJoueurs.Text) < 5)
            {
                coloretto.NbJoueurs = coloretto.NbJoueurs + 1; //modifie le nombre de joueurs dans l'objet.
                nbJoueurs = nbJoueurs + 1; //variable local pour compter le nombre de joueurs (va servir à déterminer le nombre de nom de joueurs à demander).
                tbNbJoueurs.Text = nbJoueurs.ToString(); //affiche le nouveau nombre de joueurs.
                configJoueurs(nbJoueurs);
            }
            else
            {
                MessageBox.Show("Le nombre de joueurs doit être compris entre 2 et 5");
            }
        }

        private void btScoreBeige_Click(object sender, EventArgs e)
        {
            coloretto.TypeScore = true; //active le score beige dans l'objet.
            lbScoreGris.Visible = false; //rend invisible le label confirmant le score gris si il avait été séléctionné auparavant.
            lbScoreBeige.Visible = true; //rend visible le label confirmant le score beige.

        }

        private void btScoreGris_Click(object sender, EventArgs e)
        {
            //voir btScoreBeige_Click
            coloretto.TypeScore = false; 
            lbScoreBeige.Visible = false;
            lbScoreGris.Visible = true;
        }
    }
}
