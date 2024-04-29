using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string rlfname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string rllname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {rllname}, {rlfname} {rllname}.");
    }
}