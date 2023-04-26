using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string firstNumber = Console.ReadLine();
        int magicNumber = int.Parse(firstNumber);
        int guess = 0;

        while (guess != magicNumber)
        {
            
            Console.Write("What is your guess? ");
            string secondNumber = Console.ReadLine();

            
            guess = int.Parse(secondNumber);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }else
            {
                Console.WriteLine("You guessed it! ");
                break;
            }
        }
    }
}