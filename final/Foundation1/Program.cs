using System;

class Program
{
    static void Main(string[] args)
    { 
        Comment comment0 = new Comment();

        comment0._userName = "AnimeFan2004";
        comment0._comment = "Love this video, congrats";


        Video video0 = new Video();

        video0._title = "This instagram page is WILD!";
        video0._author = "LeslieLovesGaming";
        video0._durationMin = 11;
        video0._durationSec = 45;
        video0._comments.Add(comment0);

        video0.displayVideo();
    }
}