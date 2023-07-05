public class Menu
{
    List<string> defaultMenu = new List<string>()
    {
        "Write", "Display", "Load", "Save", "Quit"
    };


    // Display function updated after first submission.
    public void Display()
    {
        int i = 0;
        foreach(string menuItem in defaultMenu)
        {
            Console.WriteLine($"{i++}{menuItem}");
        }
    }


}