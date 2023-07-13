using System.Text;
public class Reception : Event
{
    protected string _emailRSVP;

    public Reception(string title, string description, string date, string time, Address address, string email) :
    base(title, description, date, time, address, "Reception")
    {
        _emailRSVP = email;
    }

    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{base.GetStandardDetails()}");
        sb.AppendLine($"Event Type: {_eventType}");
        sb.AppendLine($"RSVP Email: {_emailRSVP}");
        return sb.ToString();
    }
}