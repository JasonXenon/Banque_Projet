using System.Runtime.InteropServices;

namespace OOP_Exercice_01.Entities;

public class Courant : Compte
{
    private double _LigneDeCredit;

    public double LigneDeCredit
    {
        get
        {
            return _LigneDeCredit;
        }
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException();
            }
            
            _LigneDeCredit = value;
        }
    }

    public Courant(string number, Person titulaire)
        : this(number, titulaire, 50, 0)
    {
    }
    
        
    public Courant(string number, Person titulaire, double ligneDeCredit)
        : this(number, titulaire, ligneDeCredit, 0)
    {
    }
    
    public Courant(string number, Person titulaire, double ligneDeCredit, double amount)
        : base(number, titulaire, amount)
    {
        this.LigneDeCredit = ligneDeCredit;
    }

    protected override double CalculInteret()
    {
        // if (this.Amount < 0)
        // {
        //     return this.Amount * 0.03;
        // }
        //
        // return this.Amount * 0.0975;
        return this.Amount < 0 ? this.Amount * 0.03 : this.Amount * 0.0975;
    }
}