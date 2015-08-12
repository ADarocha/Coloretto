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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMoins = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbJoueurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJoueurs
            // 
            this.gbJoueurs.Controls.Add(this.label2);
            this.gbJoueurs.Controls.Add(this.button2);
            this.gbJoueurs.Controls.Add(this.button1);
            this.gbJoueurs.Controls.Add(this.label1);
            this.gbJoueurs.Controls.Add(this.maskedTextBox1);
            this.gbJoueurs.Controls.Add(this.btPlus);
            this.gbJoueurs.Controls.Add(this.btMoins);
            this.gbJoueurs.Location = new System.Drawing.Point(12, 12);
            this.gbJoueurs.Name = "gbJoueurs";
            this.gbJoueurs.Size = new System.Drawing.Size(960, 638);
            this.gbJoueurs.TabIndex = 0;
            this.gbJoueurs.TabStop = false;
            this.gbJoueurs.Text = "Initialisation de la partie";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(211, 58);
            this.maskedTextBox1.Mask = "9";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox1.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Joueurs (entre 2 et 5) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type de tableau de Score :";
            // 
            // button2
            // 
            this.button2.Image = global::projet_Coloretto_Da_Rocha_Grossmann.Properties.Resources.carteGrise;
            this.button2.Location = new System.Drawing.Point(745, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 225);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::projet_Coloretto_Da_Rocha_Grossmann.Properties.Resources.carteBeige;
            this.button1.Location = new System.Drawing.Point(494, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 225);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJoueurs;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMoins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

