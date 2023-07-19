using System;

public class Cycling : Activity
{
    // Private member variables
    private double _cyclingSpeed;

    // Constructors
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _cyclingSpeed = speed;
    }

    // Methods
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