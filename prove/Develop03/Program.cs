using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("And God said, let there be light");

        while (true){
            Console.ReadLine();
            scripture.HideRandomWord();
            scripture.Display();
        }
    }


}