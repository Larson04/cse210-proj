using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");


        List<Order> orders = new List<Order>();

        Order order1 = new Order("John Doe", "123 Main St", "New York", "NY", "USA", 0);

        Product product1 = new Product("iPhone", "P1234", 999.99, 1, 999.99);
        Product product2 = new Product("MacBook Pro", "P1235", 1299.99, 1, 1299.99);
        Product product3 = new Product("iPad", "P1236", 599.99, 1, 599.99);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        orders.Add(order1);

        Order order2 = new Order("Harry Potter", "4 Privet Drive", "Little Whinging", "Surrey", "UK", 0);

        order2.AddProduct(new Product("Plain work robes", "WkR3425", 30.45, 3, 91.35));
        order2.AddProduct(new Product("Pointed Hat", "PH1235", 15.50, 1, 15.50));
        order2.AddProduct(new Product("Dragon HIde Gloves", "DHG1236", 50.65, 1, 50.65));
        order2.AddProduct(new Product("Name Tag", "TG1234", 5.74, 3, 17.22));

        orders.Add(order2);


        foreach (Order order in orders)
        {
            order.PrintPackingLabel();
            order.PrintShippingLabel();
            order.OrderTotal();
        }
    }
}