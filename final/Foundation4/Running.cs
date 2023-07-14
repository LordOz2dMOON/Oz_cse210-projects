public class Running: Activity
{
    protected double distance;

    public Running(int length, string date, double distance): base(length, date, "Running")
    {
        this.distance = distance;
    }
    
    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((distance / base.length) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(base.length / distance, 2);
    }
}