using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : ICrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı.");
        }
    }
}
