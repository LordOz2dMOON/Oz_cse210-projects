using System.IO; 
public class Goal
{
    protected string _description;
    protected int _points;
    protected string _name{get; set;}
    protected List<Goal> _goals;
    protected bool _isComplete;
    protected int _score;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string ListGoal()
    {
        if(_isComplete == true)
        {
            return $"[x] {_name} ({_description})";
        }
        else
            return $"[] {_name} ({_description})";
    }

    public void SaveToFile(string filename)
    {
        //Console.Write("what is your filename?");
        //string nameOfFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine("This will be the first line in the file.");
    
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
}
    }

    public void RecordEvent(int _points)
    {
        this._score += _points;
    }



    
}