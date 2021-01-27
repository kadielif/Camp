using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckedService _customerCheckedService;

        public StarbucksCustomerManager(ICustomerCheckedService customerCheckedService)
        {
            _customerCheckedService = customerCheckedService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckedService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
                throw new Exception("Geçerli kişi değil");

        }
    }
}
