using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            RequirementCreditManager requirementCreditManager = new RequirementCreditManager();
            //requirementCreditManager.Calculate();

            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();
            
            KonutCreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();

            //ICreditManager requirementCreditManager1 = new RequirementCreditManager();
            //requirementCreditManager1.Calculate();

            //ICreditManager vehicleCreditManager1 = new VehicleCreditManager();
            //vehicleCreditManager1.Calculate();

            //ICreditManager konutCreditManager1 = new KonutCreditManager();
            //konutCreditManager1.Calculate();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(requirementCreditManager,new DatabaseLoggerService());
            applicationManager.BasvuruYap(requirementCreditManager,fileLoggerService);
            
            
            List<ICreditManager> krediler = new List<ICreditManager> {requirementCreditManager,vehicleCreditManager };
            //applicationManager.KrediOnBilgilendirmesiYap(krediler);


        }

    }
}
