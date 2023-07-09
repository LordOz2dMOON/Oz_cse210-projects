public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int points) :base (name, description, points, "SimpleGoal")
    {}

    public override int RecordEvent()
    {
        isComplete = true;
        return base.RecordEvent();
    }

    public SimpleGoal(string savedGoal): base(savedGoal)
    {}
}