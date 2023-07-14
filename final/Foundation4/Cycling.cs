public class Cycling: Activity
{
    protected double speed;

     public Cycling(int length, string date, double speed): base(length, date, "Cycling")
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * base.length;
    }

    public override double GetSpeed()
    {
        return  Math.Round((GetDistance() / base.length) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(base.length / GetDistance(), 2);
    }
}