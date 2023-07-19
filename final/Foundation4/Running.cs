using System;

public class Running : Activity
{
    private double _runningDistance;
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _runningDistance = distance;
    }

    public override double getDistance()
    {
        return _runningDistance;
    }

    public override double getSpeed()
    {
        return Math.Round((_runningDistance / _activityLength) * 60, 2);
    }

    public override double getPace()
    {
        return Math.Round((_activityLength / _runningDistance), 2);
    }
}