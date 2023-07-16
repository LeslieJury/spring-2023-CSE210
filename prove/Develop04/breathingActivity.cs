using System;

public class BreathingActivity : Activity
{
// Private Variable initiation.
    private int _breatheInTime = 5;
    private int _breatheOutTime = 5;

    public void runBreathingActivity()  // Main method for when the class is instantiated
    {
       Console.Clear();
       Console.WriteLine();

       int duration = 60;
       while (duration > 0)
       {
            Console.Write("Breath in...\n");
            Console.Write("Breath out...\n");
            duration -= _breatheInTime + _breatheOutTime;
       }
    }

}