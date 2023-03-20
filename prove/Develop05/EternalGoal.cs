using System;
using static System.Console;

public class EternalGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _pointValue;
    private int _type = 3;

    public EternalGoal(string goalName, string description, int pointValue) : base(goalName, description, pointValue)
    {
        _goalName = goalName;
        _description = description;
        _pointValue = pointValue;
    }

    public override string GetGoal()
    {
        return ($"[_] {_goalName} ({_description}) {_pointValue} {_type}");
    }

    public override void IsCompleted(string myString)
    {

    }

    public override void Display() {

        Console.WriteLine($"[ ] {_goalName} ({_description})");
        
    }
}