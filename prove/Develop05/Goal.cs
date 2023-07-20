using System;

public class Goal
{
    protected int _basePoints;

    protected int _pointsEarned;

    protected string _goalName;

    protected string _goalDescription;

    protected int _timesCompleted;

    protected bool _complete = false;


    public Goal()
    {
        Console.WriteLine("What is the name of your new goal?: ");

        _goalName = Console.ReadLine();
        
        Console.WriteLine("\nNow give me a short description of it: ");
        
        _goalDescription = Console.ReadLine();
        
        Console.WriteLine("\nHow many points is this goal worth?: ");
        
        _basePoints = int.Parse(Console.ReadLine());
    }

    public Goal(string goalName, string goalDescription, int basePoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _basePoints = basePoints;
    }
    public virtual string showGoals()
    {
        return ($"{_goalName}: ({_goalDescription})");
    }
    public virtual string showGoalName()
    {
        return _goalName;
    }

    public virtual int recordEvent()
    {
       return _basePoints;
    }

    public bool getComplete()
    {
        return _complete;
    }

    public virtual string getString()
    {
        string goalType = GetType().Name;
        return ($"{goalType}: {_goalName}: {_goalDescription}: {_basePoints}");
    }

    
}