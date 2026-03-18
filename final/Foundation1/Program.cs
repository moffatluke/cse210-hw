using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("VIDEOS:");
        Console.WriteLine();


        List<Video> videos = new List<Video>();

        //Video 1 coding 
        Video v1 = new Video("Clean code", "Uncle Bob", 3600);
        v1.AddComment(new Comment("Allice", "Great video!!"));
        v1.AddComment(new Comment("Bob", "Very helpful!!"));
        videos.Add(v1);



        //Video 2 spider-man
        Video v2 = new Video("Spider-Man: Brand New Day Trailer", "Marvel Entertainment", 2000);
        v2.AddComment(new Comment("Steven", "I's so excited for this!!"));
        v2.AddComment(new Comment("Roger", "This is the best thing to happen this year!!"));
        videos.Add(v2); //add everything to the v2 video

        //video 3 dune
        Video v3 = new Video("Dune: Part Two Trailer", "Warner Bros", 2880);
        v3.AddComment(new Comment("Marcus", "The cinematography is insane!"));
        v3.AddComment(new Comment("Sarah", "Can't wait for this movie."));
        v3.AddComment(new Comment("Jordan", "Best sci-fi movie ever made."));
        videos.Add(v3);

        //Video 3 apple
        Video v4 = new Video("iPhone 15 Pro Max Review", "Apple", 4200);
        v4.AddComment(new Comment("Lisa", "The camera is absolutely incredible."));
        v4.AddComment(new Comment("Chris", "Worth every penny."));
        v4.AddComment(new Comment("Maya", "Game-changing technology."));
        videos.Add(v4);



        //Video 3
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}