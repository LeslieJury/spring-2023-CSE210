using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the field day celelbration sponsored by Leslie Corp.\n");

        List<Activity> _activityList = new List<Activity>();

        Swimming twelveLaps = new Swimming("12/29/2003", 128, 12);
        _activityList.Add(twelveLaps);

        Running fiveHundredMeterDash = new Running("03/31/2020", 100, 500);
        _activityList.Add(fiveHundredMeterDash);

        Cycling tourDeLaFrance = new Cycling("09/09/1999", 250, 6.8);
        _activityList.Add(tourDeLaFrance);

        foreach(Activity activity in _activityList)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}