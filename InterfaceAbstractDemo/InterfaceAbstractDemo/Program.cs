using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Entities.Customer { DateOfBirth= new System.DateTime(1985,1,6), FirstName="Engin", LastName="Demiroğ", NationalityId="28861499108"} );            
        }
    }
}
