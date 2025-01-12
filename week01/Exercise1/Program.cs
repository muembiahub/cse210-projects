using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your firstname?"); // user input
        string firstname = Console.ReadLine();

        Console.Write("What is your lastname?"); // user input
        string lastname = Console.ReadLine();

        Console.WriteLine($"Hello,Your name is {firstname} {firstname} {lastname}!"); // Fix this line
    }
}
