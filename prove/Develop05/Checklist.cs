public class ChecklistGoal: Goal
{
    protected int numoftimes;
    protected int bonus;
    protected int completedCount;

    public ChecklistGoal(string savedGoal) : base(savedGoal)
    {
        //need to get the number of times, bonus and completed count and save
        string[] attributes = savedGoal.Split('|');
        numoftimes = Convert.ToInt32(attributes[5]);
        completedCount = Convert.ToInt32(attributes[6]);
        bonus = Convert.ToInt32(attributes[7]);
    }

    public ChecklistGoal(string name, string description, int points, string goalType, int numoftimes, int bonus, int completedCount) 
    : base(name, description, points, goalType)
    {
        this.numoftimes = numoftimes;
        this.bonus = bonus;
        this.completedCount = completedCount;
    }

    public override int RecordEvent()
    {
        int points = base.RecordEvent();
        completedCount++;
        if (completedCount  == numoftimes)
        {
            isComplete = true;
            points += bonus;
        }
        return points;
    }

    public override string RenderSavedGoal()
    {
        return $"{goalType}|{name}|{description}|{points}|{isComplete}|{numoftimes}|{bonus}|{completedCount}";
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Currently comleted: {completedCount}/{numoftimes}";
    }











    
}