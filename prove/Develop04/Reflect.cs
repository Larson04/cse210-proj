public class Reflect : Activity
{
    private static string _specialDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public static List<string> _promptList  = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned something new."
    };
    
    public static List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public static List<string> _usedQuestions;

    public Reflect(string startMessage, string endMessage) : base(startMessage, endMessage)
    {
    }

    public void DisplaySpecialDescription()
    {
        Console.WriteLine(_specialDescription);
    }

    public void DisplayPrompt(int duration)
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);

        Console.WriteLine(_promptList[index]);
        Animation2(4);
        Animation3(4);

        DisplayQuestion(duration);
    }

    public void DisplayQuestion(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            foreach(string question in _questionList)
            {
                if(DateTime.Now >= futureTime)
                {
                    break;
                }
                Console.WriteLine(question);
                Animation2(4);
                Animation3(4);

                if (DateTime.Now >= futureTime)
                {
                    break;
                }
            }   
        }
    }
}