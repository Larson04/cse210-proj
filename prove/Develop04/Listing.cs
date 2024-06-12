public class Listing : Activity
{
    public string _specialDescription;
    protected static List<string> _promptList  = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are some positive things that you noticed today?"
        };

    public static List<string> _responseList;
    public int _count;

    public Listing(string startMessage, string endMessage, int duration, string specialDescription) : base(startMessage, endMessage, duration)
    {
        _specialDescription = specialDescription;

        
        _responseList = new List<string>{};

        _count = 0;
    }

    public string DisplayPrompt(){
        Random random = new Random();
        int index = random.Next(_promptList.Count);

        return _promptList[index];

    }
    
    public void GetResponse( int duration){
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("");
            string response = Console.ReadLine();
            _responseList.Add(response);
        }
    }

    public void Count(){
        _count = _responseList.Count;
        Console.WriteLine($"You entered {_count} items.");
    }
}