class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration) 
    {
        _laps = laps;
    }   

    public override double CalcDistance()
    {
        double distance = (double)_laps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double CalcSpeed()
    {
        double speed = CalcDistance() / _duration * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _duration / CalcDistance();
        return pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} - Swimming ({_duration}): Distance: {CalcDistance()} miles, Speed: {CalcSpeed(),0:0.00} mph, Pace: {CalcPace(),0:0.00} min per mile");
    }
}