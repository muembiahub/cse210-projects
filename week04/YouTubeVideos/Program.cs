using System;
using System.Collections.Generic;

class YouTubeVideos
{
    static void Main(string[]args)
    {
        // Create comments on videos
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
    // Display video Details and ask user to press Enter to continue to the next movie
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
// Create a class called Video
class Video
{
    public string Title{ get; set; } // Add a property called Title
    public List<Comment> Comments { get; set; } // Add a property called Comments

    public Video (string title) // Add a constructor that takes a title as a parameter
    {
        Title = title; // Set the Title property to the value of the title parameter
        Comments = new List<Comment>(); // Initialize the Comments property as a new List of Comment objects
    }
    public void Addcomment(Comment comment) 
    {
        Comments.Add(comment); // Add a method called AddComment that takes a Comment object as a parameter and adds it to the Comments list
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
class Comment // Create a class called Comment
{
    public string Author { get; set; } // Add a property called Author
    public string Content { get; set; } // Add a property called Content

    public Comment(string author, string content)
    {
        Author = author;
        Content = content;
    }
}

