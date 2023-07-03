using System;
using System.Collections.Generic;
using System.IO;


public class Program
{
    private static Journal journal;
    private static Prompt prompt;
    private static Menu menu;


    public static void Main(string[] args)
    {
        prompt = new Prompt();
        journal = new Journal(prompt);

        bool exit = false;
        while (exit ==  false)
        {
            Console.WriteLine(menu);
            Console.WriteLine("\nSelect which you'd like: ");
            string userInput = Console.ReadLine();

            


        }
    }
}