# appBook

# Projet BookManager – API REST en ASP.NET Core avec Clients

Ce projet a été réalisé dans le cadre d’un exercice pédagogique visant à comprendre la création d’une API REST complète avec persistance de données, et son interaction avec différents types de clients : console, web, WPF.

---

## Fonctionnalités

L’API permet de gérer une collection de livres (papier ou électronique) :

- Lister tous les livres
- Rechercher un livre par ID
- Ajouter un livre
- Modifier un livre existant
- Supprimer un livre

Deux types de livres sont gérés :
- `Ebook` (avec un format de fichier, ex: PDF, EPUB)
- `PaperBook` (avec un nombre de pages)

---

# consignes 

# Le travail collectif
Réalisez une API REST en ASP.Net Core
- Permettant la gestion de livres papier et électronique dans une base de
données

Présentant une API REST avec les end-points suivants :
- GET /livres
- GET /livres?q=Author=<nom de l’auteur>&Title=<titre>&sort=<author|title>
- GET /livres/{id}
- POST /livres
- PUT /livres/{id}
- DELETE /livres/{id}

POO complète dans l’API
- Classe de base « Media », 2 classes dérivées « Ebook » et « PaperBook »
- Une interface IReadable avec une méthode DisplayInformation()
- Une classe générique Repository<T> pour gére les accès à la base

Persistance des données dans une base (SQLite ou autre)
Autres attentes :
- Respect du modèle MVC
- Validation des entrées (Data annotation)
- Documentation de l’API en swagger
- Arborescence des branches Git: Main => Develop => <votre nom>
- Fusion du travail dans Develop
- Poussez dans Main le code qui sera noté

# Le travail individuel
Réalisez un client (console, WPF ou web)

Présentant les fonctions :
- Afficher la liste des livres
- Rechercher un livre par titre / auteur
- Ajouter un nouveau livre
- Modifier un livre
- Supprimer un livre

Le client consomme l’API REST (via un httpClient)
- Appels asynchrones (async / await)
- UI simple et sans embellissement mais fonctionnelle
- Avec une gestion d’erreur try / catch pour les appels réseau

Autres attentes :
- API et client sont fonctionnels et indépendants
- Le client doit appeler tous les end-points de l’API

- Pour le projet BookApi (ASP.NET Core API + EF Core + Swagger)
- EF Core avec SQLite
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

- Outils EF Core (pour les migrations)
dotnet add package Microsoft.EntityFrameworkCore.Tools

- Swagger (interface interactive pour tester l'API)
dotnet add package Swashbuckle.AspNetCore

- Pour le projet BookClient.Console (client console avec HttpClient + JSON)
- Pour pouvoir faire des appels HTTP avec JSON (GetFromJsonAsync, PostAsJsonAsync, etc.)
dotnet add package System.Net.Http.Json

- Pour la création et l'exécution de la première migration
dotnet ef migrations add InitialCreate
dotnet ef database update
