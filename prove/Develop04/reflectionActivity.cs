//using System;
//using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{

    private float duration = 0;

    private List<string> _randomPrompt = new List<string>()
    {
        "Consider a time where you helped someone.",
        "Think about a time where you felt at peace.",
        "Think of when someone helped you with something you struggled with.",
        "Consider an experience you had that made you feel grateful."
    };
    private List<string> _randomQuestion = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public string getRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompt.Count);
        return _randomPrompt[index] ;
    }

    public string getRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_randomQuestion.Count);
        return _randomQuestion[index];
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("Think about this prompt for a moment:\n");
        Console.WriteLine($">{getRandomPrompt()}");
        Console.WriteLine("\nPress enter when you are ready.");
        Console.ReadLine();

        // Using the built-in Stopwatch class which allows us to keep track of time after the user presses the enter key.
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int counter = 0;
        Console.CursorVisible = false;
        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.WriteLine(getRandomQuestion());
            counter++;
        } 

        stopwatch.Stop();
        Console.CursorVisible = true;



    }
}