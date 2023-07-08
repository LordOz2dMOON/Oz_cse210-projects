public class SimpleGoal: Goal
{
    public SimpleGoal(string name, string description, int points, string goalType) :base (name, description, points, goalType)
    {}

    public override int RecordEvent()
    {
        isComplete = true;
        return base.RecordEvent();
    }

    public SimpleGoal(string savedGoal): base(savedGoal)
    {}
}