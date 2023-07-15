public class Comment
{
    // Declaring Variables
    public string _userName;
    public string _comment;


    public Comment()
    {
        string userName = _userName;
        string comment = _comment;
    }

    // Method
    public void displayComment()
    {
        Console.WriteLine($"\n@{_userName}'s comment: {_comment}");
    }
}