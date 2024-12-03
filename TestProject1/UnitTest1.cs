using OOP_Exercice_01.Entities;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Person person = new Person("Jason", "Levecq", new DateTime(1999-06-04));
        Courant c1 = new Courant("123456789", person, 50);

        c1.Amount = 10;
        Assert.Equal(10, c1.Amount);
    }
}