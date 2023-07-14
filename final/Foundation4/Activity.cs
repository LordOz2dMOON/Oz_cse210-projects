public abstract class Activity
{
    protected int length;
    protected string date;
    protected string activityType;

    public Activity(int length, string date, string activityType)
    {
        this.length = length;
        this.date = date;
        this.activityType = activityType;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{date} {activityType} ({length} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }

}