class Event
{
    public string _title;
    public string _description;
    public string _date;
    public string _time;
    public Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardMessage()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date}, {_time}");
        _address.DisplayAddress();
    }
}