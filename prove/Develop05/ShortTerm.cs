using System;

public class ShortGoal: Goal
{

    public ShortGoal()
    {
        
    }

    public ShortGoal(string goalName, string goalDescription, int basePoints, bool _complete) : base(goalName, goalDescription, basePoints)
    {
        _complete = getComplete();
    }

    public override int recordEvent()
    {
        _complete = true;
        return _basePoints;
    }

    public override string getString()
    {
        string goalType = GetType().Name;
        return ($"{goalType}||{_goalName}||{_goalDescription}||{_basePoints}||{_complete}");
    }


}