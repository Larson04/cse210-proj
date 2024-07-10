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
        return _address.DomesticOrInternational();
    }
    
    public void DisplayAddress()
    {
        Console.WriteLine($"{_customerName}");
        _address.DisplayAddress();
    }

}