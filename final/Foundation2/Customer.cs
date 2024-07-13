class Customer 
{
    private string _customerName;
    private Address _address;

    protected bool _isDomestic;

    public Customer(string customerName, string streetAddress, string city, string state, string country)
    {
        _customerName = customerName;
        _address = new Address(streetAddress, city, state, country);
    }

    public bool DomesticOrInternational()
    {
        _isDomestic = _address.DomesticOrInternational();
        return _isDomestic;
    }
    
    public void DisplayAddress()
    {
        Console.WriteLine($"{_customerName}");
        _address.DisplayAddress();
    }

}