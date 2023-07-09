public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points) :base (name, description, points, "EternalGoal")
    {}

    public EternalGoal(string savedGoal): base(savedGoal)
    {}
}