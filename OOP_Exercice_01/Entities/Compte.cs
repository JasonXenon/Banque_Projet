using OOP_Exercice_01.Exceptions;
using OOP_Exercice_01.Interfaces;

namespace OOP_Exercice_01.Entities;

public abstract class Compte : ICustomer, IBanker
{
    private string _Number;

    public string Number
    {
        get
        {
            return _Number;
        }
        protected set
        {
            _Number = value;
        }
    }

    public double Amount  { get; set; }
    private Person _Titulaire;
    public Person Titulaire { get
        {
            return _Titulaire;
        } protected set
        {
            _Titulaire = value;
        } 
    }

    public Compte(string number, Person titulaire)
        : this(number, titulaire, 0)
    {
    }

    public Compte(string number, Person titulaire, double amount)
    {
        this.Number = number;
        this.Titulaire = titulaire;
        this.Amount = 0;
    }
    
    public static double operator +(Compte a, Compte b)
    {
        return a.Amount + b.Amount;
    }
    
    public static double operator +(double a, Compte b)
    {
        return a + b.Amount;
    }
    
    public virtual void Retrait(double amount)
    {
        if (amount > this.Amount)
        {
            throw new SoldeInsuffisantException();
        }
        this.Amount -= amount;
    }

    public virtual void Depot(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        
        this.Amount += amount;
    }

    protected abstract double CalculInteret();

    public void AppliquerInteret()
    {
        this.Amount += this.CalculInteret();
    }
}