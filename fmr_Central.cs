using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_gestion_stagiaires_nour_nadir
{
   
    public partial class btn_Quitter : Form
    {
        //declaration  formulaire centrale
        Form fmr_Liste_Eleve = new fmr_Liste_Eleve();
        public btn_Quitter()
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
    }
}
