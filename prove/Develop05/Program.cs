using System;

class Program
{
    static void Main(string[] args)
    {
        
        int score = 0;
        int answer = 0;
        do {
        Goal newSimpleGoal = new Goal("Give a talk", "Give a talk at church", 50, "simple");
        Console.WriteLine($"You have {score} points");
        List<Goal> goals = new List<Goal>();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1.create new goal");
        Console.WriteLine(" 2.List Goals");
        Console.WriteLine(" 3.Save Goals");
        Console.WriteLine(" 4.Load Goals");
        Console.WriteLine(" 5.Record Event");
        Console.WriteLine(" 6.Quit");
        Console.Write("Select a choice from the menu");
        string choice = Console.ReadLine();
        answer = int.Parse(choice);
        if (answer == 1)
        {
            Console.WriteLine("1.Simple goal");
            Console.WriteLine("2.Eternal goal");
            Console.WriteLine("3.Checklist goal");
            Console.Write("Select a choice from the menu ");
            string secondChoice = Console.ReadLine();
            int secondAnswer = int.Parse(secondChoice);
            if (secondAnswer == 1)
            {
                Console.Write("What is the name of your goal?");
                string name = Console.ReadLine();
                Console.Write("Describe your goal briefly");
                string description = Console.ReadLine();
                Console.Write("How many points are associated with your goal?");
                string points = Console.ReadLine();
                int number = int.Parse(points);
                SimpleGoal goal = new SimpleGoal(name, description, number, "simple");
                goals.Add(goal);
            }
        }
        else if (answer == 2)
        {
            foreach(Goal goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

     } while (answer != 6);
    }
}