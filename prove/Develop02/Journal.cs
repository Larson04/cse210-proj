public class Journal{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntryToJournal(JournalEntry entry){
        _entries.Add(entry);
    }
    public void DisplayJournal(){
        foreach (JournalEntry entry in _entries){

            Console.WriteLine(_entries);
        }
    }
}