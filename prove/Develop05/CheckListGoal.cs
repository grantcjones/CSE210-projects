using System;
using static System.Console;

public class CheckListGoal : Goal
{
    private string _goalName;
    private string _description;
    private int _pointValue;
    private int _goalAmount;
    private int _currentAmount;
    private int _type = 2;

    public CheckListGoal(string goalName, string description, int pointValue, int goalAmount) : base(goalName, description, pointValue)
    {
        _goalName = goalName;
        _description = description;
        _pointValue = pointValue;
        _goalAmount = goalAmount;
    }

    public override string GetGoal()
    {
        return ($"[_] {_goalName} ({_description}) - {_currentAmount}/{_goalAmount} {_pointValue} {_type}"); //TODO Add Bonus
    }

    public override bool IsCompleted(string myString) //TODO Add to option 4. Load?
    {
        if (_currentAmount > _goalAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // {
    //     if (_currentAmount == _goalAmount)
    //     {
    //         return ($"[X] {_goalName} ({_description}) - {_currentAmount}/{_goalAmount}");
    //     }
    //     else if (_currentAmount > _goalAmount)
    //     {
    //         return ($"[X] {_goalName} ({_description}) - {_goalAmount}/{_goalAmount}\nThis goal has been completed, you little overachiever.");
    //     }
    //     else
    //     {
    //         return GetGoal();
    //     }

    // }
}