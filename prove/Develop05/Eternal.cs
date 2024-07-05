class Eternal : Goal
{
    public string _date;
    public List<string> _dateList = new List<string> { };
    public Eternal(string name, string description, int points, bool isCompleted, string date, List<string> dateList) : base(name, description, points, isCompleted)
    {
        _date = date;
        _dateList = dateList;
    }
    

    public override int Update()
    {
       
        
        DateTime dateTime = DateTime.Now;
        _date = dateTime.ToString("MM/dd/yyyy");

        foreach (string date in _dateList)
        {
            if (date == _date)
            {
                Console.WriteLine("You have already completed this goal today!");
                return 0;
            }
            else
            {
                _isCompleted = true;
                Console.WriteLine($"You have earned {_points} points!");
            }
        }                    
        
        _dateList.Add(_date);
        Console.WriteLine($"You have completed this goal {_dateList.Count} times!");
        return this._points;
    }

    public override string ListSave()
    {
        return "Eternal: " + "|" + _name + "|" + _description + "|" + _isCompleted + "|" + _points + "|" + _date + "|" + _dateList;
    }

    public override void Display()
    {
        if (_isCompleted == true)
        {
            Console.WriteLine($"Eternal: [X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"Eternal: [ ] {_name} ({_description})");
        }
    }
}