using System;

class Program
{
    static void Main(string[] args)
    {
        Address Venue1 = new Address("Nigeria", "Lagos", "Eko hotel and suites");
        Address Venue2 = new Address("Nigeria", "Edo state", "Randekhi hotels");
        Address Venue3 = new Address("Nigeria", "Lagos State", "Gabriel Akinmade Taylor Plaza");
        List<Event> events = new List<Event>{
            new Lecture("Biology discourse", "A lecture on biology", "20th november 2023", "10:15 AM", Venue1, "Pamela", 1500),
            new Reception("Eddy's Wedding", "wedding of Eddy and Favor", "21st december 2023", "12 PM", Venue2, "lavishevents@gmail.com"),
            new Outdoor("Birthday party", "birthday party for wisdom", "26th november 2023", "1:30 PM", Venue3, "sunny")

        };

        for (int i = 0; i < events.Count; i++)
        {
            Console.WriteLine($"{events[i].GetStandardDetails()}");
            Console.WriteLine($"{events[i].GetFullDetails()}");
            Console.WriteLine($"{events[i].GetShortDescription()}");
            Console.WriteLine(" ");
        }
    }
}