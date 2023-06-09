public class ReflectionActivtity : Activity
{
    private List<string> _PROMPTS = new List<string>
{
"Think of a time when you stood up for someone else",
"Think of a time when you did something really difficult",
"Think of a time when you helped someone in need",
"Think of a time when you did something truly selfless",
};

private List<string> _QUESTIONS = new List<string>
{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?",
};

    public ReflectionActivtity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_PROMPTS.Count);
        string randomString = _PROMPTS[index];
        return randomString;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_QUESTIONS.Count);
        string randomStringTwo = _QUESTIONS[index];
        return randomStringTwo;
    }

    public void Run()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
        ShowCountdownTimer();
        int i = 0;
        int limit = _durationInSeconds / 10;
        while (i <= limit)
        {
            Console.WriteLine(" ");
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner();

            i++;
        }
    }

}