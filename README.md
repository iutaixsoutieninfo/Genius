﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿# Genius## Projet d'alternance LP - Serious Game - 2018-2019_Serious game donné en sujet d'alternance pour la licence professionnelle WEB DEV (2018-2019).Continuité du travail de Nathan Bernard-Roux du jeu Genius._- Professeur responsable : Mickaël Martin-Nevot- Trello : https://trello.com/b/JHR8oOJe/serious-game### Notices d'installation :1. Télécharger le dépôt Git2. Ouvrir le dossier `Assets/Plugins`3. Dézipper l'archive `Plugins.zip`4. Supprimer l'archive `Plugins.zip`5. Lancer le jeu sur _Unity_### Version v0.1- Mise en place du projet- Récupération du travail de Nathan Bernard-Roux### Version v0.2- Mise au point partielle par rapport au GDD- Tests pour voir l'avancée réelle du projet- Mise en place menu complet- Création scène Inscription- Scripts PHP de connexion et d'inscription- Hashage des mots de passe lors de l'inscription### Version v0.3 (A VENIR)- Préparation tutoriel de lancement du jeu après inscription- Envoi de mails après inscription- Système de connexion automatique### <span style='color:green'>Problèmes éventuels</span>#### Crontab non fonctionnelLe crontab est un planificateur de tâches, c'est un outil qui permet de lancer des applications de façon régulière, pratique pour notre serveur pour y lancer les scripts PHP toutes les 10 minutes. S'il n'est pas fonctionnel (la table `present_missions` ne se réactualise pas), alors il suffit de suivre les instructions suivantes :1. Se connecter en SSH au dépôt _alwaysdata_ :    - Se rendre à l'adresse : https://ssh-seriousgameiut.alwaysdata.net/    - Se connecter avec l'utilisateur _seriousgameiut_    - Copier le contenu du fichier `#AUTRES/Alwaysdata/Crontab.txt`    - Taper la commande `crontab -e`     - Effacer toutes les lignes du fichier (`Ctrl + K` pour supprimer une ligne)    - Coller le contenu copié précédemment    - Fermer le crontab (`Ctrl + X` -> `y` -> `Enter`)    - Vérifier le contenu du crontab avec la commande `crontab -l`2. Vérifier que les tables se mettent à jour dans la base de données :    - Se connecter sur _phpMyAdmin_ à la base de données d'_alwaysdata_    - Se rendre à la table `present_missions`    - Vérifier que la _Date_ de chaque tuple change toutes les 10 minutes (devrait correspondre ici à l'heure actuelle)