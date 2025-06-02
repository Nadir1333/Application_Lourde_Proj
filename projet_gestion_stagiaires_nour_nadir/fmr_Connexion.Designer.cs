
namespace projet_gestion_stagiaires_nour_nadir
{
    partial class fmr_Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_Connexion));
            this.lab_Gestion_Stage = new System.Windows.Forms.Label();
            this.lab_Titre = new System.Windows.Forms.Label();
            this.lab_Identifiant = new System.Windows.Forms.Label();
            this.txt_Identifiant = new System.Windows.Forms.TextBox();
            this.lab_Mdp = new System.Windows.Forms.Label();
            this.btn_Connecter = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.txt_Mdp = new System.Windows.Forms.TextBox();
            this.lab_Erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Gestion_Stage
            // 
            this.lab_Gestion_Stage.AutoSize = true;
            this.lab_Gestion_Stage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Gestion_Stage.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lab_Gestion_Stage.Location = new System.Drawing.Point(63, 21);
            this.lab_Gestion_Stage.Name = "lab_Gestion_Stage";
            this.lab_Gestion_Stage.Size = new System.Drawing.Size(278, 37);
            this.lab_Gestion_Stage.TabIndex = 0;
            this.lab_Gestion_Stage.Text = "Gestion Stagiaires";
            this.lab_Gestion_Stage.Click += new System.EventHandler(this.lab_Gestion_Stage_Click);
            // 
            // lab_Titre
            // 
            this.lab_Titre.AutoSize = true;
            this.lab_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Titre.Location = new System.Drawing.Point(31, 68);
            this.lab_Titre.Name = "lab_Titre";
            this.lab_Titre.Size = new System.Drawing.Size(314, 16);
            this.lab_Titre.TabIndex = 1;
            this.lab_Titre.Text = "Connectez-vous pour accéder à votre espace tuteur";
            // 
            // lab_Identifiant
            // 
            this.lab_Identifiant.AutoSize = true;
            this.lab_Identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Identifiant.Location = new System.Drawing.Point(31, 142);
            this.lab_Identifiant.Name = "lab_Identifiant";
            this.lab_Identifiant.Size = new System.Drawing.Size(69, 18);
            this.lab_Identifiant.TabIndex = 2;
            this.lab_Identifiant.Text = "Identifiant";
            this.lab_Identifiant.Click += new System.EventHandler(this.lab_Identifiant_Click);
            // 
            // txt_Identifiant
            // 
            this.txt_Identifiant.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identifiant.Location = new System.Drawing.Point(33, 162);
            this.txt_Identifiant.Name = "txt_Identifiant";
            this.txt_Identifiant.Size = new System.Drawing.Size(340, 21);
            this.txt_Identifiant.TabIndex = 3;
            // 
            // lab_Mdp
            // 
            this.lab_Mdp.AutoSize = true;
            this.lab_Mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Mdp.Location = new System.Drawing.Point(31, 236);
            this.lab_Mdp.Name = "lab_Mdp";
            this.lab_Mdp.Size = new System.Drawing.Size(98, 18);
            this.lab_Mdp.TabIndex = 4;
            this.lab_Mdp.Text = "Mot de passe";
            // 
            // btn_Connecter
            // 
            this.btn_Connecter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Connecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connecter.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Connecter.Location = new System.Drawing.Point(46, 391);
            this.btn_Connecter.Name = "btn_Connecter";
            this.btn_Connecter.Size = new System.Drawing.Size(141, 32);
            this.btn_Connecter.TabIndex = 6;
            this.btn_Connecter.Text = "Se Connecter";
            this.btn_Connecter.UseVisualStyleBackColor = false;
            this.btn_Connecter.Click += new System.EventHandler(this.btn_Connecter_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_Quitter.Location = new System.Drawing.Point(206, 391);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(141, 32);
            this.btn_Quitter.TabIndex = 7;
            this.btn_Quitter.Text = "Se Déconnecter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // txt_Mdp
            // 
            this.txt_Mdp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mdp.Location = new System.Drawing.Point(33, 256);
            this.txt_Mdp.Name = "txt_Mdp";
            this.txt_Mdp.Size = new System.Drawing.Size(340, 21);
            this.txt_Mdp.TabIndex = 8;
            this.txt_Mdp.UseSystemPasswordChar = true;
            this.txt_Mdp.TextChanged += new System.EventHandler(this.txt_Mdp_TextChanged);
            // 
            // lab_Erreur
            // 
            this.lab_Erreur.AutoSize = true;
            this.lab_Erreur.BackColor = System.Drawing.Color.DarkRed;
            this.lab_Erreur.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Erreur.ForeColor = System.Drawing.Color.White;
            this.lab_Erreur.Location = new System.Drawing.Point(66, 301);
            this.lab_Erreur.Name = "lab_Erreur";
            this.lab_Erreur.Size = new System.Drawing.Size(243, 32);
            this.lab_Erreur.TabIndex = 9;
            this.lab_Erreur.Text = "Echec de la connexion\r\nIdentifiant ou mot de passe incorrect.";
            // 
            // fmr_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Erreur);
            this.Controls.Add(this.txt_Mdp);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Connecter);
            this.Controls.Add(this.lab_Mdp);
            this.Controls.Add(this.txt_Identifiant);
            this.Controls.Add(this.lab_Identifiant);
            this.Controls.Add(this.lab_Titre);
            this.Controls.Add(this.lab_Gestion_Stage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmr_Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Gestion_Stage;
        private System.Windows.Forms.Label lab_Titre;
        private System.Windows.Forms.Label lab_Identifiant;
        private System.Windows.Forms.TextBox txt_Identifiant;
        private System.Windows.Forms.Label lab_Mdp;
        private System.Windows.Forms.Button btn_Connecter;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.TextBox txt_Mdp;
        private System.Windows.Forms.Label lab_Erreur;
    }
}

