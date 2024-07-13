using System.Runtime.CompilerServices;

class Order
{
    private Customer _customer;
    private List<Product> _order = new List<Product>();
    private double _orderTotal;

    public Order(string customerName, string streetAddress, string city, string state, string country,  double orderTotal)
    {
        _customer = new Customer(customerName, streetAddress, city, state, country);
        _orderTotal = orderTotal;
    }
    public void AddProduct(Product product)
    {
        _order.Add(product);
    }

    
    public double OrderTotal()
    {
        foreach (Product product in _order)
        {
            _orderTotal += product.TotalProductPrice();
        }
        if (_customer.DomesticOrInternational() == true)
        {
            _orderTotal += 5;
        }
        else
        {
            _orderTotal += 35;
        }

        return _orderTotal;
    }



    public void PrintShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        _customer.DisplayAddress();
    }

    public void PrintPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _order)
        {
            product.DisplayProduct();
        }
    }
}