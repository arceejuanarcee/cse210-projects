using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Introduction to Programming", "John Doe", 600);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 1200);
        Video video3 = new Video("Understanding Databases", "Alice Johnson", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "I learned a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a video on interfaces?"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Excellent presentation."));
        video2.AddComment(new Comment("Eve", "Loved the examples provided."));
        video2.AddComment(new Comment("Frank", "This is very advanced, but useful."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Good overview of databases."));
        video3.AddComment(new Comment("Hank", "Could you cover SQL in the next video?"));
        video3.AddComment(new Comment("Ivy", "The examples were very helpful."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the details of each video
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}
