abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    
    public bool _isCompleted;
    
    public static List<string> _goalList = new List<string> { };

    public Goal(string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
        
    }

    public void Display()
    {
        foreach (string goal in _goalList)
        {
            if (_isCompleted == true)
            {
                Console.WriteLine($"[X] {_name} ({_description})");
            }
            else
            {
                Console.WriteLine($"[ ] {_name} ({_description})");
            }
        }
    }

    public abstract void Update();

    public abstract string ListSave();
}