using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create some Video instances
        Video video1 = new Video("Learning C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Thanks for the help."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        
        Video video2 = new Video("Understanding Abstraction", "Jane Smith", 450);
        video2.AddComment(new Comment("David", "This really clears things up."));
        video2.AddComment(new Comment("Eve", "Very helpful examples."));
        
        Video video3 = new Video("OOP Principles", "Mike Johnson", 600);
        video3.AddComment(new Comment("Frank", "I love the way you explain!"));
        video3.AddComment(new Comment("Grace", "Awesome content!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(); // Blank line for spacing
        }
    }
}
