public class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected string goalType;
    protected bool isComplete;

    public Goal(string name, string description, int points, string goalType)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.goalType = goalType;
        //this.isComplete = isComplete;
    }

    public Goal(string savedGoal)
    {
        //parse saved goal into the attributes
        List<string> attributes = savedGoal.Split('|').ToList();
        name = attributes[1];
        description = attributes[2];
        points = Convert.ToInt16(attributes[3]);
    }
    

    public override string ToString()
    {   
        string result;
        if (isComplete)
        {
            result = $"[x] {name} {description} {points}";
        }
        else
        {
            result = $"[ ] {name} {description} {points}";
        }
        return result;
    }

    public virtual string RenderSavedGoal()
    {
        return $"{goalType}|{name}|{description}|{points}|{isComplete}";
    }

    public virtual int RecordEvent()
    {
        return points;
    }
}