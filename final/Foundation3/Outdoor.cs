class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather ) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void FullDetails()
    {
        Console.WriteLine($"Outdoor Event: \n{_title}  \n {_date} \n {_time}");
        _address.DisplayAddress();
        Console.WriteLine($"{_description}\n {_weather}");
    }

    public void ShortDesc()
    {
        Console.WriteLine($"Outdoor Event: \n{_title}\n{_date}");
    }
}