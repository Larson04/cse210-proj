using System.Reflection;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    public static int _duration;

    public Activity(string startMessage, string endMessage)
    {
        startMessage = _startMessage;
        endMessage = _endMessage;
    }

    public void DisplayStartMessage(string _startMessage)
    {
        Console.WriteLine(_startMessage);
    }

    public void DisplayEndMessage(string _endMessage)
    {
        Console.WriteLine(_endMessage);
    }

    public void Animation1(int wait)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(wait);
        
        List<string> animations = new List<string> { "Ooooooo", "oOooooo", "ooOoooo", "oooOooo", "ooooOoo", "oooooOo", "ooooooO", "ooooooo", "ooooooO", "oooooOo", "ooooOoo", "oooOooo", "ooOoooo", "oOooooo", "Ooooooo", "ooooooo" };

        while (DateTime.Now < futureTime)
        {
            for (int i = 0; i < animations.Count; i++)
            {
                Console.Clear();
                Console.Write($"{animations[i]}");
                Thread.Sleep(250);
                Console.Clear();
            }
        }
    }

    public void Animation2(int wait)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(wait);

        Console.Write("Ooooooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oOooooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooOoooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oooOooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooooOoo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oooooOo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooooooO\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooooooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        

    }

    public void Animation3(int wait)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(wait);
        Console.Write("ooooooO\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oooooOo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooooOoo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oooOooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("ooOoooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("oOooooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("Ooooooo\b\b\b\b\b\b\b");
        Thread.Sleep(500);
    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }
}
