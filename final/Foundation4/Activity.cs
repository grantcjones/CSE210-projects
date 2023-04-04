using static System.Console;

public abstract class Activity
{
    private string _date;
    private int _activityLength;

    public Activity(string date, int activityLength)
    {
        _date = date;
        _activityLength = activityLength;
    }

    public string GetSummary()
    {
        float myDistance = GetDistance();
        int decimalPlaces = 1;
        string formattedDistance = myDistance.ToString("F" + decimalPlaces);
        return ($"{_date} {ActivityName()} ({_activityLength} min)- Distance {formattedDistance} miles, Speed {Speed()} mph, Pace {Pace()} min per mile.");
    }

    public int GetTimePeriod()
    {
        return _activityLength;
    }

    public string Speed()
    {
        float mySpeed = (GetDistance() / GetTimePeriod()) * 60;
        int decimalPlaces = 1;
        string formattedSpeed = mySpeed.ToString("F" + decimalPlaces);
        return formattedSpeed;
    }

    public string Pace()
    {
        float myPace = GetTimePeriod() / GetDistance();
        int decimalPlaces = 1;
        string formattedPace = myPace.ToString("F" + decimalPlaces);
        return formattedPace;
    }

    public abstract string ActivityName();

    public abstract float GetDistance();
}