using static System.Console;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity, string eventTitle, string description, string date, string time, string address, string type) : base(eventTitle, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDeets()
    {
        return ($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}