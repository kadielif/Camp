using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer()
            {
                DateOfBirth = new DateTime(1997, 11, 18),
                FirstName = "Elif",
                LastName = "Kadı",
                NationalityId = "17234819780"
            });
            Console.ReadLine();

        }
    }
}
