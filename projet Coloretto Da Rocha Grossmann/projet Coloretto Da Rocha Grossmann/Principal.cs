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
        public Principal(Jeu coloretto)
        {
            InitializeComponent(); //création du Form
            this.coloretto = new Jeu(coloretto.ListeJoueurs); //instanciation d'un objet de la classe Jeu avec les paramètres issu de l'objet du Form précédent
        }

        /// <summary>
        /// Méthode de test lors du chargement du Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            lbTest.Text = coloretto.ListeJoueurs[0].Nom;
        }
    }
}
