using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int userInput = 0;
        int totalPoints = 0;
        string filename;
        List<Goal> _goalList = new List<Goal>();

        Console.Clear();
        Console.WriteLine("Welcome to the beautiful goal setting program to help you have amazing goals for all eternity!\n");

        while (userInput != 6)
        {
        Console.WriteLine($"You currently have {totalPoints} points.\n");
        Console.Write("Menu Options: \n");
        Console.Write("1.  Create A New Goal \n2.  List Goals \n3.  Save Goals \n4.  Load Goals \n5.  Record Event \n6.  Quit \n"); 
        Console.Write("Select a choice from the menu: ");
        userInput = int.Parse(Console.ReadLine());

        
        if (userInput == 1)
        {
            Console.WriteLine("\nThe types of Goals are: ");
            Console.WriteLine("1.  Simple Goal \n2.  Eternal Goal \n3.  Checklist Goal \n");
            Console.Write("Please make a selection from the menu: ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userAnswer == 1)
            {
                ShortGoal small = new ShortGoal();
                _goalList.Add(small);
            }

            if (userAnswer == 2)
            {
                EternalGoal large = new EternalGoal();
                _goalList.Add(large);
            }
            

            if (userAnswer == 3)
            {
                ChecklistGoal check = new ChecklistGoal();
                _goalList.Add(check);
            }
        } 

        if (userInput == 3)
        {
            Console.Write("Please enter the filename for your goals: ");
            filename = Console.ReadLine();
            SaveLoad file = new SaveLoad();
            file.SaveToFile(filename, _goalList, totalPoints);
        }

        if (userInput == 4)
        {
            Console.Write("Please enter the filename for your goals: ");
            filename = Console.ReadLine();
            SaveLoad goals = new SaveLoad();
            goals.LoadFile(filename);
        }

        }   
    }
}