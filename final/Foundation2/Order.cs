using System;
using System.Collections.Generic;

public class Order
{
    // Declaring variables
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    // Constructing variables
    public Order(string customerName, string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country); // Makes an instance of the Address class.
        _customer = new Customer(customerName, address); // Get the customer's name.
    }
    public void printPackingSlip()
    {
        Console.WriteLine("Leslie's Grocery Store Checkout List:");

        foreach(Product product in _productList)
        {
            Console.WriteLine($"{product.getProductID()}: {product.getProductName()} ({product.getProductQuantity()})");
        }
    }

    public void printShippingLabel()
    {

        Console.WriteLine("Leslie's Grocery Store Shipping: ");
        Console.WriteLine(_customer.userName());
        Console.WriteLine(_customer.userAddress().getAddress());
    }

    public double calculateShippingCosts()
    {
        // Applies overseas shipping
        if (_customer.userAddress().getCountry())
            return 1.99;
        else
            return 10.99;
    }

    public double totalOrderPrice()
    {
        double cost = 0 + calculateShippingCosts(); 
        foreach(Product product in _productList)
        {
            cost += product.getSubtotalPrice();
        }

        double twoDecimal = Math.Round(cost, 2);

        return twoDecimal;
    }


    public void addProduct(string name, int quantity, double price, string id)
    {
        // Price is having issues with its data type right now.
        Product product = new Product(name, quantity, price, id);
        _productList.Add(product);

    }
}