class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual void CalcDistance()
    {
        return;
    }

    public virtual void CalcSpeed()
    {
        return;
    }

    public virtual  void CalcPace()
    {
        return;
    }

    public virtual void GetSummary()
    {
        return;
    }
}