class Simple : Goal
{

    public Simple(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted){
        
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
                    _isCompleted = true;
                    Console.WriteLine($"You have earned {_points} points!");
                    
                    // _score += _points;

                    

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
    
        return "Simple: " + "|" + _name + "|" + _description + "|" + _isCompleted + "|" + _points;
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