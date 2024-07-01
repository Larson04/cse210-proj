using System.Reflection.Metadata.Ecma335;

class SaveFile : Goal
{
    public SaveFile(string name, string description, int points, bool isCompleted, List<string> goalList, int score) : base(name, description, points, isCompleted, goalList, score) { }

    public void Save(List<Goal> _goalList)
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach ( Goal goal in  _goalList)
                {
                    string line = goal._name + '|' +  goal._description + '|' + goal._isCompleted;
                    outputFile.WriteLine($"{line}");

                }
            }
        }

        public void LoadFile(Goal _goalList)
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

    public override void Update() { }
}
