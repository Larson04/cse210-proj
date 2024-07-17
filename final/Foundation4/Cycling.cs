class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double CalcDistance()
    {
        double distance = _speed * (_duration / 60.0);
        return distance;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        double pace = _duration / CalcDistance();
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} - Cycling ({_duration}): Distance: {CalcDistance()} miles, Speed: {CalcSpeed(),0:0.00} mph, Pace: {CalcPace(),0:0.00} min per miles");
    }
}