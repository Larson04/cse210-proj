class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    private double _totalProductPrice;

    public Product(string productName, string productID, double price, int quantity, double totalProductPrice)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _totalProductPrice = totalProductPrice;
    }

    public double TotalProductPrice()
    {
        return _totalProductPrice = _price * _quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_productName} | {_productID} | {_price} | {_quantity} ");
    }
}