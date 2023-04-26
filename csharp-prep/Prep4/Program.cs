using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a list of numbers, type 0 when finished.");
      //string userInput = Console.ReadLine();

      int number = 4;
      List <int> listOfNumbers = new List<int>();
      while (number != 0)
      {
        Console.Write("Enter number: ");
        string listItem = Console.ReadLine();
        number = int.Parse(listItem);
        listOfNumbers.Add(number);
        if (number == 0)
        {
          int sum = 0;
          int listCount = listOfNumbers.Count - 1;
          double average = 0;
          int max = listOfNumbers.Max();
          for (int i = 0; i < listOfNumbers.Count; i++)
          {
            sum += listOfNumbers[i];
            average = sum / listCount;
          }
          Console.WriteLine($"The sum is: {sum}");
          Console.WriteLine($"The average is: {average}");
          Console.WriteLine($"The largest number is {max}");
          break;
        }
      }
    }
}