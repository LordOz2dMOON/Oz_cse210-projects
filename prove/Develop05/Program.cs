using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        int answer = 0;
        do
        {
            Console.WriteLine($"You have {score} points");
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
                Console.WriteLine("4.Negative goal");
                Console.Write("Select a choice from the menu ");
                string secondChoice = Console.ReadLine();
                int secondAnswer = int.Parse(secondChoice);
                goals.Add(CreateGoal(secondAnswer));

            }
            else if (answer == 2)
            {
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(goal.ToString());
                }
            }
            else if (answer == 3)
            {

                Console.WriteLine("What is the name of your file");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.RenderSavedGoal());
                    }
                }
            }
            else if (answer == 4)
            {
                Console.WriteLine("What is the filename you want to load?");
                string responseFilename = Console.ReadLine();
                goals.Clear();
                string[] lines = System.IO.File.ReadAllLines(responseFilename);
                foreach (string line in lines)
                {
                     List<string> attributes = line.Split('|').ToList();
                     if (attributes[0] == "SimpleGoal")
                     {
                        goals.Add(new SimpleGoal(line));
                     }
                     else if (attributes[0] == "ChecklistGoal")
                     {
                        goals.Add(new ChecklistGoal(line));                        
                     }
                     else if (attributes[0] == "EternalGoal")
                     {
                        goals.Add(new EternalGoal(line));                    
                     }
                     else if (attributes[0] == "NegativeGoal")
                     {
                        goals.Add(new NegativeGoal(line));
                     }
                }
            }
            else if (answer == 5)
            {
                int goalNumbers = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{goalNumbers} {goal.ToString()}");
                    goalNumbers++;
                }
                Console.Write("Which goal did you complete?");
                string goalCompleted = Console.ReadLine();
                int convertNumber = int.Parse(goalCompleted);
                int points = goals[convertNumber -1].RecordEvent();
                score += points;
            }
        } while (answer != 6);
    }
    public static Goal CreateGoal(int secondAnswer)
    {
        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.Write("Describe your goal briefly");
        string description = Console.ReadLine();
        Console.Write("How many points are associated with your goal?");
        string points = Console.ReadLine();
        int number = int.Parse(points);
        if (secondAnswer == 1)
        {
            return new SimpleGoal(name, description, number);
        }
        else if (secondAnswer == 2)
        {
            return new EternalGoal(name, description, number);
        }
        else if (secondAnswer == 4)
        {
            return new NegativeGoal(name, description, number);
        }
        else
        {
            Console.WriteLine("How many times do you want to complete this goal?");
            string times = Console.ReadLine();
            int numoftimes = int.Parse(times);
            Console.WriteLine("How many bonus points should be awarded for completing this goal?");
            string bonusNumber = Console.ReadLine();
            int bonus = int.Parse(bonusNumber);
            return new ChecklistGoal(name, description, number, numoftimes, bonus);
        }
    }
}
