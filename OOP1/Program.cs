using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Keyboard";
            product1.UnitPrice = 750;
            product1.UnitsInStock = 16;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Mouse",
                UnitPrice = 250,
                UnitsInStock = 6
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        
        }
    }
}
