using System.Reflection.Metadata.Ecma335;

class SaveFile
{
    public SaveFile()
    {

    }

    public static void Save(List<Goal> _goalList)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach ( Goal goal in  _goalList)
            {
                string line = goal.ListSave();
                // string line = goal._name + '|' +  goal._description + '|' + goal._isCompleted + '|' + goal._points;
                outputFile.WriteLine(line);

            }
        }
    }

    public static void LoadFile(List<Goal> _goalList)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "Eternal: ")
            {
                string _name = parts[1];
                string _description = parts[2];
                bool _isCompleted = bool.Parse(parts[3]);
                int _points = int.Parse(parts[4]);
                string _date = parts[5];
                List<string> _dateList = new List<string>(); 
                _dateList.Add(parts[6]);
                Eternal eternal = new Eternal(_name, _description, _points, _isCompleted, _date, _dateList);
                Goal._goalList.Add(eternal);
            }
            else if (parts[0] == "Simple: ")
            {
                string _name = parts[1];
                string _description = parts[2];
                bool _isCompleted = bool.Parse(parts[3]);
                int _points = int.Parse(parts[4]);
                Simple simple = new Simple(_name, _description, _points, _isCompleted);
                Goal._goalList.Add(simple);
            }
            else if (parts[0] == "Check: ")
            {
                string _name = parts[1];
                string _description = parts[2];
                bool _isCompleted = bool.Parse(parts[3]);
                int _points = int.Parse(parts[4]);
                int _checkCount = int.Parse(parts[5]);
                int _bonus = int.Parse(parts[6]);
                Check check = new Check(_name, _description, _points, _isCompleted, _bonus, _checkCount, _checkCount);
                Goal._goalList.Add(check);
            }
                

            foreach (string part in parts)
            {
                Console.WriteLine(part);
                
            }
        }

    }

}
