using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Type your first and last name
        Console.WriteLine("What is your name?: ");

        // Assign the input to a variable
        string user_name = Console.ReadLine();

        // Find the index of the space so we can seperate the first and last name
        int space_index = (user_name.IndexOf(" "));

        // Assign the last word in the user name as the variable last_name
        string last_name = user_name.Substring(space_index);

        // Find first name (Not essential to this assignment but helpful for learning about Substrings)
        int length_full_name = user_name.Length - last_name.Length;
        string first_name = user_name.Substring(0, length_full_name);

        // Print everything out
        Console.WriteLine("Your name is " + last_name + ", " + first_name + last_name);
    }
}
