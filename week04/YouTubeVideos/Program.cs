using System;
using System.Collections.Generic;

class YouTubeVideos
{
    static void Main(string[]args)
    {
        // Create comments
        Comment comment1 = new Comment("Eddy","The stunts in this movie are unbelievable! The car chase scenes are out of this world.");
        Comment comment2 = new Comment("Ephraim", "John McClane is such a badass. He makes jumping off a building look easy!");
        Comment  comment3 = new Comment("Eugenie","This movie is a laugh riot. The awkward teenage antics are so relatable.");
    // create videos 
       Video video1 = new Video("Mad Max"); //
       Video video2 = new Video("Die Hard");
       Video video3 = new Video ("Superbad");
    // Add comments to Videos
       video1.Addcomment(comment1);
       video2.Addcomment(comment2);
       video3.Addcomment(comment3);
    // Display video Details
       Console.WriteLine("Welcome to our Label Movies ");
       Console.WriteLine("\nPress Enter to Contunue.");
       Console.ReadLine();
       Console.WriteLine("First Movie");
       Console.WriteLine(video1.GetVideoDetails());
       Console.WriteLine("\nPress Enter to Contunue.");
       Console.ReadLine();
       Console.WriteLine("Second Movie");
       Console.WriteLine(video2.GetVideoDetails());
    Console.WriteLine("\nPress Enter to Contunue."); // Prompt user to press Enter to continue to the next movie
       Console.ReadLine(); 
       Console.WriteLine("Third Movie");// 
       Console.WriteLine(video3.GetVideoDetails());
       Console.WriteLine("Good bye bye");

    }
}
class Video
{
    public string Title{ get; set; }
    public List<Comment> Comments { get; set; }

    public Video (string title)
    {
        Title = title;
        Comments = new List<Comment>();
    }
    public void Addcomment(Comment comment)
    {
        Comments.Add(comment);
    }
    public string GetVideoDetails()
    {
        string details = $"Title : {Title}\n";
        foreach (var comment in Comments)
        {
            details += $"Author Name:{comment.Author}\n";
            details += $"Comment:  {comment.Content}";
        }
        return details;
    }
}
class Comment
{
    public string Author { get; set; }
    public string Content { get; set; }

    public Comment(string author, string content)
    {
        Author = author;
        Content = content;
    }
}

