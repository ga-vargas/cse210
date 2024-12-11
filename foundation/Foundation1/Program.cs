using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Tutorial for Beginners", "Tech Guru", 600);
        Video video2 = new Video("Top 10 Programming Tips", "Code Master", 480);
        Video video3 = new Video("Learn Object-Oriented Programming", "Dev Insights", 720);

        //Add comments - video 1
        video1.AddComment(new Comment("Alice", "This is really helpful!"));
        video1.AddComment(new Comment("Bob", "I love the explanations."));
        video1.AddComment(new Comment("Charlie", "Clear and concise, thanks!"));

        //Add comments - video 2
        video2.AddComment(new Comment("Dave", "Great tips, I learned a lot."));
        video2.AddComment(new Comment("Eva", "Awesome video, keep it up!"));
        video2.AddComment(new Comment("Frank", "Very practical advice."));

        //Add comments - video 3
        video3.AddComment(new Comment("Grace", "OOP made simple, thanks!"));
        video3.AddComment(new Comment("Hank", "This clarified a lot for me."));
        video3.AddComment(new Comment("Ivy", "Well-structured and easy to follow."));

        //option to store all the comments together
        List<Video> videos = new List<Video> { video1, video2, video3 };

        //Display all videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");


            foreach (var comment in video.Comments)
                Console.WriteLine($"- {comment.Name}: {comment.Text}");

            Console.WriteLine();
        }
    }
}