using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckedService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
