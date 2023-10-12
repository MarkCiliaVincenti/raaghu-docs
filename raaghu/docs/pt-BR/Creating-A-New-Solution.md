# Création d'une nouvelle solution
## Création d'un nouveau projet
Il y a deux façons de créer un nouveau projet : BP Suite et BP LI
### Utiliser une série d'amplification pour créer un nouveau projet.
ABP Suite est recommandé pour créer de nouvelles solutions pour le BP Commercial

Runir la suite BP avec la commande suivante :

       abp suite


- Cette commande commence la suite BP et s'ouvre dans votre navigateur par défaut :

![Créer une nouvelle solution](./images/createANewSol.png "")

Cliquez sur le bouton Créer un nouveau bouton de solution et remplissez le formulaire modal :

![Créer une nouvelle solution pour la forme modale](./images/createSol.png "createSol")

Choisissez le cadre de UI comme « raaghu-réact », Database Provider et d'autres options fondées sur vos préférences, puis cliquez sur le bouton « De »
### Utiliser la falaise d'amplification pour créer un nouveau projet
Utiliser la nouvelle commande du BP LI pour créer un nouveau projet :

       abp new Acme.Bookstore -t app-pro


- -t l'argument spécifie[gabarit de démarrage](https://docs.abp.io/en/commercial/7.2/startup-templates/application/index "")nom. app-pro est le modèle de démarrage qui contient le modèle essentiel.[BP Modules commerciaux](https://commercial.abp.io/modules "")pré-installés et configurés pour vous.
- Nous pouvons également utiliser un niveau différent de lieux de noms, p. ex. Bookstore, Acme.Bookstore ou Came.Retail.Bookstore.

## thème
### Thèmes raaghu-thèmes
Un nouveau thème, moderne et stylish raaghu avec différentes options de couleur, c’est le thème le plus récent. Vous pouvez choisir une des trois options Dark, Light et Semi Dark.
### ⁇  les commandements et les options d'amplification
[Document de l'IAP](https://docs.abp.io/en/abp/latest/CLI "")couvre tous les commandements et toutes les options disponibles pour l'IAPP. La principale différence pour le BP Commercial est le nom du modèle. Voir[BP Modèles de démarrage commercial](https://docs.abp.io/en/commercial/7.2/startup-templates/index "")document pour d'autres modèles commerciaux.
### la structure de la solution
La solution a une structure stratifiée ( basée sur[Conception des conducteurs de champ](https://docs.abp.io/en/abp/Domain-Driven-Design "")) et contient des projets d'essais d'intégration. Voir[document de structure de la solution](https://docs.abp.io/en/commercial/7.2/startup-templates/application/solution-structure "")pour comprendre la structure de la solution en détails.
### prochaine étape

- [Runir la solution](Getting-Started-Running-Solution.md "")

