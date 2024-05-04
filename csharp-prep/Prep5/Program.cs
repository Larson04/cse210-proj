using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        RLDisplayWelcome();
        string RLUserName = RLPromptUserName();
        int RLUserNumber = RLPromptUserNumber();
        int RLSqNum = RLSquareNumber(RLUserNumber);
        RLDisplayResult(RLUserName, RLSqNum);
    }

    static void RLDisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string RLPromptUserName()
    {
        Console.Write("Please enter your name: ");
        string RLuserName = Console.ReadLine();

        return RLuserName;
    }

    static int RLPromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int RLuserNumber = int.Parse(Console.ReadLine());

        return RLuserNumber;
    }

    static int RLSquareNumber(int RLuserNumber)
    {
    

        int RLsquare = RLuserNumber * RLuserNumber;

        return RLsquare;
    }

    static void RLDisplayResult(string RLuserName, int RLsquare)
    {
        Console.WriteLine($"{RLuserName}, the square of your number is {RLsquare}");
    }
}