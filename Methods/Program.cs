using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Çanta";
            product1.Price = 300.50;
            product1.Detail = "Deri";

            Product product2 = new Product();
            product2.Id = 1;
            product2.Name = "Ayakkabı";
            product2.Price = 200.50;
            product2.Detail = "Deri";

            Product[] products = new Product[] {product1,product2 };
            Console.WriteLine(products[0].Price);
            Console.ReadLine();
        }
    }
}
