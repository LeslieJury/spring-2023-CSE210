using System;

public class Event
{
    private Address _address;
    private string _title;
    private string _date;
    private string _time;
    private string _description;


    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _address = new Address (street, city, state, country);
        _date = date;
        _time = time;
        _title = title;
        _description = description;

    }

    public Address displayAddress()
    {
        return _address;
    }

    public void standardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.Write($"Address: {displayAddress().getAddress()}\n");


    }

    public void shortDescription()
    {
        Console.WriteLine($"A {this.GetType()} Event");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}\n");

    }

}