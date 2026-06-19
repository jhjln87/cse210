public class Eternal : Goal
{
    public Eternal(string goal, int pointsWorth) :base(goal, pointsWorth)
    {
    }
    public Eternal(string goal, string description, int pointsWorth) :base(goal, description, pointsWorth)
    {
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
}