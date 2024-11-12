using BlogDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDomain.Patterns;

public class UseOfSpecifications
{
    public static void UsingSpecifications()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000, Category = "Electronics" },
            new Product { Name = "Smartphone", Price = 800, Category = "Electronics" },
            new Product { Name = "T-shirt", Price = 20, Category = "Clothing" }
        };

        var priceSpec = new PriceSpecification(500, 1500);
        var categorySpec = new CategorySpecification("Electronics");

        var combinedSpec = priceSpec.And(categorySpec);

        var filteredProducts = products.Where(p => combinedSpec.IsSatisfiedBy(p)).ToList();

        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
        }

    }
}
