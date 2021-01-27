using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
