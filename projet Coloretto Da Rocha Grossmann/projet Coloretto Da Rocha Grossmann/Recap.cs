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
        List<string> paquetCartes = new List<string>();
        List<int> scoreJoueurs = new List<int>();
        public Recap(Jeu coloretto, List<string>paquetCartes, List<int>scoreJoueurs)
        {
            InitializeComponent();
            this.coloretto = coloretto;
            this.paquetCartes = paquetCartes;
            this.scoreJoueurs = scoreJoueurs;
        }
    }
}
