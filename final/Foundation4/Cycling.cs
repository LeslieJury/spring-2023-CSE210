using System;

public class Cycling : Activity
{
    
    private double _cyclingSpeed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _cyclingSpeed = speed;
    }

    public override double getDistance()
    {
        return Math.Round(_cyclingSpeed * (_activityLength / 60), 2);
    }

    public override double getSpeed()
    {
        return _cyclingSpeed;
    }

    public override double getPace()
    {
        return Math.Round(_activityLength / getDistance(), 2);
    }
}