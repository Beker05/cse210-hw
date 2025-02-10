using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C# in 10 Minutes", "Programming Guru", 600);
        Video video2 = new Video("Mastering OOP in C#", "Code Academy", 1200);
        Video video3 = new Video("Encapsulation Explained", "Tech Explained", 900);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you do one for Python?"));

        video2.AddComment(new Comment("David", "Best explanation ever!"));
        video2.AddComment(new Comment("Eve", "I finally understand OOP."));
        video2.AddComment(new Comment("Frank", "Subscribed!"));

        video3.AddComment(new Comment("Grace", "I love how you explain things!"));
        video3.AddComment(new Comment("Hank", "Very detailed and clear."));
        video3.AddComment(new Comment("Ivy", "Keep up the good work!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}