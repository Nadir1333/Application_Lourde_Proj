using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms.VisualStyles;


namespace projet_gestion_stagiaires_nour_nadir
{
    public partial class fmr_Contact : Form
    {
        private string email;
        private string telephone;
        private string option;
        private string lycee;
        private Eleve eleve;


        public fmr_Contact(string nom, string prenom, string classe, string email, string telephone, string option , string lycee)
        {
            InitializeComponent();
            this.email = email;
            this.telephone = telephone;
            this.option = option;
            this.lycee = lycee;
           
            
            lblNom.Text = "Nom : " + nom;
            lblPrenom.Text = "Prénom : " + prenom;
            lblClasse.Text = "Classe : " + classe;
            lblEmail.Text = "Email : " + email;
            lblTel.Text = "Téléphone : " + telephone;
            lblOption.Text = "Option : "   +option;
            lblLycee.Text = "Lycée : " + lycee;


        }

        private void fmr_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnvoyerMail_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(email))
                {
                    Process.Start(new ProcessStartInfo("mailto:" + email) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Aucune adresse email disponible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void lblLycee_Click(object sender, EventArgs e)
        {

        }
    }
}
