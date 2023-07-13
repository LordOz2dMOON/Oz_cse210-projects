public class Address
{
    protected string country;
    protected string state;
    protected string venue;

    public Address(string country, string state, string venue)
    {
        this.country = country;
        this.state = state;
        this.venue = venue;
    }

    public override string ToString()
    {
        return $"{venue}, {state}, {country}";
    }
}