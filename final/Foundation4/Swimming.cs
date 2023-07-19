using System;

public class Swimming : Activity
{

    private int _laps;


    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double getPace()
    {
        return Math.Round(_activityLength / getDistance(), 2);
    }

    public override double getDistance()
    {
        return Math.Round((_laps * 50) / (0.62 * 100), 2);
    }

    public override double getSpeed()
    {
        return Math.Round((getDistance() / _activityLength) * 60, 2);
    }

}