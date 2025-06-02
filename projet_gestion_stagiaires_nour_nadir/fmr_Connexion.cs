using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace projet_gestion_stagiaires_nour_nadir
{
    public partial class fmr_Connexion : Form
    {
        public fmr_Connexion()
        {
            InitializeComponent();
        }

        private void fmr_Connexion_Load(object sender, EventArgs e)
        {
            lab_Erreur.Visible = false;
        }

        private void btn_Quitter_Click(object sender, EventArgs e) => Application.Exit();

        private void txt_Mdp_TextChanged(object sender, EventArgs e) { }

        private void lab_Identifiant_Click(object sender, EventArgs e) { }

        private void lab_Gestion_Stage_Click(object sender, EventArgs e) { }

        private async void btn_Connecter_Click(object sender, EventArgs e)
        {
            string email = txt_Identifiant.Text;
            string motDePasse = txt_Mdp.Text;

            bool estConnecte = await FirebaseAuthClient.ConnexionFirebase(email, motDePasse);

            if (estConnecte)
            {
                lab_Erreur.Visible = false;
                MessageBox.Show("Connexion Réussie !", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                // Si c'est l'admin, ouvre FormAdmin, sinon FormCentral
                if (email.ToLower() == "admin@op.com") 
                {
                    // Si c'est l'admin :
                    var form = new fmr_Liste_Eleve(); //Mode Admin
                }
                else
                {
                    Form fmr_central = new fmr_Central(); // Mode User Normal
                    fmr_central.ShowDialog();
                }

                this.Close();
            }
            else
            {
                lab_Erreur.Visible = true;
                MessageBox.Show("Identifiants incorrects ou inexistant dans Firebase.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

            
        }
    }
}
