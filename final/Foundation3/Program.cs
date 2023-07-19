using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Leslie's fantastic event planner\nA list of upcoming events:\n");

        Lecture evangelionLore = new Lecture("Neon Genesis Evangelion: The Anime of All Time", "This is a lecture on my favorite anime.", "July 30, 2023", "10:00 a.m.", "BYU-Idaho Campus", "Rexburg", "ID", "United States", "Ms. Leslie Jury", 1000);
        Console.WriteLine("Would you like to see the\n1. Standard Details\n2. Full Description\n3. Short Description\n4. All of the above");

        string userInput = Console.ReadLine();
        if (userInput == "1"){
            Console.WriteLine("Standard Details: ");
            evangelionLore.standardDetails();
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Full Description: ");
            evangelionLore.FullDescription();
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Short Description: ");
            evangelionLore.shortDescription();
        }
        else if (userInput == "4")
        {
            Console.WriteLine("Standard Details: ");
            evangelionLore.standardDetails();

            Console.WriteLine("Full Description: ");
            evangelionLore.FullDescription();

            Console.WriteLine("Short Description: ");
            evangelionLore.shortDescription();
        }
        else 
        {
            Console.WriteLine("That isn't a valid option, please try again.");
        }
        Reception TSConcert = new Reception("Taylor Swift Era's Tour", "Taylor Swift's most recent stadium tour", "July 19, 2023", "5:00 p.m.", "Deerwood Dr.", "Boulder", "CO", "United States", "taylorswift@taylorswift.com");
        Console.WriteLine("Would you like to see the\n1. Standard Details/n2. Full Description\n3. Short Description\n4. All of the above");

        userInput = Console.ReadLine();
        if (userInput == "1"){
            Console.WriteLine("Standard Details: ");
            TSConcert.standardDetails();
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Full Description: ");
            TSConcert.FullDescription();
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Short Description: ");
            TSConcert.shortDescription();
        }
        else if (userInput == "4")
        {
            Console.WriteLine("Standard Details: ");
            TSConcert.standardDetails();

            Console.WriteLine("Full Description: ");
            TSConcert.FullDescription();

            Console.WriteLine("Short Description: ");
            TSConcert.shortDescription();
        }
        else 
        {
            Console.WriteLine("That isn't a valid option, please try again.");
        }
        Outdoor squidGames = new Outdoor("The Squid Games", "Do you have money issues? Try for a game of life or death for a chance to win millions of dollars.", "September 21, 2021", "12:00 a.m.", "Abandoned Island", "Seoul", "Seoul", "South Korea", "High humidity and 75% chance of rain.");
        Console.WriteLine("Would you like to see the\n1. Standard Details/n2. Full Description\n3. Short Description\n4. All of the above");

        userInput = Console.ReadLine();
        if (userInput == "1"){
            Console.WriteLine("Standard Details: ");
            squidGames.standardDetails();
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Full Description: ");
            squidGames.FullDescription();
        }
        else if (userInput == "3")
        {
            Console.WriteLine("Short Description: ");
            squidGames.shortDescription();
        }
        else if (userInput == "4")
        {
            Console.WriteLine("Standard Details: ");
            squidGames.standardDetails();

            Console.WriteLine("Full Description: ");
            squidGames.FullDescription();

            Console.WriteLine("Short Description: ");
            squidGames.shortDescription();
        }
        else 
        {
            Console.WriteLine("That isn't a valid option, please try again.");
        }
    }
}