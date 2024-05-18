using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
            Journal journal1 = new Journal();

            JournalEntry journalEntry1 = new JournalEntry();

            
        

        // if (journal1._entries.Count > 0)
        // {
        //     journal1.DisplayJournal();

        // }
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Menu Options: \n 1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            { // write

                journalEntry1 = journalEntry1.writeEntry();
                
                journal1.AddEntryToJournal(journalEntry1);
            }
            else if (userChoice == "2")
            { // display
                journal1.DisplayJournal();
            }
            else if (userChoice == "3")
            { // load
                journal1 = new Journal();

                JournalSave loadJournal = new JournalSave();
                loadJournal.LoadJournal(journal1);
            }
            else if (userChoice == "4")
            { // save
                JournalSave saveJournal = new JournalSave();
                saveJournal.SaveJournal(journal1);
            }
            else if (userChoice == "5")
            { // quit
                Console.WriteLine("Goodbye!");
            }

            
        }
    }
}