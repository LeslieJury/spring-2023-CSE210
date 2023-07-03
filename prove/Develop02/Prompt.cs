using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> prompts;

    public Prompt()
    {
        prompts = new List<string>();
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        prompts.Add("What is something you did that made you feel happy today?");
        prompts.Add("What is one interesting thing you've experienced or seen today?");
        prompts.Add("Did you see any friends or family today?");
        prompts.Add("Name your favorite childhood toy and why.");
    }


    public string Random()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void Add()
    {
        Console.Write("Add a new prompt?: ");
        string newPrompt = Console.ReadLine();
        prompts.Add(newPrompt);
        Console.WriteLine("Prompt added successfully.");
    }

    public void Remove()
    {
        Console.WriteLine("Entry List");
        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the number of the prompt to remove: ");
        if (int.TryParse(Console.ReadLine(), out int selectedPrompt))
        {
            if (selectedPrompt >= 1 && selectedPrompt <= prompts.Count)
            {
                string removedPrompt = prompts[selectedPrompt - 1];
                prompts.RemoveAt(selectedPrompt - 1);
                Console.WriteLine($"Prompt '{removedPrompt}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid prompt number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}