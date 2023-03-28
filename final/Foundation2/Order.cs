using static System.Console;

public class Order
{
    private List<string> _products = new List<string>();
    // private string _customer;

    private int _cost;
    private int _shipCost;
    private string _address;

    public Order(int cost, int shipCost, string address)
    {
        _cost = cost;
        _shipCost = shipCost;
        _address = address;
    }

    public void AddProduct(string product)
    {
        _products.Add(product);
    }

    public void PackingLabel() //TODO Finish Output
    {   
        WriteLine("Shipping:");

        foreach (string item in _products)
        {   
            WriteLine($"  {item}");
        }
        WriteLine();
    }

    public void ShippingLabel(string customer) //TODO Finish Output
    {
        WriteLine("Ship to:");
        WriteLine($"  {customer}");
        WriteLine($"  {_address}");
        WriteLine();
    }
}