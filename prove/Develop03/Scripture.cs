public class Scripture
{
    List<Word> _scripture = new List<Word>();
    public Scripture(string scripture)
    {
        string[] parts = scripture.Split(" ");

        foreach (string part in parts) {
            _scripture.Add(new Word(part));
        }
    }

    public void Display()
    {
        foreach (Word word in _scripture)
        {
            word.Display();
        }
    }

    public void HideRandomWord(){
        Random random = new Random();
        int randNum = random.Next(_scripture.Count);

        _scripture[randNum].hideWord();
    }
}