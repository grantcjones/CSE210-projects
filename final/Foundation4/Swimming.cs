using static System.Console;

public class Swimming : Activity
{
    private int _laps;
    private string _activityName = "Swimming";

    public Swimming(int laps, string date, int activityLength) : base (date, activityLength)
    {
        _laps = laps;
    }

    public override string ActivityName()
    {
        return _activityName;
    }

    public override float GetDistance()
    {
        double doubleDistance = (_laps * (50 / 1609.344));
        float distance = (float)doubleDistance;
        return (float)Math.Round(distance, 1);
    }
}