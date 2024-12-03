namespace OOP_Exercice_01.Interfaces;

public interface ICustomer
{
    public double Amount { get; }
    
    void Depot(double montant);
    void Retrait(double montant);
}