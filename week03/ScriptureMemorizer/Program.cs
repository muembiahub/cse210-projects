using System; // Add a using directive for System
using System.Collections.Generic; // Add a using directive for System.Collections.Generic
// Add a class called ScriptureMemorizer
class ScriptureMemorizer
{
    // Add a Main method to demonstrate the classes
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    // Create a new scripture object to demonstrate creativity on the project
    // the program combine two scriptures and display them in a random order and hide some words
    // the program will display the first scripture and hide some words and then display the second scripture and hide some words
    // the program will continue to display the scriptures until all words are hidden
        Reference reference2 = new Reference("Jacod", 2, 17);
        Scripture scripture2 = new Scripture(reference2, "Think of your brethren like unto yourselves, and be familiar with all and free with your substance, that they may be rich like unto you.");
        bool hideFirstScripture = true;
    // Display the first scripture and hide some words

        while (true)
        {
            if (hideFirstScripture) // Display the first scripture and hide some words
            {
            scripture1.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();
    // End the program if the user types 'quit'
            if (input.ToLower() == "quit")
            {
                break;
            }
    // Hide random words in the first scripture
            scripture1.HideRandomWords(); // Hide random words in the first scripture
            if (scripture1.AllWordsHidden())
            {
                scripture1.Display();
                Console.WriteLine($"\nAll words are hidden. Program will end."); // Display the first scripture and hide some words
                hideFirstScripture = false; // Display the first scripture and hide some words
            }
        }
        else 
        {  
    // Display the second scripture and hide some words
    // Display the second scripture and hide some words
            scripture2.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
    // Hide random words in the second scripture
            scripture2.HideRandomWords();
            if (scripture2.AllWordsHidden())
            {
    // Display the second scripture and hide some words
                scripture2.Display();
                Console.WriteLine("\nAll words are hidden. Program will end.");
                break;
            }
        }
        hideFirstScripture = !hideFirstScripture;
    }
}
class Scripture 
{   
    // class definition goes here
    private Reference _reference;
    private List<Word> _words;
    // Add a constructor that initializes the reference and words
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    // Display the scripture in the format "John 3:16" and "Jacod 2:17" followed by the words
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }
    // Hide a random word in the scripture
    public void HideRandomWords()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].Hide();
    }
    // Return true if all words are hidden, otherwise return false
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
    // Add a class called Reference
class Reference
{
    private string _book; // e.g. John
    private int _chapter; // e.g. 3
    private int _startVerse; // e.g. 16
    private int _endVerse; // e.g. 16

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book; // 
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse ?? startVerse;
    }
    // Display the reference in the format "John 3:16"
    public override string ToString()
    {
        return $"{_book} {_chapter}:{_startVerse}{(_startVerse != _endVerse ? $"-{_endVerse}" : "")}";
    }
}

    // Add a class called Word
class Word
{
    // Add private fields for text and isHidden
    private string _text;
    // Add a private field for isHidden
    private bool _isHidden;
    // Add a constructor that initializes the text and sets isHidden to false
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
   // Add a method called Hide that sets isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }

    // Display the word if it is not hidden, otherwise display underscores
    public string Display()
    { // method definition goes here
        return _isHidden ? new string('_', _text.Length) : _text;
    }
    // Return true if the word is hidden, otherwise return false
    public bool IsHidden()
    {
        return _isHidden;
    }
}
}
   // Compare this snippet from week03/ScriptureMemorizer/Program.cs: