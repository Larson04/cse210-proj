using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");


        List<Order> orders = new List<Order>();

        Order order1 = new Order("John Doe", "123 Main St", "New York", "NY", "USA", 0);
        order1.AddProduct(new Product("iPhone", "P1234", 999.99, 1, 999.99));
        order1.AddProduct(new Product("MacBook Pro", "P1235", 1299.99, 1, 1299.99));
        order1.AddProduct(new Product("iPad", "P1236", 599.99, 1, 599.99));

        orders.Add(order1);
    }
}