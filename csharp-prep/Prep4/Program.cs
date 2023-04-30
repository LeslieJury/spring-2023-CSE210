using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        Console.WriteLine("Please enter some numbers for our list, select 0 when you are finished!: ");
        string userInput = Console.ReadLine();
        int numInput = (Convert.ToInt32(userInput)); 

        while (numInput != 0)
        {
            nums.Add(numInput);
            
        }

        Console.WriteLine("Hello Prep4 World!");
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}