using System;

public class Lecture : Event
{

    private string _speakerName;
    private int _eventCapacity;


    public Lecture(string title, string description, string date, string time, string street, string city, string state, string country, string name, int capacity) : base(title, description, date, time, street, city, state, country)
    {
        _speakerName = name;
        _eventCapacity = capacity;
    }


    public void FullDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        standardDetails();
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Seating Capacity: {_eventCapacity}\n");      
    }
}