using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?: ");

        string your_grade = Console.ReadLine();

        int num_grade;

        num_grade = (Convert.ToInt32(your_grade));

        if (num_grade > 90)
        {
            Console.WriteLine("You have an A!");
        }
        else if (num_grade > 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (num_grade > 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (num_grade > 60)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");

        }
    }
}