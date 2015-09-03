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

        List<string> listeCouleurD = new List<string>();
        bool isUnique;
        Principal principal; //initialisation du Form de la fenêtre de jeu principale
        int nbJoueurs = 2;
        Jeu coloretto;
        List<Joueur> listeJoueurs;
        Joueur joueur1, joueur2, joueur3, joueur4, joueur5; //initialisation des objets de la classe Joueur
        bool erreurCouleur = false; bool score2Coche; bool score1Coche;
        bool tableauScore;

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
                configJoueurs(nbJoueurs);
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
                configJoueurs(nbJoueurs);
            }
            else
            {
                MessageBox.Show("Le nombre de joueurs doit être compris entre 2 et 5");
            }
        }

        private void btScoreBeige_Click(object sender, EventArgs e)
        {
            tableauScore = true; //active le score beige dans l'objet.
            lbScoreGris.Visible = false; //rend invisible le label confirmant le score gris si il avait été séléctionné auparavant.
            lbScoreBeige.Visible = true; //rend visible le label confirmant le score beige.
            score2Coche = false;
            score1Coche = true;


        }

        private void btScoreGris_Click(object sender, EventArgs e)
        {
            tableauScore = false; 
            lbScoreBeige.Visible = false;
            lbScoreGris.Visible = true;
            score2Coche = true;
            score1Coche = false;
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
            if (score1Coche == false && score2Coche == false)
            {
                MessageBox.Show("Il faut choisir un type de score.");
                return;
            }

            switch (tbNbJoueurs.Text)
            {
                case "2":
                    if (cbCouleurJ1.Text == "" || cbCouleurJ2.Text == "")
                    {
                        MessageBox.Show("Chaque joueur doit choisir une couleur");
                        erreurCouleur = true;
                    }
                    else
                        erreurCouleur = false;

                    break;
                case "3":
                    if (cbCouleurJ1.Text == "" || cbCouleurJ2.Text == "" || cbCouleurJ3.Text == "")
                    {
                        MessageBox.Show("Chaque joueur doit choisir une couleur");
                        erreurCouleur = true;
                    }
                    else
                        erreurCouleur = false;
                    break;
                case "4":
                    if (cbCouleurJ1.Text == "" || cbCouleurJ2.Text == "" || cbCouleurJ3.Text == "" || cbCouleurJ4.Text == "")
                    {
                        MessageBox.Show("Chaque joueur doit choisir une couleur");
                        erreurCouleur = true;
                    }
                    else
                        erreurCouleur = false;
                    break;
                case "5":
                    if (cbCouleurJ1.Text == "" || cbCouleurJ2.Text == "" || cbCouleurJ3.Text == "" || cbCouleurJ4.Text == "" || cbCouleurJ5.Text == "")
                    {
                        MessageBox.Show("Chaque joueur doit choisir une couleur");
                        erreurCouleur = true;
                    }
                    else
                        erreurCouleur = false;
                    break;
            }

            if (erreurCouleur == false)
            {
                switch (nbJoueurs)
                {
                    //Utilisation de sous-programmes décrits plus bas pour allèger le code
                    case 2:
                        listeCouleurD.Add(cbCouleurJ1.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ2.SelectedItem.ToString());
                        if (isUnique = listeCouleurD.Distinct().Count() == listeCouleurD.Count())
                            preparationJeu();
                        else
                            MessageBox.Show("Chaque joueur doit avoir une couleur de départ différente.");
                        listeCouleurD.Clear();
                        break;
                    case 3:
                        listeCouleurD.Add(cbCouleurJ1.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ2.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ3.SelectedItem.ToString());
                        if (isUnique = listeCouleurD.Distinct().Count() == listeCouleurD.Count())
                            preparationJeu();
                        else
                            MessageBox.Show("Chaque joueur doit avoir une couleur de départ différente.");
                        listeCouleurD.Clear();
                        break;
                    case 4:
                        listeCouleurD.Add(cbCouleurJ1.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ2.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ3.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ4.SelectedItem.ToString());
                        if (isUnique = listeCouleurD.Distinct().Count() == listeCouleurD.Count())
                            preparationJeu();
                        else
                            MessageBox.Show("Chaque joueur doit avoir une couleur de départ différente.");
                        listeCouleurD.Clear();
                        break;
                    case 5:
                        listeCouleurD.Add(cbCouleurJ1.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ2.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ3.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ4.SelectedItem.ToString()); listeCouleurD.Add(cbCouleurJ5.SelectedItem.ToString());
                        if (isUnique = listeCouleurD.Distinct().Count() == listeCouleurD.Count())
                            preparationJeu();
                        else
                            MessageBox.Show("Chaque joueur doit avoir une couleur de départ différente.");
                        listeCouleurD.Clear();
                        break;
                }
            }


        }



        private void preparationJeu()
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
        /// 
        private void DeuxJoueurss()
        {
            joueur1 = new Joueur(tbNomJ1.Text, cbCouleurJ1.SelectedItem.ToString()); //instanciation du premier joueur
            joueur2 = new Joueur(tbNomJ2.Text, cbCouleurJ2.SelectedItem.ToString()); //instanciation du second joueur
            listeJoueurs = new List<Joueur>(); //instanciation de la liste des joueurs
            listeJoueurs.Add(joueur1); //ajouts des joueurs à la liste
            listeJoueurs.Add(joueur2);
            coloretto = new Jeu(listeJoueurs); //instanciation de l'objet Jeu avec la liste des Joueurs en paramètre
            if (lbScoreBeige.Visible == true)
                coloretto.TypeScore = true;
            else
                coloretto.TypeScore = false;
            
            leTypeScore(coloretto, tableauScore);
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
            leTypeScore(coloretto, tableauScore);
            if (lbScoreBeige.Visible == true)
                coloretto.TypeScore = true;
            else
                coloretto.TypeScore = false;
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
            leTypeScore(coloretto, tableauScore);
            if (lbScoreBeige.Visible == true)
                coloretto.TypeScore = true;
            else
                coloretto.TypeScore = false;
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
            leTypeScore(coloretto, tableauScore);
            if (lbScoreBeige.Visible == true)
                coloretto.TypeScore = true;
            else
                coloretto.TypeScore = false;
            principal = new Principal(coloretto); //instanciation du Form de la fenêtre de jeu principale avec l'objet Jeu en paramètre
            principal.Show(); //Affiche la fenêtre de jeu principale à l'utilisateur
            this.Hide(); //cache la fenêtre de paramètrage de la partie
        }

        public void leTypeScore(Jeu jeuColoretto, bool score)
        {
        
            jeuColoretto.TypeScore = score;
    
        }

        private void btRegles_Click(object sender, EventArgs e)
        {
            Regles regles = new Regles();
            regles.Show();
        }
    }
}
