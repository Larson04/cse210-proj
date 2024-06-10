using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity activity = new Activity("Hello", "Goodbye", 10);

        Breath breathActivity = new Breath("Breathe in...", "Breathe out...", 10, 4);

        breathActivity.BreathCount(4, 10);

    }
}