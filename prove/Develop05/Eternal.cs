using System;

public class EternalGoal: Goal
{

    public EternalGoal()
    {
        
    }

    public EternalGoal(string goalName, string goalDescription, int basePoints) : base(goalName, goalDescription, basePoints)
    {
        // Everything Inherited from parent class
    }

    public override int recordEvent()
    {
        return _basePoints;
    }

    public string displayGoalName()
    {
        return _goalName;
    }
}