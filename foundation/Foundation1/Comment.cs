using System;

public class Comment
{
    private string _username;
    private string _commentText;

    public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;
    }
    public void PrintComment()
    {
        Console.WriteLine($"{_username} : {_commentText}");
    }
}