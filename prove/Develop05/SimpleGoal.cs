using System;
using static System.Console;

public class SimpleGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _pointValue;
    private int _type = 1;

    public SimpleGoal(string goalName, string description, int pointValue) : base(goalName, description, pointValue)
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
        // int index = myString.IndexOf("X");
        // if (index != 1)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }

        _isChecked = true;
    }

    public override void Display() {
    
        if (_isChecked) {
            Console.WriteLine($"[X] {_goalName} ({_description})");
        }
        else {

            Console.WriteLine($"[ ] {_goalName} ({_description})");
        }
    }
}