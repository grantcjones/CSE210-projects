using static System.Console;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        
    }
    
    public string GetCustomer()
    {
        return (_name); //? Potential fix: add returned address as additional input?
    }

    public int CustomerOrigin(Address address) 
    {
        if (_address.Origin())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}