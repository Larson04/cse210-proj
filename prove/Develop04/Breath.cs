public class Breath : Activity
{
    public int _wait;

    public Breath(string startMessage, string endMessage, int duration, int wait) : base(startMessage, endMessage, duration)
    {
        _wait = wait;
    }

    public void BreathCount(int wait, int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            Animation2(4);
            Console.WriteLine("Breathe out...");
            Animation2(4);
        }
    }
}