using System;

public class ChecklistGoal: Goal
{
    private int _bonusPoints;
    private int _goalNumMax;
    private int _goalCounter = 0;

    public ChecklistGoal() 
    {
        Console.WriteLine("How many times does this goal need to be done?");
        _goalNumMax = int.Parse(Console.ReadLine());
        Console.WriteLine($"How many bonus points do you get for completing this goal {_goalNumMax} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public ChecklistGoal(string goalName, string goalDescription, int basePoints, int bonusPoints, int goalNumMax, int goalCounter) : base(goalName, goalDescription, basePoints)
    {
        _bonusPoints = bonusPoints;

        _goalNumMax = goalNumMax;
        
        _goalCounter = goalCounter;
    }


    public override int recordEvent()
    {
        int totalPoints = _basePoints + _bonusPoints;
        _goalCounter++;

        if (_goalCounter == _goalNumMax)
        {
            _complete = true;
            return totalPoints;
        }
        return _basePoints;
        
        
    }

    public override string getString()
    {
        string goalType = GetType().Name;
        return ($"{goalType}||{_goalName}||{_goalDescription}||{_basePoints}||{_bonusPoints}||{_goalNumMax}||{_goalCounter}");
    }
}