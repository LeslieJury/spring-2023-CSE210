using System;

public class Goal
{
    // Member Variables for base class
    protected int _timesCompleted;
    protected string _goalName;
    protected string _goalDescription;
    protected int _basePoints;
    protected int _pointsEarned;
    protected bool _complete = false;

    public Goal()
    {
        Console.WriteLine("Ready to make a new goal? Perfect!\nWhat is the name of your goal?: ");
        _goalName = Console.ReadLine();
        Console.WriteLine("\nWhat is a short description of it?: ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("\nWhat is the amount of points associated with this goal?: ");
        _basePoints = int.Parse(Console.ReadLine());
    }

    public Goal(string goalName, string goalDescription, int basePoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _basePoints = basePoints;
    }

    public virtual int RecordEvent()
    {
       return _basePoints;
    }

    public virtual string ShowGoals()
    {
        return ($"[{GetCompleteChar()}] {_goalName} ({_goalDescription})");
    }

    public char GetCompleteChar()
    {
        if(_complete)
            return 'X';
        else
            return ' ';
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public virtual string ShowGoalName()
    {
        return _goalName;
    }


    public virtual string GetStringd()
    {
        string goalType = GetType().Name;
        return ($"{goalType}||{_goalName}||{_goalDescription}||{_basePoints}");
    }

    
}