using System;

public class Video
{
    private string _title;
    private string _channel;
    private int _lengthofVideo;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string channel, int lengthofVideo)
    {
        _title = title;
        _channel = channel;
        _lengthofVideo = lengthofVideo;
    }
    public void makeComment(Comment comment)
    {
        _comments.Add(comment);
    }
    private void PrintComments()
    {
        foreach (var comment in _comments)
        {
            comment.PrintComment();
        }
    }
    public void PrintVideo()
    {
        Console.WriteLine($"Title : {_title}\n Channel : {_channel}\n Length : {_lengthofVideo} minutes\n");
        Console.WriteLine("# of Comments: "+_comments.Count);
        PrintComments();
    }
}