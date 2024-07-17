using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("01/01/2020", 30, 5.0));
        activities.Add(new Cycling("01/01/2020", 30, 35.0));
        activities.Add(new Swimming("01/01/2020", 30, 5));

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}