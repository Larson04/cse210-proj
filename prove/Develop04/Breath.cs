public class Breath : Activity
{
    public int _wait;
    protected static string _specialDescription = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";

    public Breath(string startMessage, string endMessage, int duration, int wait) : base(startMessage, endMessage)
    {
        _wait = wait;
    }

    public void BreathCount(int duration, string _endMessage)
    {
        Console.WriteLine($"{_specialDescription}");
        Animation2(5);
        Animation3(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            Animation3(4);
            Console.WriteLine("Breathe out...");
            Animation2(4);
        }

        Console.WriteLine($"{_endMessage}");
    }
}