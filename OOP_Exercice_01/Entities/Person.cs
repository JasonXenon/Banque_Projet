namespace OOP_Exercice_01.Entities;

public class Person
{
    public string Firstname { get; private set; }
    public string Lastname { get; private set; }
    public DateTime BirthDate { get; private set; }

    public Person(string firstname, string lastname, DateTime birthDate)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.BirthDate = birthDate;
    }

    public static bool operator ==(Person a, Person b)
    {
        return a.Firstname == b.Firstname && a.Lastname == b.Lastname && a.BirthDate == b.BirthDate;
    }
    
    public static bool operator !=(Person a, Person b)
    {
        return a.Firstname != b.Firstname || a.Lastname != b.Lastname || a.BirthDate != b.BirthDate;
    }
}