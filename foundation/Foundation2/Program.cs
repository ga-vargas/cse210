using System;

class Program
{
    static void Main(string[] args)
    {
        //Create address
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        //Create a customer
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        //Create a product
        Product product1 = new Product("Laptop", "L101", 899.99m, 1);
        Product product2 = new Product("Smartphone", "S202", 499.99m, 2);
        Product product3 = new Product("Headphones", "H303", 79.99m, 3);

        //Create an order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        //Show order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
    }
}