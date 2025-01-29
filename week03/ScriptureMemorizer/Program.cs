using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        // Your main program logic here
    }
}

public class Scripture
{
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
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
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
