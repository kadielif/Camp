using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = "12345";
            customer1.Name = "Elif";
            customer1.Surname = "Kadi";
            customer1.TcNumber = "222222222222";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.ComponyId = "54312";
            customer2.ComponyName="Kodlama.io";
            customer2.TaxNumber = "124234";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);


        }
    }
}
