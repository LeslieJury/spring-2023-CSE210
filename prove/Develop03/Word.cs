public class Word
{
    private string _word = "";
    private Boolean _isHidden = false;

    public Word(string word, Boolean isHidden){
        _word = word;
        _isHidden = isHidden;
    }

    static void Main(String[] args)
    {
        Word myWord = new Word("Leslie", true);
        Word yourWord = new Word("Ocean", false);

        Console.WriteLine(yourWord.isHidden);


        if (myWord(isHidden) == true)
        {
            Console.WriteLine("This word is hidden!");
            
            foreach (char character in myWord) //Maybe turn the string into a list of chars to loop through
            {
                Console.WriteLine("let's replace this one at a time!");
                // Replace a char
            Console.WriteLine($"Original odd: {Word}");
            string newWord = Word.replace('_');
            Console.WriteLine($"New Odd: {newWord}");
            }
        }
        else
        {
            Console.WriteLine("This word is not hidden!");
        }




    }

}