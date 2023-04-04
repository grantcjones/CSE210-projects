using static System.Console;

public class Biking : Activity
{
    private float _speed;
    private string _activityName = "Cycling";

    public Biking(float speed, string date, int activityLength) : base (date, activityLength)
    {
        _speed = speed;
    }

    public override string ActivityName()
    {
        return _activityName;
    }

    public override float GetDistance()
    {
        float mySpeed = _speed * (GetTimePeriod() / 60);
        return (float)Math.Round(mySpeed, 1);       
    }
}