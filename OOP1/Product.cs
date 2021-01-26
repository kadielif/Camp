using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity
    {
        public int Id { get; set; }//PrimaryKey
        public int CategoryId { get; set; } //ForeignKey
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
