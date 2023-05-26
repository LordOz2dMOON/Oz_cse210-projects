using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 nephi", "1", "15");
        Scripture scripture = new Scripture("And after this manner was the language of my father in the praising of his God; for his soul did rejoice, and his whole heart was filled, because of the things which he had seen, yea, which the Lord had shown unto him.", reference, 1);
        string Uinput = "";
        do{Console.WriteLine(scripture.ToString());
           Console.Write("Press enter to continue or quit to finish  ");
           Uinput = Console.ReadLine();
          } while (!scripture.AllHidden() && Uinput.ToLower() != "quit");
    }
}