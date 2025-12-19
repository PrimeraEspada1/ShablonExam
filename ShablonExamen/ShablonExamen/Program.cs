using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Product> cart1 = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000 },
            new Product { Name = "Mouse", Price = 50 }
        };
        List<Product> cart2 = new List<Product>
        {
            new Product { Name = "Keyboard", Price = 100 },
            new Product { Name = "Monitor", Price = 300 }
        };
        Console.WriteLine($"Total for cart1: {CalculateTotal(cart1)}");
        Console.WriteLine($"Total for cart2: {CalculateTotal(cart2)}");
    }
    static double CalculateTotal(List<Product> cart)
    {
        double total = 0;
        foreach (var product in cart)
        {
            total += product.Price;
        }
        return total;
    }
}
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}