using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace projet_gestion_stagiaires_nour_nadir
{
   
    public partial class fmr_Central : Form
    {
        //declaration  formulaire centrale
        Form fmr_Liste_Eleve = new fmr_Liste_Eleve();
        public fmr_Central()
        {
            InitializeComponent();
        }

        private void lab_Titre_2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmr_Central_Load(object sender, EventArgs e)
        {

        }

        private void btn_Valider_Liste_Click(object sender, EventArgs e)
        {
            // affichage du formulaire centrale
            fmr_Liste_Eleve.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //quitter l'application
            Application.Exit();
        }

        private void lab_Explication_Recherche_Click(object sender, EventArgs e)
        {

        }

        private void lab_Rchr_Facile_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lab_Explication_Fichhe_Detaille_Click(object sender, EventArgs e)
        {

        }

        private void lab_Explication_Contact_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lab_Titre_Bienvenue_Click(object sender, EventArgs e)
        {

        }
    }
}
