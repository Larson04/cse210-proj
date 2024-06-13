using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        
        Console.WriteLine("How long would you like to do this activity in seconds?");
        int duration = int.Parse(Console.ReadLine());

        Activity activity = new Activity("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.", "Great Job!", duration);

        activity.DisplayStartMessage("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.");

    

        Breath breathActivity = new Breath("Breathe in...", "Breathe out...", activity._duration, 4, "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        breathActivity.BreathCount(4, 15, "Great Job!");

        // Listing listingActivity = new Listing("Welcome to the Mindfulness App! Here are some activities to help you be more mindful.", "Great Job!", activity._duration, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." );

        // listingActivity.DisplayPrompt();
        // listingActivity.GetResponse(activity._duration);
        // listingActivity.Count();

    }
}