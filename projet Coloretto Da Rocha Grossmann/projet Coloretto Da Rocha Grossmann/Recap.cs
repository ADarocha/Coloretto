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
    }
}
