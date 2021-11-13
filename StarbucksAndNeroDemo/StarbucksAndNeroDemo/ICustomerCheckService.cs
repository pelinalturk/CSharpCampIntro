using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNeroDemo
{
    interface ICustomerCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
