class Check : Goal
{
    int _checkCount;
    int _bonus;
    int _count;
    public Check(string name, string description, int points, bool isCompleted, int bonus, int checkCount, int count) : base(name, description, points, isCompleted)
    {
        _bonus = bonus;
        _checkCount = checkCount;
        _count = count;
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
                    if (_count == _checkCount)
                    {
                        if (_isCompleted == true)
                        {
                            _bonus = _points * 2;
                            Console.WriteLine("You have completed this goal! Here is a bonus of " + _bonus + " points! ");

                            
                        }
                    }
                    else
                    {
                        _isCompleted = true;
                        Console.WriteLine($"You have earned {_points} points!");

                        _count += 1;

                        
                        Console.WriteLine($"You have completed this goal {_count}/{_checkCount} times!");
                        // _score += _points;

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

    public override string ListSave()
    {

        return "Check: " + "|" + _name + "|" + _description + "|" + _isCompleted + "|" + _points + "|" + _bonus + "|" + _checkCount + "|" + _count;
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