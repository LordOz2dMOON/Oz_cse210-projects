public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points, string goalType) :base (name, description, points, goalType)
    {}

    public EternalGoal(string savedGoal): base(savedGoal)
    {}
}