using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, What is your percentage ? ");
        string percentage = Console.ReadLine();
        int percentageValue = int.Parse(percentage);
       
        if (percentageValue >= 93)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is A");
        }
        else if (percentageValue == 90 || percentageValue == 92 || percentageValue == 91)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine($" Your  percentage : {percentageValue}%  Your Scale grade is A-");
        }
        else if (percentageValue >= 87|| percentageValue == 88 || percentageValue == 89)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is B+");
        }
        else if (percentageValue >= 86 || percentageValue == 84 || percentageValue == 85 || percentageValue == 83)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is B");
        }
        else if (percentageValue >= 80 || percentageValue == 81 || percentageValue == 82)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is B-");
        }
        else if (percentageValue == 79 || percentageValue == 78 || percentageValue == 77)
        {
            Console.WriteLine(" Congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is C+");
        }
       else if (percentageValue == 76 || percentageValue == 75 || percentageValue == 74 || percentageValue == 73)
        {
            Console.WriteLine("congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is C");
        }
        else if (percentageValue == 72 || percentageValue == 71 || percentageValue == 70)
        {
            Console.WriteLine("congratulation You have passed the exam");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is C-");
        }
        else  if (percentageValue <= 69)
        {
            Console.WriteLine("Sorry You have failed the exam");
            Console.WriteLine ("You should do on the futur your best to pass the exam again");
            Console.WriteLine ($" Your  percentage : {percentageValue}%  Your Scale grade is F");
        }
    }
}
