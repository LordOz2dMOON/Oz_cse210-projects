public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void ShowBreathInMessage()
    {
        Console.Write($"Breath In...");
        ShowCountdownTimer();
    }

    public void ShowBreathOutMessage()
    {
        Console.Write($"Now breath out...");
        ShowCountdownTimer();
        Console.WriteLine(" ");
    }

    public void Run()
    {
        int i = 0;
        int limit = _durationInSeconds / 10;
        while (i <= limit)
        {   
            ShowBreathInMessage();
            Console.WriteLine(" ");
            ShowBreathOutMessage();
            Console.WriteLine(" ");

            i++;
        }
    }
}