using static System.Console;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string description, string date, string time, string address, string type, string weather) : base(eventTitle, description, date, time, address, type)
    {
        _weather = weather;
    }

    public string GetFullDeets()
    {
        return ($"Forecast: {_weather}");
    }
}