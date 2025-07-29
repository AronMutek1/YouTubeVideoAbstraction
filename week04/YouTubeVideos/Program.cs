using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Rice", "Chef Daniel", 300);
        video1.AddComment(new Comment("Anna", "Thanks! Very helpful."));
        video1.AddComment(new Comment("Mike", "Great tutorial."));
        video1.AddComment(new Comment("Lucy", "Clear instructions."));

        Video video2 = new Video("Learn C# in 10 Minutes", "TechieTom", 600);
        video2.AddComment(new Comment("Sarah", "Perfect for beginners."));
        video2.AddComment(new Comment("James", "Concise and useful."));
        video2.AddComment(new Comment("Emily", "Loved the examples."));

        Video video3 = new Video("Travel Vlog - Uganda", "ExplorerZed", 720);
        video3.AddComment(new Comment("Linda", "Beautiful place!"));
        video3.AddComment(new Comment("Brian", "Adding this to my bucket list."));
        video3.AddComment(new Comment("George", "Nice editing."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");
            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
