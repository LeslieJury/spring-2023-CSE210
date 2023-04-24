using System;


//https://www.geeksforgeeks.org/c-sharp-random-next-method/ I used this as reference for using the random function.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guessing game! Guess a number between 1 and 100! : "); //Get input from user

        string your_guess = Console.ReadLine();

        int num_guess;

        num_guess = (Convert.ToInt32(your_guess)); //Type cast it to be an integer

        // Instantiate random number generator
        Random rand = new Random();
        
        int rand_value = rand.Next(1, 101);
        Console.WriteLine(rand_value);

        while (num_guess != rand_value)
        {
            if (num_guess > rand_value)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Too Low!");

            }

            Console.WriteLine("Oops, that's wrong, try again! : "); //Get new input from user

            your_guess = Console.ReadLine();

            

            num_guess = (Convert.ToInt32(your_guess)); //Type cast it to be an integer

        }
        Console.WriteLine("Congratulations! You guessed correctly!")
    }
}