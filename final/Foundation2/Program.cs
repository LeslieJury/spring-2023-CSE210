using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write(" -* Leslie's Grocery Store *- \n");
        Order order0 = new Order("Jotaro Kujo", "504 Happy Dr.", "Tokyo", "Tokyo", "Japan");

        double doublePrice = Convert.ToDouble(39.99);
        order0.addProduct("Black Boots", 1, (doublePrice), "B12");
        order0.printPackingSlip();

        order0.printShippingLabel();

        Console.WriteLine($"Total Price: ${order0.totalOrderPrice()}");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
        Order order1 = new Order("Shinji Ikari", "01 Nerv Blvd.", "Tokyo-3", "Unknown", "Japan");

        doublePrice = Convert.ToDouble(49.99);
        order1.addProduct("Walkman", 1, (doublePrice), "ABCD");
        order1.printPackingSlip();


        order1.printShippingLabel();

        Console.WriteLine($"Total Price: ${order1.totalOrderPrice()}");




        
    }
}