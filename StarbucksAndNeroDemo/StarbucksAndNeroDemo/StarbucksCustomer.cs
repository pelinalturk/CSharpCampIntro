using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksAndNeroDemo
{
    class StarbucksCustomer:Customer
    {
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
