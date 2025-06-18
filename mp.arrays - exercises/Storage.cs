using System;
using System.Collections.Generic;
using System.Text.Json;

namespace mp.arrays___exercises
{
   public class Storage
    {
        public int Capacity { get; set; }
        public List<Product> Products { get; set; }
        public double TotalCost { get; set; }

        // Constructor that initializes the capacity and the product list
        public Storage(int capacity)
        {
            Capacity = capacity;
            Products = new List<Product>();
            TotalCost = 0;
        }

        // Method to add a product to the storage
        public void AddProduct(string name, double price, int quantity)
        {
            if (Capacity >= quantity)
            {
                double totalCost = price * quantity;
                Products.Add(new Product(name, price, quantity, totalCost));
                Capacity -= quantity;
                TotalCost += totalCost;
            }
            else
            {
                Console.WriteLine("Not enough capacity to add the product.");
            }
        }

        // Method to get the products in JSON format
        public void GetProducts()
        {
            foreach (var product in Products)
            {
                // Serialize the product details to JSON format
                var jsonProduct = JsonSerializer.Serialize(product);
                Console.WriteLine(jsonProduct);
            }
        }

        // Run method to simulate the operations, accepts args as input
        public void Run(string[] args)
        {
            // Check if args contain product details, e.g., name, price, quantity
            if (args.Length >= 3)
            {
                string name = args[0];
                double price;
                int quantity;

                // Parse price and quantity from args
                if (double.TryParse(args[1], out price) && int.TryParse(args[2], out quantity))
                {
                    // Add the product
                    AddProduct(name, price, quantity);
                }
                else
                {
                    Console.WriteLine("Invalid price or quantity.");
                }
            }
            else
            {
                Console.WriteLine("Not enough arguments provided.");
            }

            // Print all products in storage
            GetProducts();

            // Print remaining capacity and total cost
            Console.WriteLine($"Remaining Capacity: {Capacity}");
            Console.WriteLine($"Total Cost of Products in Storage: {TotalCost}");
        }

        // Product class to represent a product in storage
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public double TotalCost { get; set; }

            public Product(string name, double price, int quantity, double totalCost)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                TotalCost = totalCost;
            }
        }
    }
}
