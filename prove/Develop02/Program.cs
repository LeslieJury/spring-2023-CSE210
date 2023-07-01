using System;
using System.Collections.Generic;
using System.IO;


public class Program
{
    private static Journal journal;
    private static Prompt prompt;
    private static FileAction fileAction;


    public static void Main(string[] args)
    {
        prompt = new Prompt();
        journal = new Journal(prompt);
        fileAction = new FileAction("default.json");

    // Load the default.json file if it exists

        fileAction.Load(journal, prompt);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("MENU\n1. Create new journal entry\n2. Write a prompt\n3. Remove a prompt\n4. Display journal entries\n5. Load a Journal\n6. Save a Journal\n7. Quit\n\nEnter your choice: ");


            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        journal.Write();
                        break;
                    case 2:
                        prompt.Add();
                        break;
                    case 3:
                        prompt.Remove();
                        break;
                    case 4:
                        journal.Display();
                        break;
                    case 5:
                        fileAction.Load(journal, prompt);
                        break;
                    case 6:
                        fileAction.Save(journal, prompt);
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
            }
        }
    }
}