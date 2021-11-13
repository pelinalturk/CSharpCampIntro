using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DataBaseLoggerService(), new FileLoggerService()});

            List<ICrediManager> credis = new List<ICrediManager>() {ihtiyacKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(credis);
        }
    }
}
