public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; } // name and text of the comment

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}