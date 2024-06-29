class Eternal : Goal
{
    public string _date;
    public List<string> _dateList = new List<string> { };
    public Eternal(string name, string description, int points, bool isCompleted, List<string> goalList, int score, string date, List<string> dateList) : base(name, description, points, isCompleted, goalList, score, type)
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

        foreach (string goal in _goalList)
        {
            if (goal == name)
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
                            Console.WriteLine("You have earned 5 points!");
                            _points = 5;
                            DateTime dateTime = DateTime.Now;
                            _date = dateTime.ToString("MM/dd/yyyy");
                            _dateList.Add(_date);
                            Console.WriteLine($"You have completed this goal {_dateList.Count} times!");
                            _score += _points;

                            _goalList.Remove($"[ ] {_name} ({_description})");
                            _goalList.Add($"[X] {_name} ({_description})");

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
}