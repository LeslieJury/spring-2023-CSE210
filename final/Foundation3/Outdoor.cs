using System;

public class Outdoor : Event
{

    private string _weatherForecast;


    public Outdoor(string title, string description, string date, string time, string street, string city, string state, string country, string forecast) : base(title, description, date, time, street, city, state, country)
    {
        _weatherForecast = forecast;
    }


    public void FullDescription()
    {
        Console.WriteLine($"{this.GetType()} Event");
        standardDetails();
        Console.WriteLine($"Today's weather is looking like this: {_weatherForecast}\n");      
    }
}