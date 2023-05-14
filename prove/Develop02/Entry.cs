public class Entry
{
    public string _prompt = "";
    public string _response = "";
    DateTime _currentDate = DateTime.Now;
    string _dateString = DateTime.Now.ToString("dd-MM-yyyy"); 

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_currentDate} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    }
}