# Yugen-Dev : Site Web pour Restaurant Sushi Haut de Gamme

Bienvenue sur Yugen-Dev, une application web conçue pour refléter l'expérience culinaire proposée par le restaurant Yūgen.

## Fonctionnalités

- **Design Élégant :** Une interface visuellement attrayante et conviviale.
- **Présentation de plats phares :** Trois plats phares issus des plats présents dans le menu du moment mis en avant avec une description longue.
- **Présentation du Menu :** Afficher un menu soigneusement sélectionné par le chef.
- **Système de Réservation :** Permettre aux utilisateurs connectés de faire des réservations facilement.
- **Système d'avis :** Permettre aux utilisateurs connectés de déposer un avis
- **Comptes Utilisateurs :** Permettre aux clients de créer des comptes pour des expériences personnalisées.
- **Mise en Page Responsive :** Assurer une expérience sans heurts sur tous les appareils.
- **Administration :** Un ensemble de pages d'administrations pour pouvoir intervenir sur les menus, fichiers clients, les réservations et le avis.

## Premiers Pas

1. Clonez ce dépôt.
2. Installez les dépendances avec `dotnet restore`.
3. Configurez les variables d'environnement.
4. Exécutez le serveur de développement avec `dotnet run`.
5. Accédez à l'application sur `http://localhost:5047`.

## Technologies Utilisées

- .NET pour le backend
- Razor Pages pour la partie frontend
- Bootstrap pour le style
- SQLite pour le stockage de la base de données

## Utilisation

- Explorer le menu et effectuer des réservations sur le site web.
- S'inscrire et se connecter afin de débloquer des fonctionnalités personnalisées telles que:
La réservation
Le dépôt d'avis
- Profiter d'une expérience de commande de sushi visuellement atrayante et fluide.

## Structure du répertoire

- **/Views :** Contient les fichiers Razor Pages pour la logique de présentation.
- **/Models :** Modèles de données utilisés par l'application.
- **/Data :** Gestion des données, interaction avec la base de données.
- **/Controllers :** Contrôleurs pour la gestion des requêtes HTTP.
- **/wwwroot :** Fichiers statiques tels que les styles, images, etc.
- **/Areas\Identity\Pages :** Contient les fichiers spécifiques au fonctionnement de l'authentification

## Fichiers de Configuration

- **yugen_dev.csproj :** Fichier de projet dans le format MSBuild pour les projets .NET. Il contient des informations sur la structure, les dépendances, et les configurations du projet yugen-dev.
- **appsettings.json :** Contient les paramètres de configuration générale.
- **Program.cs :** Configuration du démarrage de l'application.
- **.gitignore :** Fichiers ignorés par le dépôt afin d'alléger son poids.

## Les modèles

- **/Models/ErrorViewModel.cs :** Modèle utilisé pour représenter les informations liées aux erreurs survenues dans l'application.
- **/Models/HomeViewModel.cs :** Modèle utilisé pour représenter les données spécifiques à la vue d'accueil de l'application. Ce modèle est généralement utilisé pour transmettre des données du contrôleur à la vue.
- **/Models/Client.cs :** Modèle représentant un client dans la base de données.
- **/Models/Dish.cs :** Modèle représentant un plat dans la base de données.
- **/Models/Menu.cs :** Modèle représentant un menu dans la base de données.
- **/Models/MenuDish.cs :** Modèle faisant le lien entre un plat et un menu dans la base de données.
- **/Models/Reservation.cs :** Modèle représentant une réservation dans la base de données.
- **/Models/Review.cs :** Modèle représentant un dans la base de données.
- **/Models/SeedData.cs :** Contient des données de départ (seeds) qui sont injectées dans la base de données pour permettre des tests initiaux de l'application.
- **/Migrations :** Dossier contenant les migrations de base de données.

## Les contrôleurs

- **/Controllers/HomeController.cs :** gère les actions liées au fonctionnement même de l'application. il contient des actions pour:
(`Index` Action): Afficher les différents éléments de la page d'accueil et de l'application 
(`Booking` et `Create` Action): Gérer la fonctionnalité réservation en fonction de si le client est authentifié ou non 
(`Review` et `CreateReview` Action): Gérer la fonctionnalité avis en fonction de si le client est authentifié ou non
- **/Controllers/AdminClientController.cs :**  gère les actions liées à la gestion des clients dans la partie administrateur
- **/Controllers/AdminDishController.cs :**  gère les actions liées à la gestion des plats dans la partie administrateur
- **/Controllers/AdminMenuController.cs :**  gère les actions liées à la gestion des menus dans la partie administrateur
- **/Controllers/AdminReservationController.cs :**  gère les actions liées à la gestion des réservations dans la partie administrateur
- **/Controllers/AdminReviewController.cs :**  gère les actions liées à la gestion des avis dans la partie administrateur

## Les vues

- **/Views/Home/Index.cshtml :** Contient l'appel vers les partielles suivantes:
_Welcome.cshtml : Page d'accueil
_YugenPresentation.cshtml : Page de présentatio de l'univers
_SignatureDishes.cshtml : Affichage des signatures avec longue description
_menus : affichage du menu du moment
_Reviews : affichage des avis postés
_YugenGallery : galerie d'image en bas de page, juste avant le footer

- **/Views/Shared/_Layout.cshtml :** Base contenant la navbar du site
- **/Views/Shared/_Footer.cshtml :** Le footer

- **/Views/AdminClient :** Cet emplacement contient les vues dédiées à l'interface d'administration pour les opérations CRUD relatives aux clients.
- **/Views/AdminDish :** Cet emplacement contient les vues dédiées à l'interface d'administration pour les opérations CRUD relatives aux plats.
- **/Views/AdminMenu :** Cet emplacement contient les vues dédiées à l'interface d'administration pour les opérations CRUD relatives aux menus.
- **/Views/AdminReservation :** Cet emplacement contient les vues dédiées à l'interface d'administration pour les opérations CRUD relatives aux réservations.
- **/Views/AdminReview :** Cet emplacement contient les vues dédiées à l'interface d'administration pour les opérations CRUD relatives aux avis.

## Areas\Identity\Pages

- **/Areas/Identity/Pages/Account:** La racine contient les différentes vues relatives aux page de connexion inscription
- **/Areas/Identity/Pages/Account/Manage:** Cette partie contient les vues liées à l'espace de gestion utilisateur