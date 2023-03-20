using System;
using static System.Console;

public abstract class Goal
{
    private List<string> _goals = new List<string>(); //! add entries to
    private string _goalName;
    private string _description;
    private int _pointValue;

    public bool _isChecked = false;

    public Goal()
    {
        DisplayList();
    }

    public Goal(string goalName, string description, int pointValue) 
    {
        _goalName = goalName;
        _description = description;
        _pointValue = pointValue;
    }

    public abstract string GetGoal();
    //! To be used in other classes
    public abstract void IsCompleted(string myString);

    public void AddToList(List<string> myList, string myString)
    {
        int order = (myList.Count() + 1);
        myList.Add($"{order}. {myString}");
    }

    public void DisplayList()
    {
        WriteLine(_goals);
    }

    public virtual void Display() {

    }

    public int Score(int points)
    {
        return points + _pointValue;
    }

    public string HidePoints(string myString)
    {
        string newString = myString.Substring(myString.Length - 1);
        return newString;
    }

    // public void SaveGoal()
    // {
    //     throw new NotImplementedException();
    // }

    // public void SaveAllGoals()
    // {
    //     throw new NotImplementedException();
    // }

    // public void LoadGoals()
    // {
    //     throw new NotImplementedException();
    // }

    // public string RecordEvent()
    // {
    //     throw new NotImplementedException();
    // }

    // public void ListGoals()
    // {
    //     throw new NotImplementedException();
    // }
}