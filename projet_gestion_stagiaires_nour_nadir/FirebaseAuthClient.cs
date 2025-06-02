using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projet_gestion_stagiaires_nour_nadir
{
    public static class FirebaseAuthClient
    {
        // Remplace ici par ta vraie clé API Web (Firebase > Paramètres du projet)
        private static readonly string apiKey = "AIzaSyCS7aMh6Qs3J3vPHo1vpd-TUsZmB99DmkI";

        private static readonly HttpClient client = new HttpClient();

        // Méthode qui permet de se connecter avec Firebase Authentication
        public static async Task<bool> ConnexionFirebase(string email, string password)
        {
            var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}";

            var data = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);

            return response.IsSuccessStatusCode;
        }
    }
}
