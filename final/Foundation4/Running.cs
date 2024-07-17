class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        double speed = _distance / _duration * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _duration / _distance;
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} - Running ({_duration}): Distance: {_distance} miles, Speed: {CalcSpeed(),0:0.00} mph, Pace: {CalcPace(),0:0.00} min per mile");
    }
}