public class JournalSave
{
    public void SaveJournal(Journal _entries)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries._entries)
            {
                string line = entry._date + '|' +  entry._prompt + '|' + entry._response;
                outputFile.WriteLine($"{line}");

            }
        }
    }

    public void LoadJournal(Journal _entries)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            // Code help from ChatGPT, adding parts to entry
             if (parts.Length == 3) // Ensure correct format
                {
                    JournalEntry journalEntry = new JournalEntry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2]
                    };

                    _entries.AddEntryToJournal(journalEntry);
                }

            foreach (string part in parts)
            {
                Console.WriteLine(part);
                
            }
        }

    }
}

