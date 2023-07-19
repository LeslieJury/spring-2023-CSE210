using System;
using System.Collections.Generic;

public abstract class Activity
{

    protected string _activityDate;
    protected int _activityLength;
    protected List<Activity> _activityList;

    public Activity(string date, int minutes)
    {
        _activityDate = date;
        _activityLength = minutes;
    }

    public abstract double getDistance();
    public abstract double getSpeed(); 
    public abstract double getPace();

    public string getSummary()
    {
            return $"{_activityDate} {this.GetType().Name} ({_activityLength} min) - Distance {getDistance()} miles, Speed {getSpeed()} mph, Pace: {getPace()} min per mile";
    }
}