using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ouverture bibliotheque Mysql
using MySql.Data.MySqlClient;

namespace projet_gestion_stagiaires_nour_nadir
{
    public partial class fmr_Connexion : Form
    {
        //declaration formulaire centrale
        Form fmr_central = new btn_Quitter();
        public fmr_Connexion()
        {
            InitializeComponent();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            //quitter l'application
            Application.Exit();
        }

        private void txt_Mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Connecter_Click(object sender, EventArgs e)
        {
           // mySqlConnection connexion = new mySqlConnection("")
            //les variables
            string log = txt_Identifiant.Text;
            string pass = txt_Mdp.Text;

            //les conditions
            if (log == "tuteur" && pass == "password")
            {
                lab_Erreur.Visible = false;
                MessageBox.Show("Connexion Réussi. Bienvenue TUTEUR!", "VALIDATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // cache formulaire de connexion
                this.Hide();

                // affichage du formulaire centrale
                fmr_central.ShowDialog();
            }
            else
            {
                //affichage messages erreur connexion
                lab_Erreur.Visible = true;
                MessageBox.Show("vous etes étranger", "ANNULATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





        }

        private void fmr_Connexion_Load(object sender, EventArgs e)
        {
            //gestion message d'erreur
            lab_Erreur.Visible = false;
        }
    }
}
