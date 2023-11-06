using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of products
        List<Product> products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Price = 800.0, IsAvailable = true },
            new Product { ProductId = 2, Name = "Smartphone", Price = 500.0, IsAvailable = true },
            new Product { ProductId = 3, Name = "Tablet", Price = 300.0, IsAvailable = false },
            new Product { ProductId = 4, Name = "Monitor", Price = 250.0, IsAvailable = true },
            new Product { ProductId = 5, Name = "Keyboard", Price = 50.0, IsAvailable = true }
        };

        // Use lambda expression to filter available products with a price less than $400
        List<Product> affordableProducts = products
            .Where(product => product.IsAvailable && product.Price < 400.0)
            .ToList();

        // Display filtered products
        Console.WriteLine("Affordable Available Products:");
        foreach (var product in affordableProducts)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.Name}, Price: ${product.Price}");
        }
    }
}
