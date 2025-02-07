using System;
using System.Collections.Generic;
public class Program
{
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
            if (hideFirstScripture)
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
            scripture1.HideRandomWords();
            if (scripture1.AllWordsHidden())
            {
                scripture1.Display();
                Console.WriteLine($"\nAll words are hidden. Program will end.");
                hideFirstScripture = false;
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
public class Scripture 
{ // class definition goes here
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

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

    public void HideRandomWords()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}

public class Reference
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

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_startVerse}{(_startVerse != _endVerse ? $"-{_endVerse}" : "")}";
    }
}

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Display()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
}
