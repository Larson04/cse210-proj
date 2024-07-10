class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isDomestic;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool DomesticOrInternational()
    {
        if (_country == "USA")
        {
            _isDomestic = true;
        }
        else
        {
            _isDomestic = false;
        }

        return _isDomestic;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_state}, {_country}");
    }
}