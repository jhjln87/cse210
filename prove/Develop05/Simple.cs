public class Simple : Goal
{
    public Simple(string goal, int pointsWorth) :base(goal, pointsWorth)
    {
    }
    public Simple(string goal, string description, int pointsWorth) :base(goal, description, pointsWorth)
    {
    }
    public override string GetGoalDetails(bool save)
    {
        if (save)
        {
            return base.GetGoalDetails(save) + IsComplete();
        }
        return base.GetGoalDetails(save);
    }
}