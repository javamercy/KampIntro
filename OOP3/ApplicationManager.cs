using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // 
            //
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void InfoViewOfCredit(List<ICreditManager> credits)
        {
            foreach (ICreditManager creditManager in credits)
            {
                creditManager.Calculate();
            }
        }
    }
}
