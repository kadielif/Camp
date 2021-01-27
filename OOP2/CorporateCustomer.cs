using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer
    {
        public string ComponyId { get; set; }
        public string TaxNumber { get; set; }
        public string ComponyName { get; set; }
    }
}
