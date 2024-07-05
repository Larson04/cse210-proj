abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;
    public bool _isCompleted;
    
    public static List<Goal> _goalList = new List<Goal> { };

    public Goal(string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
        
    }

    public abstract void Display();

    public abstract int Update();

    public abstract string ListSave();
}