using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int gradeLetter = int.Parse(grade);
        char Letter;

        if (gradeLetter <= 60)
        {
            Letter = 'F';
        }
        else if (gradeLetter >= 60 && gradeLetter < 70)
        {
            Letter = 'D';
        }
        else if (gradeLetter >= 70 && gradeLetter < 80)
        {
           Letter = 'C';
        }
        else if (gradeLetter >= 80 && gradeLetter < 90)
        {
           Letter = 'B';
        }
        else
        {
            Letter = 'A';
        }
        Console.WriteLine($"Your grade is: {Letter}");

        if (gradeLetter >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed the course, next time might be the charm");
        }

    }
}