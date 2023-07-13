using System.Text;
public class Outdoor : Event
{
    string _weatherForecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) :
    base(title, description, date, time, address, "Outdoor")
    {
        _weatherForecast = weather;
    }

    public override string GetFullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{base.GetStandardDetails()}");
        sb.AppendLine($"Event Type: {_eventType}");
        sb.AppendLine($"Weather Forecast: {_weatherForecast}");
        return sb.ToString();
    }

}