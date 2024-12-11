using System.Collections.Generic;
public class Video
{
    public string Title { get; set; } // title of the video
    public string Author { get; set; } // who is the author 
    public int Length { get; set; } // length of the video
    public List<Comment> Comments { get; private set; } // Comments

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }
}