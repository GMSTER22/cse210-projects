using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3500 E Baltimore St", "Baltimore", "Maryland", "USA");
        Customer customer1 = new Customer("Ben Marley", address1);
        List<Product> productList1 = new List<Product>(){
            new Product("Pen", 25364, 25.99, 3), 
            new Product("Phone", 15384, 699.99, 1), 
            new Product("Apple Watch", 32654, 199.99, 1)
        };
        Order order1 = new Order(productList1, customer1);

        Address address2 = new Address("1580 Burnt Island Road", "Milford Bay", "Ontario", "Canada");
        Customer customer2 = new Customer("Paula Martinez", address2);
        List<Product> productList2 = new List<Product>(){
            new Product("T.V", 58964, 999.99, 1), 
            new Product("Screws", 24897, 0.99, 5)
        };
        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order 1:");        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order1.GetOrderTotal()}");
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total: ${order2.GetOrderTotal()}");
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
    }
}