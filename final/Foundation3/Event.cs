using static System.Console;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _type;

    public Event(string eventTitle, string description, string date, string time, string address, string type)
    {  
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }
 
    public string GetFull()
    {
        return ($"Event Name: {_eventTitle}\nEvent Description: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n");
    }

    public string GetStandard()
    {
        return ($"Event Name: {_eventTitle}\nEvent Description: {_description}\nDate: {_date}\nTime: {_time}\nVenue: {_address}\n");
    }

    public string GetShort()
    {
        return ($"Event Type: {_type}\nEvent Name: {_eventTitle}\nDate: {_date}\n");
    }
}