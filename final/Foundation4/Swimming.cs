public class Swimming: Activity
{
    protected int laps;

     public Swimming(int length, string date, int laps): base(length, date, "Swimming")
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(laps * 50 / 1000 * 0.62, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / base.length) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(base.length / GetDistance(), 2);
    }
}