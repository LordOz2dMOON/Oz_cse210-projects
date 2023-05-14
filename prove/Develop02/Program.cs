using System;

class Program
{
    static void Main(string[] args)
    {
          
          Journal newJournal = new Journal();
          PromptsGenerator userPrompts = new PromptsGenerator();
       
        while (true)
        {
            Console.WriteLine("Welcome to the journal");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("6.Provide a directory to search");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);

            switch (number)
            {

                case 1:
                string prompt = userPrompts.GetPrompts();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._response = response;
                newJournal.AddEntry(entry);
                break;
                case 2:
                newJournal.DisplayEntries();
                break;
                case 3:
                 Console.WriteLine("What is the filename?");
                 string fileName = Console.ReadLine();
                 newJournal.LoadFromFile(fileName);
                 break;
                 case 4:
                 Console.WriteLine("What is the filename?");
                 string filename = Console.ReadLine();
                 newJournal.SaveToFile(filename);
                 break;
                 case 5:
                 Environment.Exit(0);
                 break;
                 case 6:
                 Console.WriteLine("What is the directory?");
                 string fileDirectory = Console.ReadLine();
                 newJournal.SearchForFile(fileDirectory);
                 Console.WriteLine(" ");
                 break;
           }
        }
    }
        
}