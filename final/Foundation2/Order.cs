using static System.Console;

public class Order
{
    private List<string> _products = new List<string>();

    private int _cost;
    private int _shipCost;
    private string _address;

    public Order(int cost, int shipCost, string address)
    {
        _cost = cost;
        _shipCost = shipCost;
        _address = address;
    }

    public string CostTotal()
    {
        int total = _shipCost + _cost;
        return ($"Total Cost:\n ${total}");
    }

    public void AddProduct(string product)
    {
        _products.Add(product);
    }

    public void PackingLabel()
    {   
        WriteLine("Shipping:");

        foreach (string item in _products)
        {   
            WriteLine($"  {item}");
        }
        
        WriteLine();
    }

    public void ShippingLabel(string customer)
    {
        WriteLine("Ship to:");
        WriteLine($"  {customer}");
        WriteLine($"  {_address}");
        WriteLine();
    }
}