class Simple : Goal
{

    public Simple(string name, string description, int points, bool isCompleted, List<string> goalList, int score) : base(name, description, points, isCompleted, goalList, score){}


    public override int Update()
    {
        Console.WriteLine("Please enter the name of the goal you would like to update: ");
        string name = Console.ReadLine();
        Console.WriteLine("Have you completed this goal? (Yes or No)");
        string completed = Console.ReadLine();
        if (completed == "Yes")
        {
            _isCompleted = true;
            Console.WriteLine("You have earned 5 points!");
            _points = 5;
            return _points + _score;
        }
        else
        {
            Console.WriteLine("You have not earned any points, please try again next time.");
            _isCompleted = false;
            return 0;
        }
    }
}