class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double CalcDistance()
    {
        return 0.0;
    }

    public virtual double CalcSpeed()
    {
        return 0.0;
    }

    public virtual double CalcPace()
    {
        return 0.0;
    }

    public virtual void GetSummary()
    {
        return;
    }
}