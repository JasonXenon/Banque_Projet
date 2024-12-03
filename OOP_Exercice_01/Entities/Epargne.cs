namespace OOP_Exercice_01.Entities;

public class Epargne : Compte
{
    private DateTime dernierRetrait;
    
    public Epargne(string number, Person titulaire)
        : this(number, titulaire, 0)
    {
    }
    
    public Epargne(string number, Person titulaire, double amount)
        : base(number, titulaire, amount)
    {
        this.dernierRetrait = DateTime.Now;
    }

    public override void Retrait(double amount)
    {
        base.Retrait(amount);
        dernierRetrait = new DateTime();
    }

    protected override double CalculInteret()
    {
        return this.Amount * 0.045;
    }
}