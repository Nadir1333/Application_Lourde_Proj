using System;
using System.Windows.Forms;

namespace projet_gestion_stagiaires_nour_nadir
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lancement du formulaire de connexion
            Application.Run(new fmr_Connexion());
        }
    }
}
