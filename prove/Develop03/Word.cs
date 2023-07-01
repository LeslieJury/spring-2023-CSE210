public class Word
{
    private string _word;
    private Boolean _isHidden = false;

    public Word(string word){
        _word = word;
    }

    public void Display()
    {
        // Word myWord = new Word("Leslie", true);
        // Word yourWord = new Word("Ocean", false);

        if (_isHidden == false){
            Console.Write($"{_word} ");
        }
        else {
            foreach (char character in _word) //Maybe turn the string into a list of chars to loop through
            {
                Console.Write("_");
            }
            Console.Write(" ");

        }

        // if (isHidden(myWord) == true)
        // {
        //     Console.WriteLine("This word is hidden!");
            
        //     Console.WriteLine($"Original odd: {Word}");
        //     string newWord = Word.replace('_');
        //     Console.WriteLine($"New Odd: {newWord}");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("This word is not hidden!");
        // }
    }

    public void hideWord(){
        _isHidden = true;
    }

}