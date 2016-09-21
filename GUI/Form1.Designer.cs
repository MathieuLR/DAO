namespace GUI
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bouton_ajouter = new System.Windows.Forms.Button();
            this.bouton_modifier = new System.Windows.Forms.Button();
            this.bouton_supprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ville = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.bouton_annuler = new System.Windows.Forms.Button();
            this.bouton_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bouton_ajouter
            // 
            this.bouton_ajouter.Location = new System.Drawing.Point(228, 12);
            this.bouton_ajouter.Name = "bouton_ajouter";
            this.bouton_ajouter.Size = new System.Drawing.Size(121, 23);
            this.bouton_ajouter.TabIndex = 1;
            this.bouton_ajouter.Text = "Ajouter";
            this.bouton_ajouter.UseVisualStyleBackColor = true;
            this.bouton_ajouter.Click += new System.EventHandler(this.bouton_ajouter_Click);
            // 
            // bouton_modifier
            // 
            this.bouton_modifier.Location = new System.Drawing.Point(228, 41);
            this.bouton_modifier.Name = "bouton_modifier";
            this.bouton_modifier.Size = new System.Drawing.Size(121, 23);
            this.bouton_modifier.TabIndex = 2;
            this.bouton_modifier.Text = "Modifier";
            this.bouton_modifier.UseVisualStyleBackColor = true;
            this.bouton_modifier.Click += new System.EventHandler(this.bouton_modifier_Click);
            // 
            // bouton_supprimer
            // 
            this.bouton_supprimer.Location = new System.Drawing.Point(228, 70);
            this.bouton_supprimer.Name = "bouton_supprimer";
            this.bouton_supprimer.Size = new System.Drawing.Size(121, 23);
            this.bouton_supprimer.TabIndex = 3;
            this.bouton_supprimer.Text = "Supprimer";
            this.bouton_supprimer.UseVisualStyleBackColor = true;
            this.bouton_supprimer.Click += new System.EventHandler(this.bouton_supprimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ville);
            this.groupBox1.Controls.Add(this.textBox_prenom);
            this.groupBox1.Controls.Add(this.textBox_nom);
            this.groupBox1.Controls.Add(this.bouton_annuler);
            this.groupBox1.Controls.Add(this.bouton_ok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_nom);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // textBox_ville
            // 
            this.textBox_ville.Location = new System.Drawing.Point(68, 123);
            this.textBox_ville.Name = "textBox_ville";
            this.textBox_ville.Size = new System.Drawing.Size(98, 20);
            this.textBox_ville.TabIndex = 9;
            this.textBox_ville.TextChanged += new System.EventHandler(this.textBox_ville_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(68, 86);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(98, 20);
            this.textBox_prenom.TabIndex = 8;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(68, 51);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(98, 20);
            this.textBox_nom.TabIndex = 7;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // bouton_annuler
            // 
            this.bouton_annuler.Location = new System.Drawing.Point(114, 208);
            this.bouton_annuler.Name = "bouton_annuler";
            this.bouton_annuler.Size = new System.Drawing.Size(80, 23);
            this.bouton_annuler.TabIndex = 6;
            this.bouton_annuler.Text = "Annuler";
            this.bouton_annuler.UseVisualStyleBackColor = true;
            this.bouton_annuler.Click += new System.EventHandler(this.bouton_annuler_Click);
            // 
            // bouton_ok
            // 
            this.bouton_ok.Location = new System.Drawing.Point(6, 208);
            this.bouton_ok.Name = "bouton_ok";
            this.bouton_ok.Size = new System.Drawing.Size(78, 23);
            this.bouton_ok.TabIndex = 5;
            this.bouton_ok.Text = "OK";
            this.bouton_ok.UseVisualStyleBackColor = true;
            this.bouton_ok.Click += new System.EventHandler(this.bouton_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(19, 58);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(29, 13);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bouton_supprimer);
            this.Controls.Add(this.bouton_modifier);
            this.Controls.Add(this.bouton_ajouter);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bouton_ajouter;
        private System.Windows.Forms.Button bouton_modifier;
        private System.Windows.Forms.Button bouton_supprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ville;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Button bouton_annuler;
        private System.Windows.Forms.Button bouton_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nom;
    }
}

