using System.ComponentModel;
using System.Runtime.Versioning;
using System.Security.Cryptography;

namespace OOP_Exercice_01.Entities;

public class Bank
{
    public string Name { get; private set; }
    private Dictionary<string, Compte> _Accounts;

    public Bank(string name)
    {
        this.Name = name;
        this._Accounts = new Dictionary<string, Compte>();
    }

    public Compte this[string index]
    {
        get
        {
            Compte compte;
            this._Accounts.TryGetValue(index, out compte);
            return compte;
        }
        set
        {
            this._Accounts[index] = value;
        }
    }

    public void AjouterCompte(Compte compte)
    {
        this._Accounts.Add(compte.Number, compte);
    }

    public void Supprimer(string numero)
    {
        this._Accounts.Remove(numero);
    }

    public double AvoirDesComptes(Person p)
    {
        double montant = 0.0d;
        foreach (Compte compte in _Accounts.Values)
        {
            if (compte.Titulaire == p)
            {
                montant += compte;
            }
        }

        return montant;
    }
}