using System;
using System.Collections.Generic;

namespace ComplexScenario
{
    public class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddToCart(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Added to cart: {product.Name} at ${product.Price}");
        }

        public void ShowCart()
        {
            Console.WriteLine("Cart contents:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }
}
