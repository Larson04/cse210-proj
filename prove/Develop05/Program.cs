using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        
        

        string userChoice = "";

        while (userChoice != "4")
        {
            Console.WriteLine("Menu Options: \n 1. New Eternal Goal\n 2. New Simple Goal\n 3. New Check Goal\n 4. View Existing and Score\n 5. Update Existing\n 6. Quit");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            { // Eternal
                
            }
            else if (userChoice == "2")
            { // Simple
                                
            }
            else if (userChoice == "3")
            { // check
                                
            }
            else if (userChoice == "4")
            {//view
            
            }
            else if (userChoice == "5")
            { // update

            }
            else if (userChoice == "6")
            { // quit
                Console.WriteLine("Goodbye!");
            }
        }

    }
}