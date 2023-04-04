using static System.Console;

public class Reception : Event
{
    string _rsvp;

    public Reception(string eventTitle, string description, string date, string time, string address, string type, string rsvp) : base(eventTitle, description, date, time, address, type)
    {
        _rsvp = rsvp;
    }

    public string GetFullDeets()
    {
        return ($"RSVP: {_rsvp}");
    }
}