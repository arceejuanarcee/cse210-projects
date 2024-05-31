using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Predefined list of products
        List<Product> availableProducts = new List<Product>
        {
            new Product("Laptop", "LPT123", 999.99f, 10),
            new Product("Mouse", "MSE456", 19.99f, 50),
            new Product("Keyboard", "KYB789", 49.99f, 30),
            new Product("Monitor", "MNT101", 199.99f, 20),
            new Product("Printer", "PRT112", 149.99f, 15)
        };

        List<Order> orders = new List<Order>();

        // Create 2 orders
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Creating order {i + 1}:");

            // Create address
            Console.Write("Enter street: ");
            string street = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter state: ");
            string state = Console.ReadLine();
            Console.Write("Enter country: ");
            string country = Console.ReadLine();
            Address address = new Address(street, city, state, country);

            // Create customer
            Console.Write("Enter customer name: ");
            string customerName = Console.ReadLine();
            Customer customer = new Customer(customerName, address);

            // Create order
            Order order = new Order(customer);

            // Display available products
            Console.WriteLine("Available products:");
            for (int j = 0; j < availableProducts.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {availableProducts[j].ToString()} - Price: ${availableProducts[j].Price} - Available Quantity: {availableProducts[j].Quantity}");
            }

            // Add 2-3 products to the order
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Select product {j + 1} by number: ");
                int productIndex = int.Parse(Console.ReadLine()) - 1;

                if (productIndex >= 0 && productIndex < availableProducts.Count)
                {
                    Product selectedProduct = availableProducts[productIndex];
                    Console.Write($"Enter quantity for {selectedProduct.ToString()}: ");
                    int quantity = int.Parse(Console.ReadLine());

                    if (quantity <= selectedProduct.Quantity)
                    {
                        selectedProduct.SetQuantity(quantity);
                        order.AddProduct(new Product(selectedProduct.ToString(), selectedProduct.ProductId, selectedProduct.Price, quantity));
                    }
                    else
                    {
                        Console.WriteLine("Insufficient quantity available. Please try again.");
                        j--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product selection. Please try again.");
                    j--;
                }
            }

            orders.Add(order);
        }

        // Display the details of each order
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost:");
            Console.WriteLine($"${order.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
