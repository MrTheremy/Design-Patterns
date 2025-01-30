using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class RepositoryService
    {
        public static void Execute()
        {
            IRepository<Product> productRepository = new ProductRepository();

            // Add some products
            productRepository.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99m });
            productRepository.Add(new Product { Id = 2, Name = "Smartphone", Price = 499.99m });

            // Get all products
            var products = productRepository.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }

            // Update a product
            var productToUpdate = productRepository.GetById(1);
            productToUpdate.Name = "Gaming Laptop";
            productToUpdate.Price = 1299.99m;
            productRepository.Update(productToUpdate);

            // Get a single product by ID
            var singleProduct = productRepository.GetById(1);
            Console.WriteLine($"Updated Product: {singleProduct.Name}, Price: {singleProduct.Price}");

            // Delete a product
            productRepository.Delete(2);
            Console.WriteLine("Product with ID 2 has been deleted.");
        }
    }
}