using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Asus Laptop";
            product1.ProductDetail = "16 GB";
            product1.ProductPrice = 15000;

            Product product2 = new Product();
            product2.ProductName = "Lenovo Laptop";
            product2.ProductDetail = "8 GB";
            product2.ProductPrice = 9000;

            Product[] productList = new Product[] { product1, product2 };

            foreach (Product product in productList)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductDetail + " " + product.ProductPrice.ToString() + " TL");
            }
            Console.ReadLine();
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public int ProductPrice { get; set; }
    }
}

