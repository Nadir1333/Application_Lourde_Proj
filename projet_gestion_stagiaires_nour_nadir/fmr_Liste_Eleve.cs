using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using projet_gestion_stagiaires_nour_nadir;


namespace projet_gestion_stagiaires_nour_nadir
{
    public partial class fmr_Liste_Eleve : Form
    {
        private bool isAdmin;
        
        // Un seul constructeur avec l’option admin (par défaut false)
        public fmr_Liste_Eleve(bool isAdmin = false)
        {
            MessageBox.Show("Début constructeur !");
            InitializeComponent();
            this.isAdmin = isAdmin;
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nom = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                string prenom = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                string classe = dataGridView1.Rows[e.RowIndex].Cells[2].Value?.ToString();
                string email = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString();
                string tel = dataGridView1.Rows[e.RowIndex].Cells[4].Value?.ToString();
                string option = dataGridView1.Rows[e.RowIndex].Cells[7].Value?.ToString();
                string lycee = dataGridView1.Rows[e.RowIndex].Cells[6].Value?.ToString();
                fmr_Contact contact = new fmr_Contact(nom, prenom, classe, email, tel , option , lycee );
                
                contact.ShowDialog();
            }
        }

        // Chargement automatique des élèves depuis Firebase
        private async void fmr_Liste_Eleve_Load(object sender, EventArgs e)

