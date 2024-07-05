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

    public override int Update()
    {      
                
        _count += 1;
        if (_count == _checkCount)
        {  
            Console.WriteLine("You have completed this goal! Here is a bonus of " + _bonus + " points! ");
                
            _isCompleted = true;
            return this._points + _bonus;
        }
        else
        {
            Console.WriteLine($"You have earned {_points} points!");


            
            Console.WriteLine($"You have completed this goal {_count}/{_checkCount} times!");

            return this._points;
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
            Console.WriteLine($"Check: [X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"Check: [ ] {_name} ({_description})");
        }
    }
}