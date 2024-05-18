public class JournalEntry{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry writeEntry(){
        
        JournalEntry workingJournal = new JournalEntry();

        workingJournal._date = DateTime.Now.ToString();
        workingJournal._prompt = Prompt.Display();

        Console.WriteLine($"{workingJournal._date} - Prompt: {workingJournal._prompt}");

        workingJournal._response = Console.ReadLine();

        Console.WriteLine("|");

        return workingJournal;
    }

    
}