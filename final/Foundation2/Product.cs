using static System.Console;

public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string productName, string productId, int price, int quantity)
    {
        _name = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProduct()
    {
        return ("Product: " + _name + ", ID: " + _productId);
    }

    public int GetPrice()
    {
        int totalPrice = _price * _quantity;
        return totalPrice;
    }
}