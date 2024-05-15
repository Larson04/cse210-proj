using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();

        JournalEntry journalEntry1 = new JournalEntry();

        journalEntry1 = journalEntry1.writeEntry();
        

        journal1.AddEntryToJournal(journalEntry1);
        journal1.DisplayJournal();
        
    }
}