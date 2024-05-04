using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int RLmagicNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Welcome to the Number Guessing Game!");

        string RLplay = "yes";

        while (RLplay == "yes")
        {            
        Random random = new Random();
        int RLmagicNumber = random.Next(1, 101);

        int RLguess = -0;
        int RLguessCount = 0;

        while (RLguess != RLmagicNumber)
        {
            Console.Write("What is your guess? ");
            RLguess = int.Parse(Console.ReadLine());

            Console.WriteLine(RLclue(RLmagicNumber, RLguess));
            RLguessCount ++;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {RLguessCount} guesses");

        Console.Write("Would you like to play again? ");
        RLplay = Console.ReadLine();
        }
    }
    static string RLclue(int RLmagicNumber, int RLguess)
    {
        string RLclue = " ";
        
        if (RLguess > RLmagicNumber)
        {
            RLclue = "Lower";
        }
        else if (RLguess < RLmagicNumber)
        {
            RLclue = "Higher";
        }

        return RLclue;
    }
    
}