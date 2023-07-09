public class NegativeGoal: Goal
{
     public NegativeGoal(string name, string description, int points) :base (name, description, points, "NegativeGoal")
    {}

    public override int RecordEvent()
    {
        return -base.RecordEvent();
    }

    public NegativeGoal(string savedGoal): base(savedGoal)
    {}
}