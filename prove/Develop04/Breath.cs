public class Breath : Activity
{
    public int _wait;
    protected string _specialDescription;

    public Breath(string startMessage, string endMessage, int duration, int wait, string specialDescription) : base(startMessage, endMessage, duration)
    {
        _wait = wait;
        _specialDescription = specialDescription;
    }

    public void BreathCount(int wait, int duration, string _endMessage)
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