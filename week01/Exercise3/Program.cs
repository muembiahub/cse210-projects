using System;//namespace declaration

class Program//class declaration
{
    static void Main()//main method
    {
        Random random = new Random(); //random number generator
        int magicnumber = random.Next(1, 101); //random number between 1 and 100
        int guess = -1; //initial guess
        int attempts = 5;//number of attempts
        Console.WriteLine("Welcome to the magic number game!");//display message
        Console.WriteLine($"You have {attempts} to guess the magic number");//display message
        Console.WriteLine("The magic number is between 1 and 100");//display message
        Console.WriteLine("Good luck!");//display message
        while (guess != magicnumber) //while the guess is not equal to the magic number
        {
            Console.WriteLine("Guess the magic number: ");//prompt the user to guess the magic number
            guess = int.Parse(Console.ReadLine()); //user input
            if (guess == magicnumber)   //if the guess is correct
            {
                Console.WriteLine("Congratulations! You guessed the magic number");//display message
                Console.WriteLine($"The magic number was {magicnumber}");//display the magic number
                break;//break the loop
            }
            else if (guess < magicnumber)//if the guess is lower than the magic number
            {
                Console.WriteLine("Sorry, the number is higher");//display message
                attempts--;//decrement the number of attempts
                Console.WriteLine($"You have {attempts} attempts left");//display message
            }
            else if (guess > magicnumber)//if the guess is higher than the magic number
            {
                Console.WriteLine("Sorry, the number is lower");//display message
                attempts--;//decrement the number of attempts
                Console.WriteLine($"You have {attempts} attempts left");
                continue;//continue the loop
            }
            
            else if (attempts == 0) //if the user runs out of attempts
            {
                Console.WriteLine("Sorry, you ran out of attempts");//display message
                Console.WriteLine($"The magic number was {magicnumber}");//display the magic number
                break;//break the loop
            }
            else //if the user enters an invalid input
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 100"); //if the user enters an invalid input
            }
        
        }
    }
}