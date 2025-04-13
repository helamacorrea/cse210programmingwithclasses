public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name,description,points)
    {

    }
    public override int IsCheckListFull()
    {
        return 0;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()}**{GetDescription()}**{GetPoints()}";
    }
    
}