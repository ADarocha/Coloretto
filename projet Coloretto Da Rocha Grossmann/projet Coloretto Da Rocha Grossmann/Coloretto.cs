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

        Principal principal; //initialisation du Form de la fenêtre de jeu principale
        int nbJoueurs = 2;
        Jeu coloretto;
        List<Joueur> listeJoueurs;
        Joueur joueur1, joueur2, joueur3, joueur4, joueur5; //initialisation des objets de la classe Joueur

        private void Form1_Load(object sender, EventArgs e)
        {
            tbNbJoueurs.Text = nbJoueurs.ToString(); //initialise la textBox avec le nombre de joueurs
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
            if (nbJoueurs > 2)
            {
                nbJoueurs--;
                tbNbJoueurs.Text = nbJoueurs.ToString();
            }
            else
            {
                MessageBox.Show("Le nombre de joueurs doit être compris entre 2 et 5");
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {

            if (nbJoueurs < 5)
            {
                nbJoueurs++;
                tbNbJoueurs.Text = nbJoueurs.ToString();
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

        private void btReset_Click(object sender, EventArgs e)
        {
            //pour chaque control dans tout les controls du form
            foreach (Control gb in this.Controls)
            {
                //si le control est une GroupBox
                if (gb is GroupBox)
                {
                    //pour chaque control dans la GroupBox
                    foreach (Control tb in gb.Controls)
                    {
                        //si le control est une TextBox
                        if (tb is TextBox)
                        {
                            //cast de la class TextBox sur la variable locale et vidage de sa zone de texte
                            ((TextBox)tb).Clear();
                        }
                    }
                }
            }
        }

        public void btValider_Click(object sender, EventArgs e)
        {
            try
            {
                switch (nbJoueurs)
                {
                    //Utilisation de sous-programmes décrits plus bas pour allèger le code
                    case 2:
                        DeuxJoueurss();
                        break;
                    case 3:
                        TroisJoueurs();
                        break;
                    case 4:
                        QuatreJoueurs();
                        break;
                    case 5:
                        CinqJoueurs();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Sous-prog générant un objet de la classe Jeu pour deux joueurs puis ouverture de la fenêtre de jeu principale
        /// </summary>
        private void DeuxJoueurss()
        {
            joueur1 = new Joueur(tbNomJ1.Text, cbCouleurJ1.SelectedItem.ToString()); //instanciation du premier joueur
            joueur2 = new Joueur(tbNomJ2.Text, cbCouleurJ2.SelectedItem.ToString()); //instanciation du second joueur
            listeJoueurs = new List<Joueur>(); //instanciation de la liste des joueurs
            listeJoueurs.Add(joueur1); //ajouts des joueurs à la liste
            listeJoueurs.Add(joueur2);
            coloretto = new Jeu(listeJoueurs); //instanciation de l'objet Jeu avec la liste des Joueurs en paramètre
            principal = new Principal(coloretto); //instanciation du Form de la fenêtre de jeu principale avec l'objet Jeu en paramètre
            principal.Show(); //Affiche la fenêtre de jeu principale à l'utilisateur
            this.Hide(); //cache la fenêtre de paramètrage de la partie
        }

        /// <summary>
        /// Sous-prog générant un objet de la classe Jeu pour trois joueurs puis ouverture de la fenêtre de jeu principale
        /// </summary>
        private void TroisJoueurs()
        {
            joueur1 = new Joueur(tbNomJ1.Text, cbCouleurJ1.SelectedItem.ToString()); //instanciation du premier joueur
            joueur2 = new Joueur(tbNomJ2.Text, cbCouleurJ2.SelectedItem.ToString()); //instanciation du second joueur
            joueur3 = new Joueur(tbNomJ3.Text, cbCouleurJ3.SelectedItem.ToString()); //instanciation du troisième joueur
            listeJoueurs = new List<Joueur>(); //instanciation de la liste des joueurs
            listeJoueurs.Add(joueur1); //ajouts des joueurs à la liste
            listeJoueurs.Add(joueur2);
            listeJoueurs.Add(joueur3);
            coloretto = new Jeu(listeJoueurs); //instanciation de l'objet Jeu avec la liste des Joueurs en paramètre
            principal = new Principal(coloretto); //instanciation du Form de la fenêtre de jeu principale avec l'objet Jeu en paramètre
            principal.Show(); //Affiche la fenêtre de jeu principale à l'utilisateur
            this.Hide(); //cache la fenêtre de paramètrage de la partie
        }

        /// <summary>
        /// Sous-prog générant un objet de la classe Jeu pour quatre joueurs puis ouverture de la fenêtre de jeu principale
        /// </summary>
        private void QuatreJoueurs()
        {
            joueur1 = new Joueur(tbNomJ1.Text, cbCouleurJ1.SelectedItem.ToString()); //instanciation du premier joueur
            joueur2 = new Joueur(tbNomJ2.Text, cbCouleurJ2.SelectedItem.ToString()); //instanciation du second joueur
            joueur3 = new Joueur(tbNomJ3.Text, cbCouleurJ3.SelectedItem.ToString()); //instanciation du troisième joueur
            joueur4 = new Joueur(tbNomJ4.Text, cbCouleurJ4.SelectedItem.ToString()); //instanciation du quatrième joueur
            listeJoueurs = new List<Joueur>(); //instanciation de la liste des joueurs
            listeJoueurs.Add(joueur1); //ajouts des joueurs à la liste
            listeJoueurs.Add(joueur2);
            listeJoueurs.Add(joueur3);
            listeJoueurs.Add(joueur4);
            coloretto = new Jeu(listeJoueurs); //instanciation de l'objet Jeu avec la liste des Joueurs en paramètre
            principal = new Principal(coloretto); //instanciation du Form de la fenêtre de jeu principale avec l'objet Jeu en paramètre
            principal.Show(); //Affiche la fenêtre de jeu principale à l'utilisateur
            this.Hide(); //cache la fenêtre de paramètrage de la partie
        }

        /// <summary>
        /// Sous-prog générant un objet de la classe Jeu pour cinq joueurs puis ouverture de la fenêtre de jeu principale
        /// </summary>
        private void CinqJoueurs()
        {
            joueur1 = new Joueur(tbNomJ1.Text, cbCouleurJ1.SelectedItem.ToString()); //instanciation du premier joueur
            joueur2 = new Joueur(tbNomJ2.Text, cbCouleurJ2.SelectedItem.ToString()); //instanciation du second joueur
            joueur3 = new Joueur(tbNomJ3.Text, cbCouleurJ3.SelectedItem.ToString()); //instanciation du troisième joueur
            joueur4 = new Joueur(tbNomJ4.Text, cbCouleurJ4.SelectedItem.ToString()); //instanciation du quatrième joueur
            joueur5 = new Joueur(tbNomJ5.Text, cbCouleurJ5.SelectedItem.ToString()); //instanciation du cinquième joueur
            listeJoueurs = new List<Joueur>(); //instanciation de la liste des joueurs
            listeJoueurs.Add(joueur1); //ajouts des joueurs à la liste
            listeJoueurs.Add(joueur2); 
            listeJoueurs.Add(joueur3);
            listeJoueurs.Add(joueur4);
            listeJoueurs.Add(joueur5);
            coloretto = new Jeu(listeJoueurs); //instanciation de l'objet Jeu avec la liste des Joueurs en paramètre
            principal = new Principal(coloretto); //instanciation du Form de la fenêtre de jeu principale avec l'objet Jeu en paramètre
            principal.Show(); //Affiche la fenêtre de jeu principale à l'utilisateur
            this.Hide(); //cache la fenêtre de paramètrage de la partie
        }
    }
}
