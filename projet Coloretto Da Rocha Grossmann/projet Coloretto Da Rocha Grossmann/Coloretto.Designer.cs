namespace projet_Coloretto_Da_Rocha_Grossmann
{
    partial class Coloretto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJoueurs = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.gbJ5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNomJ5 = new System.Windows.Forms.TextBox();
            this.cbCouleurJ5 = new System.Windows.Forms.ComboBox();
            this.gbJ4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNomJ4 = new System.Windows.Forms.TextBox();
            this.cbCouleurJ4 = new System.Windows.Forms.ComboBox();
            this.gbJ3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNomJ3 = new System.Windows.Forms.TextBox();
            this.cbCouleurJ3 = new System.Windows.Forms.ComboBox();
            this.gbJ2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomJ2 = new System.Windows.Forms.TextBox();
            this.cbCouleurJ2 = new System.Windows.Forms.ComboBox();
            this.gbJ1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomJ1 = new System.Windows.Forms.TextBox();
            this.cbCouleurJ1 = new System.Windows.Forms.ComboBox();
            this.gbTypeScore = new System.Windows.Forms.GroupBox();
            this.btScoreBeige = new System.Windows.Forms.Button();
            this.lbScoreGris = new System.Windows.Forms.Label();
            this.btScoreGris = new System.Windows.Forms.Button();
            this.lbScoreBeige = new System.Windows.Forms.Label();
            this.lbTypeScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNbJoueurs = new System.Windows.Forms.MaskedTextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMoins = new System.Windows.Forms.Button();
            this.gbJoueurs.SuspendLayout();
            this.gbJ5.SuspendLayout();
            this.gbJ4.SuspendLayout();
            this.gbJ3.SuspendLayout();
            this.gbJ2.SuspendLayout();
            this.gbJ1.SuspendLayout();
            this.gbTypeScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJoueurs
            // 
            this.gbJoueurs.Controls.Add(this.btReset);
            this.gbJoueurs.Controls.Add(this.btValider);
            this.gbJoueurs.Controls.Add(this.gbJ5);
            this.gbJoueurs.Controls.Add(this.gbJ4);
            this.gbJoueurs.Controls.Add(this.gbJ3);
            this.gbJoueurs.Controls.Add(this.gbJ2);
            this.gbJoueurs.Controls.Add(this.gbJ1);
            this.gbJoueurs.Controls.Add(this.gbTypeScore);
            this.gbJoueurs.Controls.Add(this.label1);
            this.gbJoueurs.Controls.Add(this.tbNbJoueurs);
            this.gbJoueurs.Controls.Add(this.btPlus);
            this.gbJoueurs.Controls.Add(this.btMoins);
            this.gbJoueurs.Location = new System.Drawing.Point(12, 12);
            this.gbJoueurs.Name = "gbJoueurs";
            this.gbJoueurs.Size = new System.Drawing.Size(960, 638);
            this.gbJoueurs.TabIndex = 0;
            this.gbJoueurs.TabStop = false;
            this.gbJoueurs.Text = "Initialisation de la partie";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(90, 451);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 37;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(9, 451);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 1;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // gbJ5
            // 
            this.gbJ5.Controls.Add(this.label10);
            this.gbJ5.Controls.Add(this.label11);
            this.gbJ5.Controls.Add(this.tbNomJ5);
            this.gbJ5.Controls.Add(this.cbCouleurJ5);
            this.gbJ5.Location = new System.Drawing.Point(9, 348);
            this.gbJ5.Name = "gbJ5";
            this.gbJ5.Size = new System.Drawing.Size(358, 56);
            this.gbJ5.TabIndex = 36;
            this.gbJ5.TabStop = false;
            this.gbJ5.Text = "Joueur 5";
            this.gbJ5.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nom :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Couleur : ";
            // 
            // tbNomJ5
            // 
            this.tbNomJ5.Location = new System.Drawing.Point(63, 21);
            this.tbNomJ5.Name = "tbNomJ5";
            this.tbNomJ5.Size = new System.Drawing.Size(100, 20);
            this.tbNomJ5.TabIndex = 13;
            // 
            // cbCouleurJ5
            // 
            this.cbCouleurJ5.FormattingEnabled = true;
            this.cbCouleurJ5.Items.AddRange(new object[] {
            "Orange",
            "Bleu",
            "Marron",
            "Jaune",
            "Violet",
            "Vert",
            "Rouge"});
            this.cbCouleurJ5.Location = new System.Drawing.Point(223, 21);
            this.cbCouleurJ5.Name = "cbCouleurJ5";
            this.cbCouleurJ5.Size = new System.Drawing.Size(121, 21);
            this.cbCouleurJ5.TabIndex = 14;
            // 
            // gbJ4
            // 
            this.gbJ4.Controls.Add(this.label8);
            this.gbJ4.Controls.Add(this.label9);
            this.gbJ4.Controls.Add(this.tbNomJ4);
            this.gbJ4.Controls.Add(this.cbCouleurJ4);
            this.gbJ4.Location = new System.Drawing.Point(6, 286);
            this.gbJ4.Name = "gbJ4";
            this.gbJ4.Size = new System.Drawing.Size(358, 56);
            this.gbJ4.TabIndex = 36;
            this.gbJ4.TabStop = false;
            this.gbJ4.Text = "Joueur 4";
            this.gbJ4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Couleur : ";
            // 
            // tbNomJ4
            // 
            this.tbNomJ4.Location = new System.Drawing.Point(63, 21);
            this.tbNomJ4.Name = "tbNomJ4";
            this.tbNomJ4.Size = new System.Drawing.Size(100, 20);
            this.tbNomJ4.TabIndex = 13;
            // 
            // cbCouleurJ4
            // 
            this.cbCouleurJ4.FormattingEnabled = true;
            this.cbCouleurJ4.Items.AddRange(new object[] {
            "Orange",
            "Bleu",
            "Marron",
            "Jaune",
            "Violet",
            "Vert",
            "Rouge"});
            this.cbCouleurJ4.Location = new System.Drawing.Point(223, 21);
            this.cbCouleurJ4.Name = "cbCouleurJ4";
            this.cbCouleurJ4.Size = new System.Drawing.Size(121, 21);
            this.cbCouleurJ4.TabIndex = 14;
            // 
            // gbJ3
            // 
            this.gbJ3.Controls.Add(this.label6);
            this.gbJ3.Controls.Add(this.label7);
            this.gbJ3.Controls.Add(this.tbNomJ3);
            this.gbJ3.Controls.Add(this.cbCouleurJ3);
            this.gbJ3.Location = new System.Drawing.Point(9, 224);
            this.gbJ3.Name = "gbJ3";
            this.gbJ3.Size = new System.Drawing.Size(358, 56);
            this.gbJ3.TabIndex = 36;
            this.gbJ3.TabStop = false;
            this.gbJ3.Text = "Joueur 3";
            this.gbJ3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Couleur : ";
            // 
            // tbNomJ3
            // 
            this.tbNomJ3.Location = new System.Drawing.Point(63, 21);
            this.tbNomJ3.Name = "tbNomJ3";
            this.tbNomJ3.Size = new System.Drawing.Size(100, 20);
            this.tbNomJ3.TabIndex = 13;
            // 
            // cbCouleurJ3
            // 
            this.cbCouleurJ3.FormattingEnabled = true;
            this.cbCouleurJ3.Items.AddRange(new object[] {
            "Orange",
            "Bleu",
            "Marron",
            "Jaune",
            "Violet",
            "Vert",
            "Rouge"});
            this.cbCouleurJ3.Location = new System.Drawing.Point(223, 21);
            this.cbCouleurJ3.Name = "cbCouleurJ3";
            this.cbCouleurJ3.Size = new System.Drawing.Size(121, 21);
            this.cbCouleurJ3.TabIndex = 14;
            // 
            // gbJ2
            // 
            this.gbJ2.Controls.Add(this.label4);
            this.gbJ2.Controls.Add(this.label5);
            this.gbJ2.Controls.Add(this.tbNomJ2);
            this.gbJ2.Controls.Add(this.cbCouleurJ2);
            this.gbJ2.Location = new System.Drawing.Point(9, 162);
            this.gbJ2.Name = "gbJ2";
            this.gbJ2.Size = new System.Drawing.Size(358, 56);
            this.gbJ2.TabIndex = 36;
            this.gbJ2.TabStop = false;
            this.gbJ2.Text = "Joueur 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Couleur : ";
            // 
            // tbNomJ2
            // 
            this.tbNomJ2.Location = new System.Drawing.Point(63, 21);
            this.tbNomJ2.Name = "tbNomJ2";
            this.tbNomJ2.Size = new System.Drawing.Size(100, 20);
            this.tbNomJ2.TabIndex = 13;
            // 
            // cbCouleurJ2
            // 
            this.cbCouleurJ2.FormattingEnabled = true;
            this.cbCouleurJ2.Items.AddRange(new object[] {
            "Orange",
            "Bleu",
            "Marron",
            "Jaune",
            "Violet",
            "Vert",
            "Rouge"});
            this.cbCouleurJ2.Location = new System.Drawing.Point(223, 21);
            this.cbCouleurJ2.Name = "cbCouleurJ2";
            this.cbCouleurJ2.Size = new System.Drawing.Size(121, 21);
            this.cbCouleurJ2.TabIndex = 14;
            // 
            // gbJ1
            // 
            this.gbJ1.Controls.Add(this.label2);
            this.gbJ1.Controls.Add(this.label3);
            this.gbJ1.Controls.Add(this.tbNomJ1);
            this.gbJ1.Controls.Add(this.cbCouleurJ1);
            this.gbJ1.Location = new System.Drawing.Point(9, 100);
            this.gbJ1.Name = "gbJ1";
            this.gbJ1.Size = new System.Drawing.Size(358, 56);
            this.gbJ1.TabIndex = 35;
            this.gbJ1.TabStop = false;
            this.gbJ1.Text = "Joueur 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Couleur : ";
            // 
            // tbNomJ1
            // 
            this.tbNomJ1.Location = new System.Drawing.Point(63, 21);
            this.tbNomJ1.Name = "tbNomJ1";
            this.tbNomJ1.Size = new System.Drawing.Size(100, 20);
            this.tbNomJ1.TabIndex = 13;
            // 
            // cbCouleurJ1
            // 
            this.cbCouleurJ1.FormattingEnabled = true;
            this.cbCouleurJ1.Items.AddRange(new object[] {
            "Orange",
            "Bleu",
            "Marron",
            "Jaune",
            "Violet",
            "Vert",
            "Rouge"});
            this.cbCouleurJ1.Location = new System.Drawing.Point(223, 21);
            this.cbCouleurJ1.Name = "cbCouleurJ1";
            this.cbCouleurJ1.Size = new System.Drawing.Size(121, 21);
            this.cbCouleurJ1.TabIndex = 14;
            // 
            // gbTypeScore
            // 
            this.gbTypeScore.Controls.Add(this.btScoreBeige);
            this.gbTypeScore.Controls.Add(this.lbScoreGris);
            this.gbTypeScore.Controls.Add(this.btScoreGris);
            this.gbTypeScore.Controls.Add(this.lbScoreBeige);
            this.gbTypeScore.Controls.Add(this.lbTypeScore);
            this.gbTypeScore.Location = new System.Drawing.Point(414, 100);
            this.gbTypeScore.Name = "gbTypeScore";
            this.gbTypeScore.Size = new System.Drawing.Size(478, 362);
            this.gbTypeScore.TabIndex = 10;
            this.gbTypeScore.TabStop = false;
            this.gbTypeScore.Text = "Type de score";
            // 
            // btScoreBeige
            // 
            this.btScoreBeige.Image = global::projet_Coloretto_Da_Rocha_Grossmann.Properties.Resources.carteBeige;
            this.btScoreBeige.Location = new System.Drawing.Point(28, 81);
            this.btScoreBeige.Name = "btScoreBeige";
            this.btScoreBeige.Size = new System.Drawing.Size(150, 225);
            this.btScoreBeige.TabIndex = 5;
            this.btScoreBeige.UseVisualStyleBackColor = true;
            this.btScoreBeige.Click += new System.EventHandler(this.btScoreBeige_Click);
            // 
            // lbScoreGris
            // 
            this.lbScoreGris.AutoSize = true;
            this.lbScoreGris.ForeColor = System.Drawing.Color.Red;
            this.lbScoreGris.Location = new System.Drawing.Point(293, 322);
            this.lbScoreGris.Name = "lbScoreGris";
            this.lbScoreGris.Size = new System.Drawing.Size(149, 13);
            this.lbScoreGris.TabIndex = 9;
            this.lbScoreGris.Text = "Vous avez choisi le score gris.";
            this.lbScoreGris.Visible = false;
            // 
            // btScoreGris
            // 
            this.btScoreGris.Image = global::projet_Coloretto_Da_Rocha_Grossmann.Properties.Resources.carteGrise;
            this.btScoreGris.Location = new System.Drawing.Point(279, 81);
            this.btScoreGris.Name = "btScoreGris";
            this.btScoreGris.Size = new System.Drawing.Size(150, 225);
            this.btScoreGris.TabIndex = 6;
            this.btScoreGris.UseVisualStyleBackColor = true;
            this.btScoreGris.Click += new System.EventHandler(this.btScoreGris_Click);
            // 
            // lbScoreBeige
            // 
            this.lbScoreBeige.AutoSize = true;
            this.lbScoreBeige.ForeColor = System.Drawing.Color.Red;
            this.lbScoreBeige.Location = new System.Drawing.Point(39, 322);
            this.lbScoreBeige.Name = "lbScoreBeige";
            this.lbScoreBeige.Size = new System.Drawing.Size(159, 13);
            this.lbScoreBeige.TabIndex = 8;
            this.lbScoreBeige.Text = "Vous avez choisi le score beige.";
            this.lbScoreBeige.Visible = false;
            // 
            // lbTypeScore
            // 
            this.lbTypeScore.AutoSize = true;
            this.lbTypeScore.Location = new System.Drawing.Point(25, 30);
            this.lbTypeScore.Name = "lbTypeScore";
            this.lbTypeScore.Size = new System.Drawing.Size(136, 13);
            this.lbTypeScore.TabIndex = 7;
            this.lbTypeScore.Text = "Type de tableau de Score :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Joueurs (entre 2 et 5) :";
            // 
            // tbNbJoueurs
            // 
            this.tbNbJoueurs.Location = new System.Drawing.Point(211, 58);
            this.tbNbJoueurs.Mask = "9";
            this.tbNbJoueurs.Name = "tbNbJoueurs";
            this.tbNbJoueurs.Size = new System.Drawing.Size(25, 20);
            this.tbNbJoueurs.TabIndex = 3;
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(242, 55);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(25, 25);
            this.btPlus.TabIndex = 2;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMoins
            // 
            this.btMoins.Location = new System.Drawing.Point(180, 55);
            this.btMoins.Name = "btMoins";
            this.btMoins.Size = new System.Drawing.Size(25, 25);
            this.btMoins.TabIndex = 1;
            this.btMoins.Text = "-";
            this.btMoins.UseVisualStyleBackColor = true;
            this.btMoins.Click += new System.EventHandler(this.btMoins_Click);
            // 
            // Coloretto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.gbJoueurs);
            this.Name = "Coloretto";
            this.Text = "Coloretto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbJoueurs.ResumeLayout(false);
            this.gbJoueurs.PerformLayout();
            this.gbJ5.ResumeLayout(false);
            this.gbJ5.PerformLayout();
            this.gbJ4.ResumeLayout(false);
            this.gbJ4.PerformLayout();
            this.gbJ3.ResumeLayout(false);
            this.gbJ3.PerformLayout();
            this.gbJ2.ResumeLayout(false);
            this.gbJ2.PerformLayout();
            this.gbJ1.ResumeLayout(false);
            this.gbJ1.PerformLayout();
            this.gbTypeScore.ResumeLayout(false);
            this.gbTypeScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJoueurs;
        private System.Windows.Forms.MaskedTextBox tbNbJoueurs;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMoins;
        private System.Windows.Forms.Button btScoreBeige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btScoreGris;
        private System.Windows.Forms.Label lbTypeScore;
        private System.Windows.Forms.Label lbScoreGris;
        private System.Windows.Forms.Label lbScoreBeige;
        private System.Windows.Forms.GroupBox gbTypeScore;
        private System.Windows.Forms.ComboBox cbCouleurJ1;
        private System.Windows.Forms.TextBox tbNomJ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbJ5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNomJ5;
        private System.Windows.Forms.ComboBox cbCouleurJ5;
        private System.Windows.Forms.GroupBox gbJ4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNomJ4;
        private System.Windows.Forms.ComboBox cbCouleurJ4;
        private System.Windows.Forms.GroupBox gbJ3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNomJ3;
        private System.Windows.Forms.ComboBox cbCouleurJ3;
        private System.Windows.Forms.GroupBox gbJ2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomJ2;
        private System.Windows.Forms.ComboBox cbCouleurJ2;
        private System.Windows.Forms.GroupBox gbJ1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btValider;
    }
}

