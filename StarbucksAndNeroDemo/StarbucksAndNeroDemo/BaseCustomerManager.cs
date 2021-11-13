using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNeroDemo
{
    class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added : " + customer.Name);
        }
    }
}
