public class Prompt
{
    public static List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What is something that made you happy today?",
        "What was the most challenging thing I had to do today?"
    };
    

    public static string Display(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];

    }
}