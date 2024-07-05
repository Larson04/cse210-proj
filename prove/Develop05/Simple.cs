class Simple : Goal
{

    public Simple(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted){
        
    }


    public override int Update()
    {
        this._isCompleted = true;
        Console.WriteLine($"You have earned {this._points} points!");  
        return this._points;   
    }

    public override string ListSave()
    {
    
        return "Simple: " + "|" + _name + "|" + _description + "|" + _isCompleted + "|" + _points;
    }

    public override void Display()
    {
        if (_isCompleted == true)
        {
            Console.WriteLine($"Simple: [X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"Simple: [ ] {_name} ({_description})");
        }
    }
}