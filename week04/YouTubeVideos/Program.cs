using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our program");
        List<Video> videos = new List<Video>();
        Video video1 = new Video { Title = "Casa de Papel", Author = "Professor", Length = 100 };
        video1.AddComment(new Comment { Name = "Bernice team", Text = "Great Team movie!" });
        video1.AddComment(new Comment { Name = "Martin king", Text = "Enjoying, thanks!" });
        video1.AddComment(new Comment {Name = "Gerge Bouche", Text = "Thanks for updating this for us "});
        
        Video video2 = new Video { Title = "Tony Star", Author = "Jane Smith", Length = 60 };
        video2.AddComment(new Comment { Name = "Sachard", Text = "Excellent guide." });
        video2.AddComment(new Comment { Name = "Joe", Text = "Thanks for the tips!" });
        Console.WriteLine("First Movie");
        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} minutes");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Here is the name of those who comment and their names:");

            foreach (var comment in video.GetComments())
            {
                
                Console.WriteLine($"Name  : {comment.Name}.");
                Console.WriteLine($"Comment : {comment.Text}.");
            }

            Console.WriteLine();
        }
    }
}
class Comment
{ 
    public string Name { get; set; } 
    public string Text { get; set; }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
   
}
