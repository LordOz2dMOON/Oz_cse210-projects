abstract public class Activity
{
    protected string _description;
    protected int _durationInSeconds;
    protected string _name;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _durationInSeconds;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(" ");
        Console.WriteLine($"{_description}");
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        _durationInSeconds = int.Parse(time);
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine(" ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_durationInSeconds} seconds of the {_name} Activity.");
        Console.WriteLine(" ");
    }

    protected void ShowCountdownTimer()
    {
       for (int i = 6; i > 0; i--)
       {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
       }
    }

    public void ShowSpinner()
    {
        List<string> animationObject = new List<string>();
        animationObject.Add("|");
        animationObject.Add("/");
        animationObject.Add("-");
        animationObject.Add("\\");
        animationObject.Add("|");
        animationObject.Add("/");
        animationObject.Add("-");
        animationObject.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationObject[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationObject.Count)
            {
                i = 0;
            }
        }
    }
}