        {
            MessageBox.Show("Début du chargement des élèves");

            try
            {

                // Configuration des colonnes du DataGridView
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Nom";
                dataGridView1.Columns[1].Name = "Prénom";
                dataGridView1.Columns[2].Name = "Classe";
                dataGridView1.Columns[3].Name = "Email";
                dataGridView1.Columns[4].Name = "Téléphone";
                dataGridView1.Columns[5].Name = "Ville";
                dataGridView1.Columns[6].Name = "Lycée";
                dataGridView1.Columns[7].Name = "Option";

                btnAjouter.Visible = isAdmin;
                btnSupprimer.Visible = isAdmin;


                // On vide le tableau avant d'ajouter quoi que ce soit
                dataGridView1.Rows.Clear();

                // Récupère les élèves existants depuis Firebase
                var eleves = await FirebaseClient.RecupererEleves();



                // Si la base est vide, on injecte des élèves 
                if (eleves.Count == 0)
                {
                    List<Eleve> nouveauxEleves = new List<Eleve>
                {
                    new Eleve { Nom = "Martin", Prenom = "Lucas", Classe = "BTS SIO", Email = "lucas.martin@exemple.com", Numero = "0601020304", Ville = "Marseille", Lycee = "lycée Marie Curie", Option = "SISR" },
                    new Eleve { Nom = "Dubois", Prenom = "Clara", Classe = "BTS CG", Email = "clara.dubois@exemple.com", Numero = "0611121314", Ville = "Lyon", Lycee = "Lycée Lumière", },
                    new Eleve { Nom = "Leroy", Prenom = "Hugo", Classe = "BTS MCO", Email = "hugo.leroy@exemple.com", Numero = "0622233445", Ville = "Grenoble", Lycee = "Lycée Saint Louis" },
                    new Eleve { Nom = "Lefèvre", Prenom = "Emma", Classe = "BTS SAM", Email = "emma.lefevre@exemple.com", Numero = "0633344556", Ville = "Cannes", Lycee = "Lycée Lumière" },
                    new Eleve { Nom = "Moreau", Prenom = "Nathan", Classe = "BTS SIO", Email = "nathan.moreau@exemple.com", Numero = "0644455667", Ville = "Montpellier", Lycee = "Lycée Charles", Option = "SLAM" },
                    new Eleve { Nom = "Fournier", Prenom = "Inès", Classe = "BTS CG", Email = "ines.fournier@exemple.com", Numero = "0655566778", Ville = "Nice", Lycee = "Lycée Saint" },
                    new Eleve { Nom = "Girard", Prenom = "Enzo", Classe = "BTS MCO", Email = "enzo.girard@exemple.com", Numero = "0666677889", Ville = "Paris", Lycee = "Lycée Lumière" },
                    new Eleve { Nom = "Petit", Prenom = "Léa", Classe = "BTS SAM", Email = "lea.petit@exemple.com", Numero = "0677788990", Ville = "Paris", Lycee = "Lycée Lumière" },
                    new Eleve { Nom = "Garcia", Prenom = "Thomas", Classe = "BTS SIO", Email = "thomas.garcia@exemple.com", Numero = "0688899001", Ville = "Lyon", Lycee = "Lycée Lumière", Option = "SISR" },
                    new Eleve { Nom = "Laurent", Prenom = "Jade", Classe = "BTS CG", Email = "jade.laurent@exemple.com", Numero = "0699900112", Ville = "Monaco", Lycee = "Lycée Jean", },
                    new Eleve { Nom = "Renault", Prenom = "Adam", Classe = "BTS MCO", Email = "adam.renault@exemple.com", Numero = "0700011223", Ville = "Saint-etienes", Lycee = "Lycée Marge ", },
                    new Eleve { Nom = "Marchand", Prenom = "Eva", Classe = "BTS SAM", Email = "eva.marchand@exemple.com", Numero = "0711122334", Ville = "Rennes", Lycee = "Lycée Renaud", },
                    new Eleve { Nom = "Blanc", Prenom = "Léo", Classe = "BTS SIO", Email = "leo.blanc@exemple.com", Numero = "0722233445", Ville = "Angers", Lycee = "Lycée Partes", Option = "SLAM" },
                    new Eleve { Nom = "Gauthier", Prenom = "Zoé", Classe = "BTS CG", Email = "zoe.gauthier@exemple.com", Numero = "0733344556", Ville = "Paris", Lycee = "Lycée Franc", },
                    new Eleve { Nom = "Chevalier", Prenom = "Maxime", Classe = "BTS MCO", Email = "maxime.chevalier@exemple.com", Numero = "0744455667", Ville = "Aubagne", Lycee = "Lycée Sainte Drome" },
                    new Eleve { Nom = "Robin", Prenom = "Manon", Classe = "BTS SAM", Email = "manon.robin@exemple.com", Numero = "0755566778", Ville = "Marseille", Lycee = "Lycée Marie curie ", },
                    new Eleve { Nom = "Masson", Prenom = "Nolan", Classe = "BTS SIO", Email = "nolan.masson@exemple.com", Numero = "0766677889", Ville = "Marseille", Lycee = "Lycée Marie Curie", Option = "SLAM" },
                    new Eleve { Nom = "Perrin", Prenom = "Chloé", Classe = "BTS SIO", Email = "chloe.perrin@exemple.com", Numero = "0777788990", Ville = "Marseille", Lycee = "Lycée Marie Curie", Option = "SISR" },
                    new Eleve { Nom = "Garnier", Prenom = "Axel", Classe = "BTS SIO", Email = "axel.garnier@exemple.com", Numero = "0788899001", Ville = "Marseille", Lycee = "Lycée Marie curie", Option = "SLAM" },
                    new Eleve { Nom = "Faure", Prenom = "Camille", Classe = "BTS SIO", Email = "camille.faure@exemple.com", Numero = "0799900112", Ville = "Marseille", Lycee = "Lycée Marie curie", Option = "SISR" },
                    new Eleve { Nom = "Bernard", Prenom = "Lucie", Classe = "BTS SIO ", Email = "lucie.bernard@exemple.com", Numero = "0601010101", Ville = "Marseille", Lycee = "Lycée Marie curie", Option = "SISR" },
                    new Eleve { Nom = "Bernard", Prenom = "Lucie", Classe = "BTS SIO", Email = "lucie.bernard@exemple.com", Numero = "0601010101", Ville = "Lyon", Lycee = "Lycée Lumière", Option = "SISR" },
                    new Eleve { Nom = "Morel", Prenom = "Arthur", Classe = "BTS SIO", Email = "arthur.morel@exemple.com", Numero = "0601020304", Ville = "Toulouse", Lycee = "Lycée Déodat", Option = "SLAM" },
                    new Eleve { Nom = "Leclerc", Prenom = "Chloé", Classe = "BTS SIO", Email = "chloe.leclerc@exemple.com", Numero = "0601122334", Ville = "Paris", Lycee = "Lycée Louis-le-Grand", Option = "SISR" },
                    new Eleve { Nom = "Garcia", Prenom = "Noah", Classe = "BTS SIO", Email = "noah.garcia@exemple.com", Numero = "0601234567", Ville = "Lille", Lycee = "Lycée Faidherbe", Option = "SLAM" },
                    new Eleve { Nom = "Dubois", Prenom = "Emma", Classe = "BTS SIO", Email = "emma.dubois@exemple.com", Numero = "0601345798", Ville = "Nice", Lycee = "Lycée Masséna", Option = "SISR" },
                    new Eleve { Nom = "Lemoine", Prenom = "Tom", Classe = "BTS SIO", Email = "tom.lemoine@exemple.com", Numero = "0601456789", Ville = "Nantes", Lycee = "Lycée Clémenceau", Option = "SLAM" },
                    new Eleve { Nom = "Roux", Prenom = "Jade", Classe = "BTS SIO", Email = "jade.roux@exemple.com", Numero = "0601567890", Ville = "Bordeaux", Lycee = "Lycée Montaigne", Option = "SISR" },
                    new Eleve { Nom = "Meyer", Prenom = "Léo", Classe = "BTS SIO", Email = "leo.meyer@exemple.com", Numero = "0601678901", Ville = "Strasbourg", Lycee = "Lycée Kléber", Option = "SLAM" },
                    new Eleve { Nom = "Marchand", Prenom = "Inès", Classe = "BTS SIO", Email = "ines.marchand@exemple.com", Numero = "0601789012", Ville = "Rennes", Lycee = "Lycée Chateaubriand", Option = "SISR" },
                    new Eleve { Nom = "Robin", Prenom = "Ethan", Classe = "BTS SIO", Email = "ethan.robin@exemple.com", Numero = "0601890123", Ville = "Marseille", Lycee = "Lycée Thiers", Option = "SLAM" },
                    new Eleve { Nom = "Henry", Prenom = "Lina", Classe = "BTS SIO", Email = "lina.henry@exemple.com", Numero = "0601901234", Ville = "Rouen", Lycee = "Lycée Jeanne-d’Arc", Option = "SISR" },
                    new Eleve { Nom = "Faivre", Prenom = "Yanis", Classe = "BTS SIO", Email = "yanis.faivre@exemple.com", Numero = "0602012345", Ville = "Angers", Lycee = "Lycée David-d'Angers", Option = "SLAM" },
                    new Eleve { Nom = "Garnier", Prenom = "Élise", Classe = "BTS SIO", Email = "elise.garnier@exemple.com", Numero = "0602123456", Ville = "Dijon", Lycee = "Lycée Carnot", Option = "SISR" },
                    new Eleve { Nom = "Masson", Prenom = "Clément", Classe = "BTS SIO", Email = "clement.masson@exemple.com", Numero = "0602234567", Ville = "Le Havre", Lycee = "Lycée Schuman", Option = "SLAM" },
                    new Eleve { Nom = "Rodriguez", Prenom = "Ava", Classe = "BTS SIO", Email = "ava.rodriguez@exemple.com", Numero = "0602345678", Ville = "Reims", Lycee = "Lycée Libergier", Option = "SISR" },
                    new Eleve { Nom = "Lopez", Prenom = "Mathis", Classe = "BTS SIO", Email = "mathis.lopez@exemple.com", Numero = "0602456789", Ville = "Clermont-Ferrand", Lycee = "Lycée Blaise Pascal", Option = "SLAM" },
                    new Eleve { Nom = "Fontaine", Prenom = "Camille", Classe = "BTS SIO", Email = "camille.fontaine@exemple.com", Numero = "0602567890", Ville = "Nancy", Lycee = "Lycée Poincaré", Option = "SISR" },
                    new Eleve { Nom = "Renaud", Prenom = "Nina", Classe = "BTS SIO", Email = "nina.renaud@exemple.com", Numero = "0602678901", Ville = "Besançon", Lycee = "Lycée Jules Haag", Option = "SLAM" },
                    new Eleve { Nom = "Chevalier", Prenom = "Enzo", Classe = "BTS SIO", Email = "enzo.chevalier@exemple.com", Numero = "0602789012", Ville = "Tours", Lycee = "Lycée Balzac", Option = "SISR" },
                    new Eleve { Nom = "Barbier", Prenom = "Sarah", Classe = "BTS SIO", Email = "sarah.barbier@exemple.com", Numero = "0602890123", Ville = "Grenoble", Lycee = "Lycée Champollion", Option = "SLAM" }

                };

                    foreach (var eleve in nouveauxEleves)
                    {
                        await FirebaseClient.AjouterEleve(eleve); // Ajoute dans Firebase
                    }

                    // Recharge les élèves après insertion
                    eleves = await FirebaseClient.RecupererEleves();

                }

                // Affichage dans le DataGridView
                foreach (var eleve in eleves.Values)
                {
                    dataGridView1.Rows.Add(eleve.Nom, eleve.Prenom, eleve.Classe, eleve.Email, eleve.Numero, eleve.Ville, eleve.Lycee, eleve.Option);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des élèves : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }





        //Bouton pour renitialiser la recherche
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
        }
        
        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classe = cmbClasse.SelectedItem.ToString();
            

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Ignore la dernière ligne vide

                    row.Visible = (classe == "Tous" ||
                                   (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == classe));
                }

            
        }

        //Bouton pour rechercher un éleve dans le tableau
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool visible =
                    row.Cells[0].Value.ToString().ToLower().Contains(recherche) || // Nom
                    row.Cells[1].Value.ToString().ToLower().Contains(recherche);  // Prénom

                row.Visible = visible;
            }
        }
        //FILTRE LES OPTION BTS 
        private void cmbFiltreOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            string optionChoisie = cmbFiltreOption.SelectedItem.ToString();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string optionCellule = row.Cells["Option"].Value?.ToString() ?? "";

                // Afficher toutes les options
                if (optionChoisie == "Toutes les options")
                {
                    row.Visible = true;
                }
                else
                {
                    // Afficher uniquement SLAM ou SISR
                    row.Visible = optionCellule.Equals(optionChoisie, StringComparison.OrdinalIgnoreCase);
                }
            }
        }
        




        private void importer_Click(object sender, EventArgs e)
        {
            // Optionnel : importer depuis Excel plus tard
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        
    }
}
