using System;
using System.Collections.Generic;

public class Journal
{
    private Prompt _prompts;
    public DateTime _created;
    public List<Entry> _entries;
    public Journal(Prompt prompt)
    {
        _prompts = prompt;
        _entries = new List<Entry>();
        _created = DateTime.Today;
    }
    

    public void Write()
    {
        Entry newEntry = new Entry();

        Console.Write("Enter the date: ");
        string dateInput = Console.ReadLine();

        Console.Write("Leave blank for a random prompt, or type in your own!: ");
        string promptInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(promptInput))
        {
            newEntry.Prompt = _prompts.Random();
            Console.WriteLine(_prompts.Random());
        }
        else
        {
            newEntry.Prompt = promptInput;
        }

        Console.Write("Enter the text: ");
        newEntry.Text = Console.ReadLine();

        _entries.Add(newEntry);
        Console.WriteLine("Journal entry created successfully.");
    }


}