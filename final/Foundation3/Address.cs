using System;

public class Address
{
    // Declaring variables
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructing variables
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    // Reused from Foundation 2
    public string getAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
    public void setAddress(string street, string city, string state, string country)
    
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string getCountry()
    {
        return _country;
    }

    public void setCountry(string country)
    {
        _country = country;
    }

}