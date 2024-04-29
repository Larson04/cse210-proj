using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        int rlgrade = int.Parse(Console.ReadLine());

        string rlletter = "";

        if (rlgrade >= 90)
        {
            //Console.WriteLine("Your grade is an A.");
            rlletter = "A";
        }
        else if (rlgrade >= 80)
        {
            // Console.WriteLine("Your grade is a B.");
            rlletter = "B";
        }
        else if (rlgrade >= 70)
        {
            // Console.WriteLine("Your grade is a C.");
            rlletter = "C";
        }
        else if (rlgrade >= 60)
        {
            // Console.WriteLine("Your grade is a D.");
            rlletter = "D";
        }
        else if (rlgrade < 60)
        {
            // Console.WriteLine("Your grade is an F.");
            rlletter = "F";
        }
        else 
        {
            Console.WriteLine("Invalid grade.");
        }

        Console.WriteLine($"Your grade is {rlletter}.");

        if (rlgrade >= 70) 
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't pass. You can try again next time!");
        }
    }
}