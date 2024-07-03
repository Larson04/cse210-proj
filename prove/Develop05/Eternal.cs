class Eternal : Goal
{
    public string _date;
    public List<string> _dateList = new List<string> { };
    public Eternal(string name, string description, int points, bool isCompleted, string date, List<string> dateList) : base(name, description, points, isCompleted)
    {
        _date = date;
        _dateList = dateList;
    }
    

    public override void Update()
    {
        Console.WriteLine("Please enter the name of the goal you would like to update: ");
        string name = Console.ReadLine();
        Console.WriteLine("Have you completed this goal? (Yes or No)");
        string completed = Console.ReadLine();

        foreach (Goal goal in _goalList)
        {
            if (goal._name == name)
            {
                if (completed == "Yes")
                {
                    foreach (string date in _dateList)
                    {
                        if (date == _date)
                        {
                            if (_isCompleted == true)
                            {
                                Console.WriteLine("You have already completed this goal today!");
                                
                            }
                        }
                        else
                        {
                            _isCompleted = true;
                            Console.WriteLine($"You have earned {_points} points!");
                            DateTime dateTime = DateTime.Now;
                            _date = dateTime.ToString("MM/dd/yyyy");
                            _dateList.Add(_date);
                            Console.WriteLine($"You have completed this goal {_dateList.Count} times!");
                            

                        }
                    }                    
                }
                else
                {
                    Console.WriteLine("You have not earned any points, please try again next time.");
                    _isCompleted = false;
                
                }
            }
        }
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