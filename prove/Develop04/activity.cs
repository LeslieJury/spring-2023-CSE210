using System.Diagnostics;
public class Activity
{
    private string _activityName, _description;
    static int _duration;

    public Activity()
    {
        _duration = 0;
    }
    public Activity(string name, string description, int duration = 0)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }
}