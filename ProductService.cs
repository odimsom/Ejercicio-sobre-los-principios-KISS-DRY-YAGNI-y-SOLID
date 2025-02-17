using System;

namespace Principios
{

    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            Console.WriteLine($"Product {name} added with price {price}.");
        }

        public void DeleteProduct(int productId)
        {
            Console.WriteLine($"Product {productId} deleted.");
        }

    }
}

