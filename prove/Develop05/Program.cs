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
                Eternal eternalActivity = new eternal();
            }
            else if (userChoice == "2")
            { // list
                Listing listingActivity = new Listing("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.", "Great Job!",duration);

                listingActivity.GetResponse(duration);
                listingActivity.Count();                
            }
            else if (userChoice == "3")
            { // reflect
                Reflect reflectActivity = new Reflect("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.", "Great Job!");

                reflectActivity.DisplaySpecialDescription();
                reflectActivity.DisplayPrompt(duration);
                activity.DisplayEndMessage("Great Job!");                
            }
            else if (userChoice == "4")
            { // quit
                Console.WriteLine("Goodbye!");
            }
        }

    }
}