class Indoor : Event
{
    private string _speaker;
    private int _capacity;

    public Indoor(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        Console.WriteLine($"Indoor Event: \n{_title} \n {_speaker} \n {_date} \n {_time}");
        _address.DisplayAddress();
        Console.WriteLine($"{_capacity} \n{_description}");
    }

    public void ShortDesc()
    {
        Console.WriteLine($"Indoor Event: \n{_title}\n{_date}");
    }
}