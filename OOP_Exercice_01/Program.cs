using System;
using OOP_Exercice_01.Entities;
using OOP_Exercice_01.Interfaces;

namespace OOP_Exercice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person("asd", "asdf", DateTime.Now);
            
            Courant c1 = new Courant("123456789", p, 500);
            Courant c2 = new Courant("123456789", p);

            Bank b = new Bank("asdf");
            
            b.AjouterCompte(c1);
            
            ClientConnect(c1);
            BankConnect(c1);
        }

        public static void ClientConnect(ICustomer customer)
        {
            
        }
        
        public static void BankConnect(IBanker banker)
        {
            
        }
    }
}