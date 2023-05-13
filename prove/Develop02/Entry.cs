public class Entry
{
    public List<string> _entries = new List<string>();
    public string _prompt = "";
    public string _response = "";
    DateTime _currentDate = DateTime.Now;

    public void AddEntry(string prompt, string response)
    {
        _entries.Add(prompt);
        _entries.Add(response);
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_currentDate} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}