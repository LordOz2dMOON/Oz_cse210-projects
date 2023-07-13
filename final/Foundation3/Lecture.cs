using System.Text;
public class Lecture : Event
{
    protected string _speakerName;
    protected int _capacity;

    
    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) :
    base(title, description, date, time, address, "Lecture")
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{base.GetStandardDetails()}");
        sb.AppendLine($"Event Type: {_eventType}");
        sb.AppendLine($"Speaker Name: {_speakerName}");
        sb.AppendLine($"Capacity: {_capacity}");
        return sb.ToString();
    }

}