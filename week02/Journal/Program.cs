using System; // Add this line to use Console
using System.Collections.Generic; // Add this line to use List
using System.IO; // Add this line to use StreamWriter and StreamReader
using System.Text; // Add this line to use StringBuilder
namespace Resumes // Add this line to declare the namespace
{
        class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu:"); // Add this line to display the menu
                Console.WriteLine("1. New Entry");// Add this line to display the option for new entry
                Console.WriteLine("2. Display Journal");// Add this line to display the option for displaying journal
                Console.WriteLine("3. Save Journal to File");// Add this line to display the option for saving journal
                Console.WriteLine("4. Load Journal from File");// Add this line to display the option for loading journal
                Console.WriteLine("5. opened in Excel");// Add this line to display the option for opening journal in Excel
                Console.WriteLine("6. Exit");// Add this line to display the option for exiting the program
                Console.Write("Choose an option: ");// Add this line to prompt for choice
                string choice = Console.ReadLine();// Add this line to read the choice by the user

                switch (choice) // Add this switch statement
                {
                    case "1": // Add this case to handle new entry
                        journal.Thanksgiving();// Add this line
                        journal.AddEntry(); // Add this line
                        break; // Add this break
                    case "2": // Add this case to handle display journal
                        journal.DisplayEntries();
                        break;
                    case "3": // Add this case to handle save journal
                        Console.Write("Enter filename to save: "); // Add this line to prompt for filename
                        string saveFilename = Console.ReadLine(); // Add this line to read the filename
                        journal.SaveToFile(saveFilename);// Add this line to save the journal
                        break;
                    case "4":// Add this case to handle load journal
                        Console.Write("Enter filename to load: ");// Add this line to prompt for filename to load
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);// Add this line
                        break; // Add this break to exit the switch statement
                    case "5":// Add this case to handle open in Excel
                        Console.WriteLine("Opening journal in Excel...");// Add this line to display message to user
                        journal.OpenInExcel();// Add this line to open the journal in Excel
                        
                        break;// Add this break
                    case "6":// Add this case to handle exit
                        Console.WriteLine("Exiting...");// Add this line to display message to user
                        running = false; // Add this line to set running to false to exit the loop
                        break;
                    default:// Add this case to handle invalid choice
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;// Add this break
                }
            }
        }
    }
// Add the Journal and Entry classes here
    class Journal
    {
        private List<Entry> entries = new List<Entry>();
        private List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };// Add this list of prompts
// Add the AddEntry, DisplayEntries, SaveToFile, and LoadFromFile methods here
        public void AddEntry()
        {
            Random random = new Random();// Add this line
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Entry entry = new Entry { Prompt = prompt, Response = response, Date = DateTime.Now };// Add this line
            entries.Add(entry);
        }
// Add the DisplayEntries, SaveToFile, and LoadFromFile methods here
// The DisplayEntries method displays all the entries in the journal
        public void DisplayEntries()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
            }
        }
// Add the SaveToFile and LoadFromFile methods here
        public void SaveToFile(string filename)//
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.Date); // Add this line to write the date
                    writer.WriteLine(entry.Prompt);// Add this line to write the prompt
                    writer.WriteLine(entry.Response); // Add this line to write the response
                    writer.WriteLine(); // Add this line to write an empty line
                }
            }
        }
// Add the LoadFromFile method here
        public void LoadFromFile(string filename)
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename)) // Add this line to read from the file
            {
                while (!reader.EndOfStream)
                {
                    string date = reader.ReadLine(); // Add this line to read the date
                    string prompt = reader.ReadLine();// Add this line to read the prompt
                    string response = reader.ReadLine();// Add this line to read the response
                    reader.ReadLine(); // Skip empty line in the file
                    Entry entry = new Entry// Add this line to create a new entry to add to the list
                    {
                        Date = DateTime.Parse(date), // Add this line to parse the date to DateTime
                        Prompt = prompt,// Add this line to set the prompt to the value read from the file
                        Response = response // Add this line to set the response to the value read from the file
                    };
                    entries.Add(entry);// Add this line to add the entry to the list on each iteration
                }
            }
        }
// Add the OpenInExcel method here
public void OpenInExcel()// Add this method to open the journal in Excel    
        {
            StringBuilder csv = new StringBuilder();// Add this line to create a StringBuilder
            foreach (var entry in entries)// Add this line to iterate over the entries
            {
                csv.AppendLine($"{entry.Date},{entry.Prompt},{entry.Response}");// Add this line to append the entry to the StringBuilder
            }
            string filePath = Path.Combine(Environment.CurrentDirectory, "journal.csv");// Add this line to get the full path to the file
            File.WriteAllText(filePath, csv.ToString());// Add this line to write the StringBuilder to a file
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });// Add this line to open the file in Excel
        }

public void Thanksgiving()
{
    Console.WriteLine("Thanksgiving is a time to reflect on the blessings in our lives.");// Add this line to display message to user
    Console.WriteLine("What are you thankful for today?");// Add this line to prompt the user
    string response = Console.ReadLine();// Add this line to read the response
    Entry entry = new Entry { Prompt = "Thanksgiving", Response = response, Date = DateTime.Now };// Add this line to create a new entry
    entries.Add(entry);// Add this line to add the entry to the list
}
    }
  class Entry
    {
        public DateTime Date { get; set; }// Add this property to store the date
        public string Prompt { get; set; } // Add this property to store the prompt
        public string Response { get; set; } // Add this property to store the response
    }
}       