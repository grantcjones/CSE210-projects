using static System.Console;

public class Address
{
    private string _fullAddress;
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetAddress()
    {
        _fullAddress = ($"{_streetAddress}\n  {_city} {_stateProvince} {_country}");
        return _fullAddress;
    }

    // public Address GetCountry()
    // {
    //     string className = "Address";
    //     Type type = Type.GetType(className);
    //     object instance = Activator.CreateInstance(type);

    //     return _country;
    // }

    public bool Origin()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}