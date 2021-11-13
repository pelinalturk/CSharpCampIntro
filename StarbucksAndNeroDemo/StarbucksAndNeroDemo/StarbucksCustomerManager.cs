using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNeroDemo
{
    class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _checkService;
        public StarbucksCustomerManager(ICustomerCheckService checkService)
        {
            checkService = _checkService;
        }
        public void Add(Customer customer)
        {
            if (_checkService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
        }
    }
}
