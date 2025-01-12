// This program prompts the user for their name and favorite number,
// then calculates the square of the number and displays the result.
using System;// System is a namespace

class Program // Program is a class
{
    static void Main(string[] args)// args is a parameter
    {
        DisplayWelcomeMessage();// no parameters

        string userName = PromptUserName();//   userName is a parameter
        int userNumber = PromptUserNumber();// userNumber is a parameter

        int squaredNumber = SquareNumber(userNumber);// userNumber is an argument

        DisplayResult(userName, squaredNumber);// userName and squaredNumber are arguments
    }

    static void DisplayWelcomeMessage()// no parameters
    {
        Console.WriteLine("Welcome to the program!");// no parameters
    }

    static string PromptUserName()//   name is a parameter
    {
        Console.Write("Please enter your name: ");// name is a parameter
        string name = Console.ReadLine();// name is an argument

        return name;// name is an argument
    }

    static int PromptUserNumber()// number is a parameter
    {
        Console.Write("Please enter your favorite number: ");// number is an argument
        int number = int.Parse(Console.ReadLine());// number is an argument

        return number;// number is an argument
    }

    static int SquareNumber(int number)// number is a parameter
    {
        int square = number * number; // number ^ 2
        return square;// square is an argument
    }

    static void DisplayResult(string name, int square)//    name and square are parameters
    {
        Console.WriteLine($"{name}, the square of your number is {square}");//name and square are arguments
    }
}
