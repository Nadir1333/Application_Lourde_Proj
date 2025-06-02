using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projet_gestion_stagiaires_nour_nadir
{
    // Classe représentant un élève (structure JSON)
    public class Eleve
    {
        public string Nom { get; set; }        // Le nom de l’élève
        public string Prenom { get; set; }     // Le prénom de l’élève
        public string Classe { get; set; }     // La classe (ex : BTS SIO)
        public string Email { get; set; }      // L'adresse email
        public string Numero { get; set; }     // Le numéro de téléphone
        public string Ville { get; set; }      // exemple : "Lyon"
        public string Lycee { get; set; }      // Le nom du lycée (ex : "Lycée Jean Jaurès")
        public string Option { get; set; }         // SLAM ou SISR - facultatif

    }

    // Classe static pour gérer Firebase
    public static class FirebaseClient
    {
        // URL de ta base Firebase (doit absolument se terminer par un "/")
        private static readonly string baseUrl = "https://projet-gestion-entreprise-default-rtdb.europe-west1.firebasedatabase.app/";

        // Client HTTP utilisé pour communiquer avec Firebase
        private static readonly HttpClient client = new HttpClient();

        // Méthode pour ajouter un élève dans la base
        public static async Task AjouterEleve(Eleve eleve)
        {
            // On convertit l'élève en JSON
            var json = JsonConvert.SerializeObject(eleve);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Envoi du JSON à Firebase (dans le noeud "eleves")
            var response = await client.PostAsync(baseUrl + "eleves.json", content);
            response.EnsureSuccessStatusCode(); // Lance une erreur si l'envoi a échoué
        }

        // Méthode pour récupérer tous les élèves depuis Firebase
        public static async Task<Dictionary<string, Eleve>> RecupererEleves()
        {
            // On envoie une requête GET à Firebase
            var response = await client.GetAsync(baseUrl + "eleves.json");
            response.EnsureSuccessStatusCode();

            // Lecture et désérialisation des données reçues
            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<Dictionary<string, Eleve>>(json);

            // On retourne la liste, ou une liste vide si null
            return data ?? new Dictionary<string, Eleve>();
        }
        public static async Task SupprimerEleveParEmail(string email)
        {
            var eleves = await RecupererEleves();
            string keyToDelete = null;
            foreach (var pair in eleves)
            {
                if (pair.Value.Email == email)
                {
                    keyToDelete = pair.Key;
                    break;
                }
            }
            if (keyToDelete != null)
            {
                var url = baseUrl + $"eleves/{keyToDelete}.json";
                var response = await client.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
