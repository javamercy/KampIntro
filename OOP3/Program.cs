using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager demandCreditManager = new DemandCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new ArtisanCreditManager(),
                new List<ILoggerService>
            {
                new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() });
            //applicationManager.MakeApplication(vehicleCreditManager);
            //applicationManager.MakeApplication(demandCreditManager);

            List<ICreditManager> creditManagers = new List<ICreditManager>
            {
            demandCreditManager,
            vehicleCreditManager

            };

            // applicationManager.InfoViewOfCredit(creditManagers);

        }
    }
}
