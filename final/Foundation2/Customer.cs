using System;

public class Customer
{
    // Declaring variables
    private string _userName;
    private Address _userAddress;
    
    // Constructing variables
    public Customer(string userName, Address address)
    {
        _userAddress = address;
        _userName = userName;
    }
    public Address userAddress()
    {
        return _userAddress;
    }

    public string userName()
    {
        return _userName;
        
    }

}