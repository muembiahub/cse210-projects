using System;//namespace declaration

class Program //class declaration
{
    static void Main(string[] args)     //main method

    {
        List<int> numbers = new List<int>();//create a list of numbers
        
        int userNumber = -1;//initialize the user numbers
        while (userNumber != 0)//while the user number is not equal to 0
        {
            Console.WriteLine("Enter a number: ");//prompt the user to enter a number
            string userResponse = Console.ReadLine();//user input
            userNumber = int.Parse(userResponse);//parse the user input to an integer
            if (userNumber != 0)//if the user number is not equal to 0
            {
                numbers.Add(userNumber);//add the number to the list
            }
        }
        // compute de sum, average, max, min, difference, square of the sum
        int sum = 0;//initialize the sum
        foreach (int number in numbers)//for each number in the list
        {
            sum += number;//add the number to the sum
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");//display the sum
        float average = (float)sum / numbers.Count;//calculate the average
        Console.WriteLine($"The average of the numbers is: {average}");//display the average
        int max = numbers.Max();//find the maximum number
        Console.WriteLine($"The maximum number is: {max}");//display the maximum number
        int min = numbers.Min();//find the minimum number
        Console.WriteLine($"The minimum number is: {min}");//display the minimum number
        int difference = max - min;//calculate the difference
        Console.WriteLine($"The difference between the maximum and minimum number is: {difference}");//display the difference
        int squareOfSum = sum * sum;//calculate the square of the sum
        Console.WriteLine($"The square of the sum is: {squareOfSum}");//display the square of the sum
        Console.WriteLine("Goodbye!");//display message
        
        }
    }