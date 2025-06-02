
namespace projet_gestion_stagiaires_nour_nadir
{
    partial class fmr_Liste_Eleve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ///<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbFiltreOption = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.BackColor = System.Drawing.Color.White;
            this.btn_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quitter.ForeColor = System.Drawing.Color.Red;
            this.btn_Quitter.Location = new System.Drawing.Point(1146, 621);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(138, 31);
            this.btn_Quitter.TabIndex = 0;
            this.btn_Quitter.Text = "Se Déconnecter";
            this.btn_Quitter.UseVisualStyleBackColor = false;
            this.btn_Quitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(376, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tableau de Bord Tuteur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 581);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(227, 39);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(200, 20);
            this.txtRecherche.TabIndex = 0;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(1040, 94);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 26);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(1040, 39);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(100, 26);
            this.btnReinitialiser.TabIndex = 0;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // cmbClasse
            // 
            this.cmbClasse.Items.AddRange(new object[] {
            "Tous",
            "BTS SIO",
            "BTS CG",
            "BTS MCO",
            "BTS SAM"});
            this.cmbClasse.Location = new System.Drawing.Point(514, 39);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(121, 21);
            this.cmbClasse.TabIndex = 3;
            this.cmbClasse.SelectedIndexChanged += new System.EventHandler(this.cmbClasse_SelectedIndexChanged);
            // 
            // cmbFiltreOption
            // 
            this.cmbFiltreOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreOption.Items.AddRange(new object[] {
            "Toutes les options",
            "SLAM",
            "SISR"});
            this.cmbFiltreOption.Location = new System.Drawing.Point(734, 38);
            this.cmbFiltreOption.Name = "cmbFiltreOption";
            this.cmbFiltreOption.Size = new System.Drawing.Size(150, 21);
            this.cmbFiltreOption.TabIndex = 4;
            this.cmbFiltreOption.SelectedIndexChanged += new System.EventHandler(this.cmbFiltreOption_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1040, 268);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(126, 46);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter un élèves";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(1040, 391);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(143, 48);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer un élèves";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // fmr_Liste_Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 664);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.cmbFiltreOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fmr_Liste_Eleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_Liste_Eleve";
            this.Load += new System.EventHandler(this.fmr_Liste_Eleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quitter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbFiltreOption;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}