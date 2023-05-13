using System;

class Program
{
    static void Main(string[] args)
    {
          Entry entry = new Entry();
          Journal newJournal = new Journal();
         
         List<string> Prompts = new List<string>();
        Prompts.Add("Did you workout today?");
        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");

        Random rnd = new Random();
        int randIndex = rnd.Next(Prompts.Count);
        string random = Prompts[randIndex];
        
        while (true)
        {
            Console.WriteLine("Welcome to the journal");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        switch (number)
        {

            case 1:
           
            Console.WriteLine(random );
            string response = Console.ReadLine();
            entry._prompt = random;
            entry._response = response;
            entry.AddEntry(random, response);
            break;
            case 2:
             foreach (string word in entry._entries)
            {
                entry.DisplayEntry();
            }
            break;
            
       }
       }



        


    }
}