# Application de gestion de stagiaires

**Projet BTS SIO — Application lourde C# WinForms connectée à Firebase**

---

## 📦 Présentation

Cette application permet de **gérer une liste d’élèves/stagiaires** en entreprise :
- Ajout, suppression, visualisation des élèves
- Filtres avancés par option, classe, recherche…
- Gestion des droits (mode admin/prof, boutons cachés pour les non-admins)
- Connexion sécurisée via Firebase Authentication

L’interface a été pensée pour être claire, rapide et adaptée aux besoins des entreprises comme des enseignants.

---

## 🔥 Fonctionnalités principales

- **Connexion par identifiant/mot de passe (Firebase Auth)**
- **Affichage dynamique des élèves depuis Firebase**
- **Ajout/suppression d’élèves** (mode admin uniquement)
- **Recherche et filtres multicritères** (nom, prénom, classe, option)
- **Contact d’un élève** (pop-up fiche élève)
- **Interface adaptée au rôle :**  
  - Les boutons « Ajouter/Supprimer » sont visibles seulement pour l’admin
  - Les autres utilisateurs voient la liste en lecture seule

---

## 🖥️ Technologies utilisées

- **C# / .NET (WinForms)**
- **Firebase** (Realtime Database + Authentification)
- Visual Studio 2022/2019  
- Git & GitHub

---

## 🚀 Installation

1. **Cloner le dépôt**
    ```bash
    git clone https://github.com/Nadir1333/Application_Lourde_Proj.git
    ```
2. **Ouvrir le projet sous Visual Studio**  
   Fichier → Ouvrir → Projet/Solution → Sélectionner `.sln`

3. **Vérifier la connexion Firebase**
    - Renseigner les paramètres Firebase dans le code si besoin (fichier `FirebaseClient.cs`)

4. **Lancer l’application**
    - Appuyer sur `F5` (ou bouton "démarrer") dans Visual Studio

---

## ⚙️ Configuration Firebase (à adapter selon ton projet)

> 🔒 Les identifiants Firebase ne sont pas inclus dans ce repo pour des raisons de sécurité.  
> Pour l’intégration, renseigner l’URL de la Realtime Database et les clés API dans le fichier concerné.

---

## 👤 Gestion des droits (mode admin/prof)

- L’**admin** se connecte avec un email/mot de passe défini (ex: `admin@op.com`)
- **Seul l’admin** peut ajouter ou supprimer des élèves.
- Les profs/visiteurs peuvent uniquement consulter les listes.

---


