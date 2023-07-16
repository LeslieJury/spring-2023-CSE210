using System;

public class Product
{

    private string _name;
    private int _quantity;
    private float _price;
    private string _ID;
    
    public Product(string name, int quantity, float price, string id)
    {
        _name = name;
        _quantity = quantity;
        _price = price;
        _ID = id;
    }

    public string getProductName()
    {
        return _name;
    }
    public int getProductQuantity()
    {
        return _quantity;
    }
    public float getSubtotalPrice()
    {
        return _price * _quantity;
    }
    public string getProductID()
    {
        return _ID;
    }



}