using System;
using System.IO;

public class SaveLoad
{
    public void save(string filename, List<Goal> _goalList, int totalPoints)
    {

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(totalPoints);

            foreach (Goal goal in _goalList)
            {
                file.WriteLine(goal.getString());
            }

        }
    }

    public List<Goal> load(string filename) 
    {
        List<Goal> goals = new List<Goal>();

        string[] lines = File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {   
            string[] data = line.Split(":");
                switch(data[0])
                {               
                    case "SimpleGoal":
                    ShortGoal goal = new ShortGoal(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]));
                    goals.Add(goal);
                    break;
                }
                switch(data[0])
                {
                    case "EternalGoal":
                    EternalGoal goal = new EternalGoal(data[1], data[2], int.Parse(data[3]));
                    goals.Add(goal);
                    break;
                }
                switch(data[0])
                {
                    case "ChecklistGoal":
                    ChecklistGoal goal = new ChecklistGoal(data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                    goals.Add(goal);
                    break;
                }
        } 
        return goals;
    }

    
}