public class JournalEntry{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry writeEntry(){
        
        JournalEntry workingJournal = new JournalEntry();

        _date = DateTime.Now.ToString();
        _prompt = Prompt.Display();

        Console.WriteLine($"{_date} - Prompt: {_prompt}");

        _response = Console.ReadLine();

        return workingJournal;
    }

    
}