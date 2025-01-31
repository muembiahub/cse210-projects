using System;
using System.Collections.Generic;

class Comment
{ 
    public string Name { get; set; } 
    public string Text { get; set; }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video { Title = "C# Tutorial", Author = "John Doe", Length = 600 };
        video1.AddComment(new Comment { Name = "Alice", Text = "Great tutorial!" });
        video1.AddComment(new Comment { Name = "Bob", Text = "Very helpful, thanks!" });
        video1.AddComment(new Comment { Name = "Charlie", Text = "I learned a lot." });

        Video video2 = new Video { Title = "Tony Star", Author = "Jane Smith", Length = 1200 };
        video2.AddComment(new Comment { Name = "Dave", Text = "Excellent guide." });
        video2.AddComment(new Comment { Name = "Eve", Text = "Thanks for the tips!" });
        video2.AddComment(new Comment { Name = "Frank", Text = "Well explained." });

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}