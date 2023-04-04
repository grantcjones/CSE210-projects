using static System.Console;

public class Running : Activity
{
    private float _distance;
    private string _activityName = "Running";

    public Running(float distance, string date, int activityLength) : base (date, activityLength)
    {
        _distance = distance;
    }

    public override string ActivityName()
    {
        return _activityName;
    }

    public override float GetDistance()
    {   
        float distance = _distance; 
        return (float)Math.Round(distance, 1);        
    }
}