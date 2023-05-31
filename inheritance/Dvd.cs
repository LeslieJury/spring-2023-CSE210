public class Dvd : Loanable
{
    private string _runtime;

    public override void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
        
    }
}