using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Clean code", "Uncle Bob", 3600);
        v1.AddComment(new Comments("Allice", "Great video!!"));
        v1.AddComment(new Comments("Bob", "Very helpful!!"));
        videos.Add(v1);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}