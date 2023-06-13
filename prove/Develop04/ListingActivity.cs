public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    private List<string> _PROMPTS = new List<string>()
    {
        "Who are people that you appreciate",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_PROMPTS.Count);
        string randomStringThree = _PROMPTS[index];
        return randomStringThree;
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("You may begin in: ");
        ShowCountdownTimer();
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(" ");
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine($"You listed {count} items.");

    }

    
}