abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    public int _score;
    public bool _isCompleted;
    
    public static List<string> _goalList = new List<string> { };

    public Goal(string name, string description, int points, bool isCompleted, List<string> goalList, int score)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
        _goalList = goalList;
        _score = score;
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