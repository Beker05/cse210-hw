using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _duration; 
    private List<Comment> _comments;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"   - {comment.GetCommentInfo()}");
        }
        Console.WriteLine(new string('-', 40)); 
    }
}
