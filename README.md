# Application_Lourde_Proj

> **Projet de gestion de stagiaires / élèves – Windows Forms – C# / .NET**

---

## 🚀 Présentation

Cette application permet de **gérer une liste d'élèves ou de stagiaires** pour une entreprise ou un établissement scolaire.  
Elle a été développée dans le cadre de la formation BTS SIO – Projet pédagogique personnel.

### Fonctionnalités principales

- **Authentification** (Connexion classique et Admin)
- **Visualisation** de tous les élèves dans un tableau interactif (DataGridView)
- **Recherche, filtrage** par classe et option (SLAM/SISR/etc)
- **Ajout, suppression** d'élèves (mode Admin uniquement)
- **Affichage des détails** d'un élève (formulaire pop-up)
- **Connexion à Firebase** pour stocker/récupérer les données
- Interface claire et adaptée au suivi de stagiaires

---

## 📸 Captures d’écran

> *(Ajoute ici des screenshots de ton application en fonctionnement, pour donner envie de tester !)*

---

## ⚙️ Installation

### Prérequis

- Windows 10/11
- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/fr/)
- [.NET Framework 4.7.2+](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
- Un compte [Firebase](https://firebase.google.com/) (pour la connexion/données)

### Étapes

1. **Clone le projet :**
    ```bash
    git clone https://github.com/Nadir1333/Application_Lourde_Proj.git
    ```
2. **Ouvre le dossier dans Visual Studio** (`.sln`)
3. **Ajoute tes informations Firebase :**  
    Dans le fichier de configuration ou directement dans le code (`FirebaseClient.cs`), mets tes credentials Firebase.
4. **Build & exécute :**  
    Clique sur "Démarrer" ou appuie sur `F5` dans Visual Studio.

---

## 👨‍💻 Utilisation

- **Connexion admin :**  
  Identifiant admin → `admin@op.com` (modifiable dans le code)
- **Connexion classique :**  
  Un compte standard créé dans Firebase
- **Ajouter/Supprimer :**  
  Boutons visibles uniquement en mode admin

---

## 📝 Structure du projet

