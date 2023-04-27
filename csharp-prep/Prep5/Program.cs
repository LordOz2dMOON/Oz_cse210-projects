using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string name)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(int number)
        {
            Console.Write("Please enter your favorite number: ");
            string figure = Console.ReadLine();
            int favNumber = int.Parse(figure);
            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }

        DisplayWelcome();
        
        PromptUserName("Oswald");
        PromptUserNumber(42);
        SquareNumber(42);
        DisplayResult("Brother Burton", SquareNumber(42));


    }
}