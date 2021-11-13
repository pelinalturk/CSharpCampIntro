using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TasitKrediManager : ICrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı.");
        }
    }
}
