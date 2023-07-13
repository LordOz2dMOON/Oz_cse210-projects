using System.Text;
public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;



    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string GetStandardDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {_eventTitle}");
        sb.AppendLine($"Description: {_description}");
        sb.AppendLine($"Date: {_date}");
        sb.AppendLine($"Time: {_time}");
        sb.AppendLine($"Address: {_address}");
        return sb.ToString();
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Event Type: {_eventType}");
        sb.AppendLine($"Event Title: {_eventTitle}");
        sb.AppendLine($"Date: {_date}");
        return sb.ToString();
    }
}