using System;

namespace StarbucksAndNeroDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StarbucksCustomer starbucksCustomer = new StarbucksCustomer() { Id=1,Name="Pelin",Surname="Altürk",DateOfBirth=new System.DateTime(2001,04,21),City="Kocaeli"};
            BaseCustomerManager baseCustomer = new StarbucksCustomerManager(new PersonCheckManager());
            baseCustomer.Add(starbucksCustomer);
        }
    }
}
