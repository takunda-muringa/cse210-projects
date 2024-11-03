using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    // Product class
    class Product
    {
        private string name;
        private string productId;
        private decimal price;
        private int quantity;

        // Constructor
        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        // Method to calculate the total cost of the product
        public decimal GetTotalCost()
        {
            return price * quantity;
        }

        // Getters
        public string GetName() => name;
        public string GetProductId() => productId;
    }

    // Address class
    class Address
    {
        private string street;
        private string city;
        private string stateOrProvince;
        private string country;

        // Constructor
        public Address(string street, string city, string stateOrProvince, string country)
        {
            this.street = street;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToUpper() == "USA";
        }

        // Method to return the full address as a string
        public string GetFullAddress()
        {
            return $"{street}\n{city}, {stateOrProvince}\n{country}";
        }
    }

    // Customer class
    class Customer
    {
        private string name;
        private Address address;

        // Constructor
        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        // Method to check if the customer lives in the USA
        public bool LivesInUSA()
        {
            return address.IsInUSA();
        }

        // Getters
        public string GetName() => name;
        public Address GetAddress() => address;
    }

    // Order class
    class Order
    {
        private List<Product> products;
        private Customer customer;

        // Constructor
        public Order(Customer customer)
        {
            this.customer = customer;
            this.products = new List<Product>();
        }

        // Method to add a product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Method to calculate the total cost of the order
        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.GetTotalCost();
            }

            // Add the shipping cost
            decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
            return totalCost + shippingCost;
        }

        // Method to get the packing label
        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        // Method to get the shipping label
        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Widget", "W001", 10.99m, 3);
            Product product2 = new Product("Gadget", "G002", 5.49m, 2);
            Product product3 = new Product("Thingamajig", "T003", 15.99m, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display results
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        }
    }
}
