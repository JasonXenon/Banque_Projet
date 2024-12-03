using OOP_Exercice_01.Entities;

namespace OOP_Exercice_01.Interfaces;

public interface IBanker : ICustomer
{
    public Person Titulaire { get; }
    public string Number { get; }
    public void AppliquerInteret();
}