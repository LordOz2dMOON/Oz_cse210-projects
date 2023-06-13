using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listing activtity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();
        choice = int.Parse(input);
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity();
            breath.DisplayStartingMessage();
            breath.Run();
            breath.DisplayEndingMessage();
        }

        if (choice == 2)
        {
            ReflectionActivtity reflect = new ReflectionActivtity();
            reflect.DisplayStartingMessage();
            reflect.Run();
            reflect.DisplayEndingMessage();
        }

        if (choice == 3)
        {
            ListingActivity list = new ListingActivity();
            list.DisplayStartingMessage();
            list.Run();
            list.DisplayEndingMessage();
        }

        if (choice == 4)
            System.Environment.Exit(0);
        } while (choice != 4);
    }
}