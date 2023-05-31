public class Board
{
    List<entry> _entries = new List<entry>();



    private void NicePrint(string item)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("{item}");

        Console.WriteLine("--------------------------------");
    }



    public void Showentrys()
    {
        foreach (entry entry in _entries)
        {
            NicePrint(entry.GetEntry());
        }
    }

    public void Addentry(entry entry)
    {
        _entries.Add(entry);
    }

    public void GetRandomentry()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _entries.Count());
        NicePrint(_entries[randomNumber].GetEntry());
    }

    public void FindentrysByAuthor(string author)
    {
        foreach (entry entry in _entries)
        {
            if(entry.HasAuthor(author))
            {
                NicePrint(entry.GetEntry());
            }
        }
    }


}