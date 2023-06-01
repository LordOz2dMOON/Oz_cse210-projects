using System;

class Program
{
    static void Main(string[] args)
    {
        //base class Assignment object
        Assignment maths = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(maths.GetSummary());
        Console.WriteLine(" ");

        //derived class MathAssignment object
        MathAssignment Assign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(Assign.GetSummary());
        Console.WriteLine(Assign.GetHomeworkList());
        Console.WriteLine(" ");

        //derived class WritingAssignment object
        WritingAssignment Assign2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(Assign2.GetSummary());
        Console.WriteLine(Assign2.GetWritingInformation());
        Console.WriteLine(" ");
    }
}