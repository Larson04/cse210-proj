using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity activity = new Activity("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.", "Great Job!");

        activity.DisplayStartMessage("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.");

        int duration = activity.GetDuration();

        string userChoice = "";

        while (userChoice != "4")
        {
            Console.WriteLine("Menu Options: \n 1. Breathing\n 2. Listing\n 3. Reflecting\n 4. Quit");
            userChoice = Console.ReadLine();
            activity.Animation1(4);

            if (userChoice == "1")
            { // breathe
                Breath breathActivity = new Breath("Breathe in...", "Breathe out...",duration, 4);

                breathActivity.BreathCount(duration, "Great Job!");
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