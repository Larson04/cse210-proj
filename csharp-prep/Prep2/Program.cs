using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";

        if (grade >= 90)
        {
            //Console.WriteLine("Your grade is an A.");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("Your grade is a B.");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("Your grade is a C.");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("Your grade is a D.");
            letter = "D";
        }
        else if (grade < 60)
        {
            // Console.WriteLine("Your grade is an F.");
            letter = "F";
        }
        else 
        {
            Console.WriteLine("Invalid grade.");
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't pass. You can try again next time!");
        }
    }
}