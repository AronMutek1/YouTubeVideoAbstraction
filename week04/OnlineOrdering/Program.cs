class Program
{
    static void Main(string[] args)
    {
        // USA Order
        Address addr1 = new Address("234 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "LP123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS456", 25.00, 2));

        // Non-USA Order
        Address addr2 = new Address("221B Baker St", "London", "England", "UK");
        Customer cust2 = new Customer("Sherlock Holmes", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "NB789", 5.50, 5));

        // Display Orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
