public class Video
{
    // Member Variables
    public string _title;
    public string _author;
    public int _durationMin;
    public int _durationSec;
    public List<Comment> _comments = new List<Comment>();

    // Constructors
    public Video()
    {
        string title = _title;

        string author = _author;

        int durationMin = _durationMin;

        int durationSec = _durationSec;

        List<Comment> comments = _comments;

    }

    // Methods
    public void commentsPerVideo()
    {
        int commentNumber = _comments.Count;

        Console.Write($"This video has {commentNumber} comment(s):");
    }

    public void displayVideo()
    {
        Console.WriteLine($"{_title} by: {_author} ");
        Console.Write($"Duration: {_durationMin}:{_durationSec}\n");
        commentsPerVideo();

        foreach (Comment comment in _comments)
        {
            comment.displayComment();
        }
    }

}