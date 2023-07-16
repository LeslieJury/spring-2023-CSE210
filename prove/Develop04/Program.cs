using System;

class Program
{
    static void Main(string[] args)
    {
        int usrMenuOpt = 0;

        List<string> menu = new List<string>
        {
            " - menu - ", "1. Breathing activity", "2. Reflection activity", "3. Listening activity", "4. Quit"
        };

        

        while (usrMenuOpt != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Choice an activity from the menu: ");
            string userChoice =  Console.ReadLine();
            Console.Clear();
            Console.Write($"Welcome to {userChoice}");

        }
    }

}