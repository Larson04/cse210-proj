class Reception : Event
{
    private string _email;

    public Reception( string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void FullDescription()
    {
        Console.WriteLine($"Reception: \n{_title}  \n {_date} \n {_time}");
        _address.DisplayAddress();
        Console.WriteLine($"{_description}\n {_email}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Reception: \n{_title}\n{_date}");
    }
}