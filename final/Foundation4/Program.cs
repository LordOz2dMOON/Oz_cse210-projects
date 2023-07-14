using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>{
            new Running(30, "14 july 2023", 3.0),
            new Cycling(50, "15 july 2023", 60),
            new Swimming(30, "18 july 2023", 25)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    

    }
}