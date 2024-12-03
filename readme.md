# OOP Exercice 01

Ce projet est un exercice d'application des principes de la programmation orientée objet (POO) en C#. Il modélise une structure bancaire simple comprenant des comptes courants, des comptes bancaires génériques, des titulaires, et une banque.

## 🛠 Fonctionnalités principales

### Entités

1. **Person** :
    - Représente un individu avec un prénom, un nom, et une date de naissance.
    - Définit des opérateurs `==` et `!=` pour comparer les personnes.

2. **Compte (Compte bancaire)** :
    - Classe abstraite représentant un compte bancaire générique.
    - Attributs : numéro de compte, titulaire, montant.
    - Méthodes principales :
        - `Depot(double montant)` : Déposer de l'argent.
        - `Retrait(double montant)` : Retirer de l'argent (avec gestion des exceptions si le solde est insuffisant).
        - `AppliquerInteret()` : Applique les intérêts calculés par la méthode abstraite `CalculInteret`.

3. **Courant (Compte courant)** :
    - Hérite de `Compte` et ajoute une ligne de crédit.
    - Implémente une méthode pour calculer les intérêts spécifiques (3% pour les soldes négatifs, 9.75% pour les soldes positifs).

4. **Bank** :
    - Gère un ensemble de comptes bancaires.
    - Fournit des méthodes pour ajouter, supprimer des comptes, et calculer les avoirs d'un titulaire.

### Interfaces

1. **ICustomer** :
    - Définit les opérations de base : dépôt et retrait d'argent.

2. **IBanker** :
    - Étend `ICustomer` et ajoute des propriétés spécifiques aux banquiers comme le numéro de compte et l'application d'intérêts.

### Exceptions

1. **SoldeInsuffisantException** :
    - Exception levée lorsque le montant d'un retrait dépasse le solde du compte.

## ⚙️ Architecture

- Le projet suit les principes de l'encapsulation, de l'héritage et de la modularité.
- Les classes abstraites et les interfaces permettent une extension et une réutilisation aisées.

## 🏃‍♂️ Utilisation

1. **Créer une Personne :**
   ```csharp
   var person = new Person("Jean", "Dupont", new DateTime(1985, 5, 15));
