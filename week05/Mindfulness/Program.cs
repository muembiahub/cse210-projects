using System;
using System.Threading;

class Program
{
    
    static void Main(string[] args)
    {
        LoadLog();
        // Create instances of different activities
        // and the one I have added to show my Creativity and Exceeding Requirements
        // I have added a new class DancingActivity that inherits from Activity

        BreathingActivity breathingActivity = new BreathingActivity("Breathing activity", "Breathing", "Take a deep breath in and out", "30 seconds");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting activity", "Reflecting", "Think about a time when you helped someone", "60 seconds");
        ListingActivity listingActivity = new ListingActivity("Listing activity", "Listing", "List things you are grateful for", "90 seconds");
        DancingActivity dancingActivity = new DancingActivity("Dancing activity", "Dancing", "Dance to your favorite song", "120 seconds");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Dancing");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                breathingActivity.StartActivity();
            }
            else if (choice == "2")
            {
                reflectingActivity.StartActivity();
            }
            else if (choice == "3")
            {
                listingActivity.StartActivity();
            }
            else if (choice == "4")
            {
                dancingActivity.StartActivity();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    static Dictionary<string, int> activityLog = new Dictionary<string, int>();
    static void LoadLog()
    {
        if (File.Exists("activityLog.txt"))
        {
            string[] lines = File.ReadAllLines("activityLog.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                activityLog.Add(parts[0], int.Parse(parts[1]));
            }
        }
    }
    static void SaveLog()
    {
        var lines = activityLog.Select(kvp => $"{kvp.Key}:{kvp.Value}");
        File.WriteAllLines("activityLog.txt", lines);
    }
    static void LogActivity(string activityName)
    {
        if (!activityLog.ContainsKey( activityName))
        {
            activityLog[activityName] = 0;
        }
        activityLog[activityName]++;
    }

}

class Activity
{
    public string Message{get; set; }
    public string Name{get; set; }
    public string Description{get; set; }
    public string Duration{get; set; }

    public Activity(string message, string name, string description, string duration)
    {
        Message = message;
        Name = name;
        Description = description;
        Duration = duration;
    }
    public virtual void  StartActivity()
        {
         Console.WriteLine($"{Name}: {Description} {Duration}");
         Console.WriteLine("Enter the duration of the activity in seconde: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing to start the activity...");
        ShowAnimation(3);
        Console.WriteLine($"Starting the activity: {Name} for {duration} seconds...");
        ShowAnimation(4);
        EndActivity(duration);
        
        }
        public virtual void EndActivity( int duration)
        {
            Console.WriteLine("Good job!.");
            ShowAnimation(3);
            Console.WriteLine($"Ending the activity: {Name} for {duration} seconds...");
        }
        protected void ShowAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("--"); // Animation
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
}

class BreathingActivity : Activity
{
    public BreathingActivity(string message, string name, string description, string duration) : base(message, name, description, duration)
    {   
    }
    public override void StartActivity()
    {
        Console.WriteLine($"Starting the activity: {Name} for {Description} seconds...");
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing to start the activity...");
        ShowAnimation(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"Elapsed: {elapsed} seconds");
            ShowBreathingAnimation(1);
            elapsed++;

            if (elapsed == duration) break;
            Console.WriteLine("Breathe out...");
            ShowBreathingAnimation(1);
            elapsed++;
        }
        EndActivity(duration);
    }
    private void ShowBreathingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(new string('.', 3));  // Breathing animation");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
class ReflectingActivity : Activity
{
private static readonly string[] Prompts = { "", "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", };
    
    private static readonly string [] Questions ={
        "",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    private List<string> usedPrompts = new List<string>();
    private List<string> usedQuestions = new List<string>();
    public ReflectingActivity(string message, string name, string description, string duration) : base(message, name, description, duration)
    {
    }
    public override void StartActivity()
    {
        Console.WriteLine($"Starting the activity: {Name} for {Description} seconds...");
        Console.WriteLine("Enter the duration of the activity in seconde: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing to start the activity...");
        ShowAnimation(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"Elapsed: {elapsed} seconds");
            ShowReflectingAnimation(1);
            elapsed++;

            if (elapsed == duration) break;
            Console.WriteLine("Reflecting...");
            ShowReflectingAnimation(1);
            elapsed++;
        }
        EndActivity(duration);
    }
    private void ShowReflectingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(new string('.', 3));  // Reflecting animation");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
    private string GetRandomPrompt( Random random)
    {
        if (usedPrompts.Count == Prompts.Length)
        {
            usedPrompts.Clear();
        }
        string prompt;
        do 
        {
            prompt = Prompts[random.Next(Prompts.Length)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }
    private string GetRandomQuestion( Random random)
    {
        if (usedQuestions.Count == Questions.Length)
        {
            usedQuestions.Clear();
        }
        string question;
        do 
        {
            question = Questions[random.Next(Questions.Length)];
        } while (usedQuestions.Contains(question));

        usedQuestions.Add(question);
        return question;
    }

}
class ListingActivity : Activity 
{
    private static readonly string[] Prompts = { "", "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",};
    private List<string> usedPrompts = new List<string>();
    public ListingActivity(string message, string name, string description, string duration) : base(message, name, description, duration)
    {
    }
    public override void StartActivity()
    {
        Console.WriteLine($"Starting the activity: {Name} for {Description} seconds...");
        Console.WriteLine("Enter the duration of the activity in seconde: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing to start the activity...");
        ShowAnimation(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"Elapsed: {elapsed} seconds");
            ShowListingAnimation(1);
            elapsed++;

            if (elapsed == duration) break;
            Console.WriteLine("Listing...");
            ShowListingAnimation(1);
            elapsed++;
        }
        Console.WriteLine($"You have listed {duration} items.");
        EndActivity(duration);
    }
    private void ShowListingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine(new string('.', 3));  // Listing animation
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
    private string GetRandomPrompt( Random random)
    {
        if (usedPrompts.Count == Prompts.Length)
        {
            usedPrompts.Clear();
        }
        string prompt;
        do 
        {
            prompt = Prompts[random.Next(Prompts.Length)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }

}
// this is my Creativity and Exceeding Requirements I have added a new class DancingActivity that inherits from Activity
// The DancingActivity class should have
// - A constructor that takes in a message, name, description, and duration.
class DancingActivity : Activity
{
    public DancingActivity(string message, string name, string description, string duration) : base(message, name, description, duration)
    {
    }
    public override void StartActivity()
    {
        Console.WriteLine($"Starting the activity: {Name} for {Description} seconds...");
        Console.WriteLine("Enter the duration of the activity in seconde: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing to start the activity...");
        ShowAnimation(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine($"Elapsed: {elapsed} seconds");
            ShowDancingAnimation(1);
            elapsed++;

            if (elapsed == duration) break;
            Console.WriteLine("Dancing...");
            ShowDancingAnimation(1);
            elapsed++;
        }
        EndActivity(duration);
    }
    private void ShowDancingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
             Console.WriteLine(new string(' ', i) + "💃"); // Dancing animation with imoji
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}