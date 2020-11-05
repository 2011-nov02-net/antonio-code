using System;
using System.Collections.Generic;

namespace HelloVisualStudio.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list of products
            List<Product> catalog = GetProducts();

            // display the list to the user
            Display(catalog);

            // allow some customization of that display to the user
        }

        static void Display(List<Product> catalog)
        {
            foreach(var product in catalog)
            {
                Console.WriteLine(product.id);
            }
        }

        // return the list of products
        static List<Product> GetProducts() => new List<Product>
        {
                new Product("0001", "laptop", 800.99, 15),
                new Product("0002", "pizza", 12.99, 200),
                new Product("0003", "coffee", 5.99, 500)
        };

        static void ApplyDiscount()
        {

        }
    }
}
